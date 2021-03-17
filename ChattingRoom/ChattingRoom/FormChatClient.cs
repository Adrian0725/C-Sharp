using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChattingRoom
{
    public partial class FormChatClient : Form
    {
        ChatSocket client;
        StrHandler msgHandler;
        public FormChatClient()//建構值
        {
            InitializeComponent();
            msgHandler = this.addMsg;  
            //因為有回傳值，所以程式打開始先要讓建構值的東西放在他自己所建立好的參數，以便他執行續用到的時候好抓取(110.03.15)
            //若不寫在這裡的話可以寫在FormChatClient_Load裡面(此方法是打開程式就要先執行的地方像是initial的概念)(110.03.15)
        }
        
        

        private void buttonSend_Click(object sender, EventArgs e)
        {
            sendMsg();
        }

        private void textBoxMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '\r')
                sendMsg();           
        }

        public string user()
        {
            return textBoxUser.Text.Trim();//移除所有的開頭和結尾空白字元。
        }

        public string msg()
        {
            return textBoxMsg.Text;
        }


        private void sendMsg()
        {
            if (user().Length == 0)//判斷目前使用者有沒有輸入名稱，若沒有則是沒有長度的，因此會跳出視窗要求請輸入使用者名稱(110.03.15)
            {
                MessageBox.Show("請輸入使用者名稱!");
                return;
            }
            if (client == null)
            {
                client = ChatSocket.connect(ChatSetting.serverIP);//這邊是開始連上server的ip(110.03.15)
                client.newlistener(processMsgComeIn);
                //ChatServer.cs檔案ChattingRoom類別裡的40行有解說(110.03.15)

                client.send("< " + user() + " >  新使用者進入!");
                textBoxUser.Enabled = false;
            }
            if (msg().Length > 0)
            {
                client.send(user() + " : " + msg());
                textBoxMsg.Text = "";
            }
        }

        private string processMsgComeIn(string msg)
        {
            this.Invoke(msgHandler, new Object[] { msg });
            //在擁有控制項基礎視窗控制代碼的執行緒上，以指定的引數清單執行指定的委派。   
            //這邊是用到執行續的Invoke，就想成執行續需一值執行下去但依照需求(要用到此方法的才需要)進行委派作業(110.03.15)
            //這邊網路上可以查(110.03.15)
            return "OK";
        }

        private string addMsg(string msg)//此方法是很萬用方法(想成他把訊息能夠印出並且換行，就不用每次都寫很多程式，有條理的寫成一個方法讓要顯示訊息都用此方法)(110.03.15)
        {
            textBoxBroad.AppendText(msg + "\r\n");
            return "OK";//此需要回傳值((110.03.15))
            //這邊有/無需要回傳值，看個人要怎麼呈現，方法也會不同(110.03.15)
        }

        

    }
}
