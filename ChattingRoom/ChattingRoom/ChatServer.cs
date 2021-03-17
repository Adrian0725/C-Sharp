using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattingRoom
{
    class ChatServer
    {
        List<ChatSocket> clientList = new List<ChatSocket>();//此作法是將原本定義完成的之後

        public static void Main(String[] args)
        {
            ChatServer chatServer = new ChatServer();
            chatServer.run();
        }

        private void run()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, ChatSetting.port);//標識網路中某臺主機上的某一個程序。

            Socket newSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //addressFamily 指定 Socket 使用的定址方案，socketType 指定 Socket 的型別，protocolType 指定 Socket 使用的協議。

            newSocket.Bind(endPoint); //如果不事先Bind埠號的話，系統會預設在1024到5000隨機繫結一個埠號
            newSocket.Listen(10); //擱置連線佇列長度上限。

            while (true)
            {
                Socket socket = newSocket.Accept();
                Console.WriteLine("接受一個新連線!");
                ChatSocket client = new ChatSocket(socket);
                //建立新的Socket以處理傳入的連線請求。使用完 Socket 後，使用 Close 方法關閉 Socket。
                try
                {
                    clientList.Add(client);
                    client.newlistener(processMsgComeIn);
                    //newlistener是方法(按下F12可以快數追此方法)(110.03.15)
                    //先解說newlistener此方法是用來開創一個執行續用來持續監聽對方送訊息過來的事件(委派)(110.03.15)
                    //newlistener，此方法裡面的參數是吃delegate的屬性，要用委派工作必須同一個物件要一致(110.03.15)
                    //public delegate String StrHandler(String str);這邊型態已說明是字串形式處理(110.03.15)
                    //***
                    //簡單說明:此方法執行續一直執行監聽對象傳來的訊息，並以delegate(事件(委派)的方式處理)(110.03.15)
                    //所以說此msg是掛在執行續得來的訊息，但執行續一個程式只能執行一個，但有了委派可以並行做某些事情(方法)，而不互相打架一起占用到電腦的處理效能(110.03.15)
                    //這邊可以去網路上查執行續的寫法，並有delegate的時候的差別(網路都有)(110.03.15)
                }
                catch { }
            }
        }

        private string processMsgComeIn(string msg)
        {
            Console.WriteLine("\r\n收到訊息: \r\n" + msg);
            broadCast(msg);
            return "OK";
        }

        private void broadCast(string msg)
        {
            Console.WriteLine("廣播訊息: \r\n" + msg + "----給線上使用者共" + clientList.Count + "個人");
            foreach(ChatSocket client in clientList)
            {
                if (!client.isDead)
                {
                    Console.WriteLine("Send to " + client.remoteEndPoint.ToString() + " ----------" + msg);
                    client.send(msg);
                }
            }
        }
    }
}
