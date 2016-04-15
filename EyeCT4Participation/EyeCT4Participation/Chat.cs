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

namespace EyeCT4Participation
{
    public partial class Chat : Form
    {
        int needyid = 1;
        int volunteerid = 1;

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
            ChatHistory chats = new ChatHistory();
            chats.GetChatFromList(needyid, volunteerid);
            chatLB.SelectedIndex = chatLB.Items.Count - 1;
        }

        private void sendBTN_Click(object sender, EventArgs e)
        {
            ChatHistory chats = new ChatHistory();
            string message = chattosendTB.Text;
            chats.MessageToChat(needyid, volunteerid, message);
        }
    }
}
