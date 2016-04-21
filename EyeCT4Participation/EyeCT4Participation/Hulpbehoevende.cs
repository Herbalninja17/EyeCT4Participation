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
    public partial class Hulpbehoevende : Form
    {
        //Business.User.Needy needy = new Business.User.Needy(DataBase.Database.acID);
        public int userID = DataBase.Database.acID;
        private PlaceRequest m_PlaceRequest;
        private Chat m_chat;

        public Hulpbehoevende()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (m_PlaceRequest == null || m_PlaceRequest.IsDisposed)
            {
                m_PlaceRequest = new PlaceRequest {Parent = this.Parent};
                m_PlaceRequest.Show();
            }

            else
            {
                m_PlaceRequest.BringToFront();
            }
        }

        private void profileBTN_Click(object sender, EventArgs e)
        {
            // open het profiel van deze user
            //DataBase.Database.GetUser();
            contentTB1.Text = DataBase.Database.GetUser();

        }

        private void reviewBTN_Click(object sender, EventArgs e)
        {
            // Open de lijst met reviews die bij deze user hoort
            contentTB1.Text = DataBase.Database.GetReviews(userID);
        }

        private void appointmentBTN_Click(object sender, EventArgs e)
        {
            // Open de afspraken die deze user heeft
        }

        private void requestsBTN_Click(object sender, EventArgs e)
        {
            // Open de verzoeken die deze user heeft ingediend

        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            // verwijder de geselecteerde content
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            // bewerk de geselecteerde content
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // geef de geselecteerde vrijwilliger aan (report)
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // open chat met de geselecteerde vrijwilliger
            if (m_chat == null || m_chat.IsDisposed)
            {
                m_chat = new Chat {Parent = this.Parent};
                m_chat.Show();
            }

            else
            {
                m_chat.BringToFront();
            }
        }
    }
}
