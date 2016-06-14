using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeCT4Participation
{
    public partial class Beheerder : Form
    {
        public Beheerder()
        {
            InitializeComponent();
        }

        public static string nameOfMessage;
        public static string currentContent;
        private Chat chat;

        //Admin Reported Requests opvragen <Raphael>
        private void reportedcontentBTN_Click(object sender, EventArgs e)
        {
            currentContent = "HULPVRAAG";
            nameOfMessage = "OMSCHRIJVING";
            LBSelectedContent.Items.Clear();
            DataBase.Database.reportedRequests.Clear();
          
            DataBase.Database.getReportedRequests("SELECT OMSCHRIJVING FROM HULPVRAAG WHERE ISREPORTED = 'N'");
            foreach (string item in DataBase.Database.reportedRequests)
            {

                LBSelectedContent.Items.Add(item);
            }
            refresh();
        }

        // Admin select all Chats <Raphael>
        private void chatBTN_Click(object sender, EventArgs e)
        {
            //SELECT * FROM CHAT
            nameOfMessage = "BERICHT";
            currentContent = "CHAT";
            LBSelectedContent.Items.Clear();
            DataBase.Database.chats.Clear();
            DataBase.Database.getChat(1, 2);
            foreach (string item in DataBase.Database.chats)
            {
                LBSelectedContent.Items.Add(item);
            }


            refresh();
        }

        // Admin select all Requests <Raphael>
        private void helprequestsReviewBTN_Click(object sender, EventArgs e)
        {
            //SELECT * REQUEST
            nameOfMessage = "OMSCHRIJVING";
            currentContent = "REQUEST";
            LBSelectedContent.Items.Clear();
            DataBase.Database.reviewsRequests.Clear();
            DataBase.Database.getRequests();
            foreach (string item in DataBase.Database.reviewsRequests)
            {
                LBSelectedContent.Items.Add(item);
            }

            refresh();
        }


        // Admin remove selected (UPDATE 'Y' or 'N' IsVisible) <Raphael>
        private void removeBTN_Click(object sender, EventArgs e)
        {
            if (LBSelectedContent.Items == null)
            {
                MessageBox.Show("Nothing Selected!");
            }
            else
            {
                DataBase.Database.getSelected(currentContent, Convert.ToString(LBSelectedContent.SelectedItem), currentContent + "ID", nameOfMessage);
                DataBase.Database.alterYorN(currentContent, Convert.ToInt32(DataBase.Database.ItemIDSelected), currentContent + "ID", "ISVISIBLE", "N");
                //m_command.CommandText = "UPDATE " + COLUMN + " SET " + visibleOrReported + " = 'Y' WHERE CHATID = '1'";
            }
            refresh();
        }

        //Ignore Selected (reported becomes 'N', false) works for all types <Raphael>
        private void ignoreBTN_Click(object sender, EventArgs e)
        {
            // ALTER 'CONTENT' BOOL REPORTED = FALSE 
            if (LBSelectedContent.Items == null)
            {
                MessageBox.Show("Nothing Selected!");
            }
            else
            {
                // SELECT CHATID FROM CHAT WHERE MESSAGE = SELECTEDITEMMESSAGE
                DataBase.Database.getSelected(currentContent, Convert.ToString(LBSelectedContent.SelectedItem), currentContent + "ID", nameOfMessage);
                DataBase.Database.alterYorN(currentContent, Convert.ToInt32(DataBase.Database.ItemIDSelected), currentContent + "ID", "ISREPORTED", "N");
                //m_command.CommandText = "UPDATE " + COLUMN + " SET " + visibleOrReported + " = 'Y' WHERE CHATID = '1'";
            }
            refresh();
        }

        //LogOut <Raphael>
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = (Login)Application.OpenForms["Login"];
            Login.Show();
        }

        //Refresh <Raphael>
        public void refresh()
        {
            LBSelectedContent.Refresh();
        }

        //Get reported Reviews <Raphael>
        private void reportedReviewsBTN_Click(object sender, EventArgs e)
        {
            currentContent = "REVIEW";
            nameOfMessage = "OPMERKINGEN";
            LBSelectedContent.Items.Clear();
            DataBase.Database.reportedReviews.Clear();
            DataBase.Database.getReportedReviews("SELECT OPMERKINGEN FROM REVIEW WHERE ISREPORTED = 'N'");
            foreach (string item in DataBase.Database.reportedReviews)
            {
                LBSelectedContent.Items.Add(item);
            }
            refresh();
        }

        //GetReviews Admin <Raphael>
        private void reviewsBTN_Click(object sender, EventArgs e)
        {
            // SELECT * FROM REVIEWS
            nameOfMessage = "OPMERKINGEN";
            currentContent = "REVIEW";
            LBSelectedContent.Items.Clear();
            DataBase.Database.reviewsListAdmin.Clear();
            DataBase.Database.getReviewAdmin();
            foreach (string item in DataBase.Database.reviewsListAdmin)
            {
                LBSelectedContent.Items.Add(item);
            }

            refresh();

        }

        // Get Reported chats <Raphael>
        private void reportedChatsBTN_Click(object sender, EventArgs e)
        {
            currentContent = "CHAT";
            nameOfMessage = "BERICHT";
            LBSelectedContent.Items.Clear();
            DataBase.Database.reportedChats.Clear();
            DataBase.Database.getreportedChat();
            foreach (string item in DataBase.Database.reportedChats)
            {
                LBSelectedContent.Items.Add(item);
            }

            refresh();
        }

        private void Beheerder_Load(object sender, EventArgs e)
        {

        }
    }
}
       

