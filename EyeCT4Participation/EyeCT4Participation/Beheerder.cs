﻿using System;
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

        string currentContent;
        private Chat chat;

        //Admin Reported Requests opvragen <Raphael>
        private void reportedcontentBTN_Click(object sender, EventArgs e)
        {
            currentContent = "HULPVRAAG";
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
                DataBase.Database.alterYorN("CHAT", 1, "Y", "IsVisible");
                //m_command.CommandText = "UPDATE " + COLUMN + " SET " + visibleOrReported + " = 'Y' WHERE CHATID = '1'";
            }
            refresh();
        }

        //Ignore Selected (UPDATE  'Y' or 'N') <Raphael>
        private void ignoreBTN_Click(object sender, EventArgs e)
        {
            // ALTER 'CONTENT' BOOL REPORTED = FALSE 
            if (LBSelectedContent.Items == null)
            {
                MessageBox.Show("Nothing Selected!");
            }
            else
            {
                DataBase.Database.alterYorN(currentContent, 24, "Y", "ISREPORTED");
                //m_command.CommandText = "UPDATE " + COLUMN + " SET " + visibleOrReported + " = 'Y' WHERE CHATID = '1'";
            }
            refresh();
        }

        //LogOut <Raphael>
        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
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
            LBSelectedContent.Items.Clear();
            DataBase.Database.reportedChats.Clear();
            DataBase.Database.getreportedChat();
            foreach (string item in DataBase.Database.reportedChats)
            {
                LBSelectedContent.Items.Add(item);
            }

            refresh();
        }
    }
}
       

