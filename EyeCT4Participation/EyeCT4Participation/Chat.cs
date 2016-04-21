using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Participation.Business;
using EyeCT4Participation.UI;
using EyeCT4Participation.DataBase;

namespace EyeCT4Participation
{
    public partial class Chat : Form
    {
        
        int volunteerid = 1;
        public int userID = DataBase.Database.acID;

        public Chat()
        {
            InitializeComponent();
        }

        private void closechatBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ChatMessages(Chatbox Chatbox)
        {
            chatLB.DataSource = Chatbox.messages;
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            //chats.GetChatFromList(needyid, volunteerid);
            //chatLB.SelectedIndex = chatLB.Items.Count - 1;
        }

        //List<string> chathistory = new List<string>();

        private void sendBTN_Click(object sender, EventArgs e)
        {
            DataBase.Database.chatsend(userID, 2, chattosendTB.Text.ToString());
            //chathistory.Add(DataBase.Database.chatboc(userID, 2).ToString());
            //string message = chattosendTB.Text;
            //chats.MessageToChat(needyid, volunteerid, message);
            //DataBase.Database.GetUser();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataBase.Database.chatbox(userID, 2);
            chatLB.Items.Clear();
            foreach (string chat in Database.chathistory)
            {
                chatLB.Items.Add(chat);
            }
        }

        
    }
}
