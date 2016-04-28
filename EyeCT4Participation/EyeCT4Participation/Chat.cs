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


        int userID; 
        int userID2;
        int zenderID = DataBase.Database.acID;

        public Chat(int user1, int user2 )
        {
            InitializeComponent();
            this.userID = user1;
            this.userID2 = user2;
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
            DataBase.Database.chatsend(userID, userID2, chattosendTB.Text.ToString(), zenderID);
            //chathistory.Add(DataBase.Database.chatboc(userID, 2).ToString());
            //string message = chattosendTB.Text;
            //chats.MessageToChat(needyid, volunteerid, message);
            //DataBase.Database.GetUser();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataBase.Database.chatbox(userID, userID2);
            chatLB.Items.Clear();
            foreach (string chat in Database.chathistory)
            {
                chatLB.Items.Add(chat);
            }
        }

        private void planappointmentBTN_Click(object sender, EventArgs e)
        {
           DataBase.Database.makeapointment(1, userID, userID2);
        }

        private void BTNreportChat_Click(object sender, EventArgs e)
        {
            string selected = Convert.ToString(chatLB.SelectedItem);
            // ALTER 'CONTENT' BOOL REPORTED = FALSE 
            if (chatLB.Items == null)
            {
                MessageBox.Show("Nothing Selected!");
            }
            else
            {
                string xxx = "";
                string x = "";
                // SELECT CHATID FROM CHAT WHERE MESSAGE = SELECTEDITEMMESSAGE
                if (chatLB.SelectedItem != null)
                {
                    x = chatLB.SelectedItem.ToString();
                    int xx = x.IndexOf(":") + 2;
                    xxx = x.Substring(xx, x.Length - xx);
                }
                else { MessageBox.Show("Please select a message to report"); }
                
                DataBase.Database.getSelected("CHAT", xxx, "CHATID", "BERICHT");
                DataBase.Database.alterYorN("CHAT", Convert.ToInt32(DataBase.Database.ItemIDSelected), "CHATID", "ISREPORTED", "Y");
                MessageBox.Show("Message is reported");
                //m_command.CommandText = "UPDATE " + COLUMN + " SET " + visibleOrReported + " = 'Y' WHERE CHATID = '1'";
            }
           
        }
    }
}
