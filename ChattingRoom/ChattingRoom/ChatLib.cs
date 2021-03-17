using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChattingRoom
{
    public class ChatSetting
    {
        //這邊為定義IP跟port(連線的對象)，這裡的寫法為這是Server的角色(110.03.15)
        //private static System.Net.IPAddress SvrIP = new System.Net.IPAddress(Dns.GetHostByName(Dns.GetHostName()).AddressList[0].Address);
        public static String serverIP = "192.168.31.143";
        public static int port = 3766;
    }

    public delegate String StrHandler(String str); //宣告函數指標            
    //這裡所用到的方式是"delegate"，delegate是個很抽象的存在，這網路查都會有(委派、執行緒、方法當作方法使用、委派還能當成事件使用...等等功能)，以新手來說算是複雜的(110.03.15)
    //這裡是有形態且有回傳值(委派與對應方法的型態(包含有無回傳值、參數等等都要一致)(110.03.15)
    //這邊你就想成是他用個方式一起進行(110.03.15)。

    public class ChatSocket
    {
        //定義以下參數(110.03.15)
        public Socket socket;
        public NetworkStream stream;
        public StreamReader reader;
        public StreamWriter writer;
        public StrHandler inHandler;  //把inHandler指向某個函數，然後用它來處理輸入訊息的部分
        public EndPoint remoteEndPoint;  //紀錄是誰連進來
        public bool isDead = false;  //記錄對方是否已經掛了

        public ChatSocket(Socket s)
        {
            socket = s;
            stream = new NetworkStream(s);
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream);
            remoteEndPoint = socket.RemoteEndPoint;//取得遠端端點。
            //RemoteEndPoint用此方式得知IP及port(110.03.15)
        }

        public String receive()
        {
            return reader.ReadLine();//自目前資料流讀取一行字元，並將資料以字串傳回。
        }

        public ChatSocket send(String line)
        {
            writer.WriteLine(line);//將字串 (其後加上行結束字元) 寫入到文字字串或資料流。
            writer.Flush();//清除目前寫入器 (Writer) 的所有緩衝區，並且造成所有緩衝資料都寫入基礎資料流。
            return this;
        }

        public static ChatSocket connect(String ip) //有人連進來時會呼叫
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ip), ChatSetting.port);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(endPoint);

            return new ChatSocket(socket);
        }

        public Thread newlistener(StrHandler pHandler)  //建立一個傾聽者去傾聽對方送訊息過來的事件
                                                        //讓他能夠用pHandler去處理訊息
        {
            inHandler = pHandler;

            Thread listenThread = new Thread(new ThreadStart(listen));
            //這邊是掛上執行續(委派delegate)，讓每次有連進來的時候(對象)說些什麼加以紀錄-(每一個連進來的對象都是一個獨立的個體所以需要執行續用來持續監控訊息)(110.03.15)
            //若不掛執行續，很多人連是沒錯但這邊會變得只能一個訊息，沒辦法切開是誰傳的訊息(因為都全部混再一起)(110.03.15)
            listenThread.Start();
            return listenThread;
        }

        private void listen()
        {
            try
            {
                while (true)
                {
                    String line = receive();  //收訊息
                    inHandler(line);
                }
            }
            catch (Exception ex)
            {
                isDead = true;
                Console.WriteLine(ex.Message);
            }
        }

    }
}
