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

        private void reportedcontentBTN_Click(object sender, EventArgs e)
        {
            LBSelectedContent.Items.Clear();
            DataBase.Database.reported.Clear();
            // SELECT CHATS, REVIEWS, REQUESTS
            // WHERE REPORTED = TRUE;
            DataBase.Database.getReported("SELECT OPMERKINGEN FROM REVIEW WHERE ISREPORTED = 'N'");
            foreach (string item in DataBase.Database.reported)
            {
                
                LBSelectedContent.Items.Add(item);                
            }
            DataBase.Database.getReported("SELECT BERICHT FROM CHAT WHERE ISREPORTED = 'N'");
            foreach (string item in DataBase.Database.reported)
            {
               
                LBSelectedContent.Items.Add(item);
            }
            DataBase.Database.getReported("SELECT OMSCHRIJVING FROM HULPVRAAG WHERE ISREPORTED = 'N'");
            foreach (string item in DataBase.Database.reported)
            {
                
                LBSelectedContent.Items.Add(item);              
            }
            refresh();
        }

        private void chatBTN_Click(object sender, EventArgs e)
        {
            //SELECT * FROM CHAT
            LBSelectedContent.Items.Clear();
            DataBase.Database.chats.Clear();
            DataBase.Database.getChat(1, 2);
            foreach (string item in DataBase.Database.chats)
            {
               
                LBSelectedContent.Items.Add(item);
            }

            refresh();
        }

        private void helprequestsReviewBTN_Click(object sender, EventArgs e)
        {
            //SELECT * REQUEST, REVIEWS
            LBSelectedContent.Items.Clear();
            DataBase.Database.reviewsRequests.Clear();
            DataBase.Database.getRequestsReviews();
            foreach (string item in DataBase.Database.reviewsRequests)
            {

                LBSelectedContent.Items.Add(item);
            }

            refresh();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
           // ALTER 'CONTENT' BOOL VISIBLE = FALSE
            refresh();
        }

        private void ignoreBTN_Click(object sender, EventArgs e)
        {
           // ALTER 'CONTENT' BOOL REPORTED = FALSE 
            refresh();
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refresh()
        {          
            LBSelectedContent.Refresh();
        }

    }
}
