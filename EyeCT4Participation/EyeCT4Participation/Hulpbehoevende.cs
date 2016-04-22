using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Participation.Business.User;
using EyeCT4Participation.Business;
using EyeCT4Participation.DataBase;

namespace EyeCT4Participation
{
    public partial class Hulpbehoevende : Form
    {
        //dit is ook een change
        //Business.User.Needy needy = new Business.User.Needy(DataBase.Database.acID);
        public int userID = DataBase.Database.acID;
        private PlaceRequest m_PlaceRequest;
        private Chat m_chat;
        private Volunteer m_volunteer;
        private List<Request> requests = new List<Request>();
        private List<Volunteer> volunteer1 = new List<Volunteer>();
        private List<Volunteer> volunteer2 = new List<Volunteer>();
        private List<Volunteer> volunteer3 = new List<Volunteer>();
        public static int User2ID;

        public Hulpbehoevende()
        {
            InitializeComponent();
            foreach (Request request in Database.GetRequests(userID))
            {
                requests.Add(request);
            }

            int i = requests.Count();

            if (i >= 1)
            {
                contentTB1.Text = Convert.ToString(requests[i - 1]);

                foreach (Volunteer volunteer in Database.GetVolunteers(requests[i - 1].requestID))
                {
                    volunteer1.Add(volunteer);
                }

                foreach (Volunteer volunteer in volunteer1)
                {
                    LBvol1.Items.Add(volunteer);
                }
            }

            if (i >= 2)
            {
                contentTB2.Text = Convert.ToString(requests[i - 2]);
                foreach (Volunteer volunteer in Database.GetVolunteers(requests[i - 2].requestID))
                {
                    volunteer2.Add(volunteer);
                }

                foreach (Volunteer volunteer in volunteer2)
                {
                    LBvol2.Items.Add(volunteer);
                }
            }

            if (i >= 3)
            {
                contentTB3.Text = Convert.ToString(requests[i - 3]);

                foreach (Volunteer volunteer in Database.GetVolunteers(requests[i - 3].requestID))
                {
                    volunteer3.Add(volunteer);
                }

                foreach (Volunteer volunteer in volunteer3)
                {
                    LBvol3.Items.Add(volunteer);
                }
            }

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
            if (string.IsNullOrEmpty(contentTB1.Text))
            {
                contentTB1.Text = DataBase.Database.GetReviews(userID,UserType.needy);
            }

            else if (!string.IsNullOrEmpty(contentTB1.Text) && string.IsNullOrEmpty(contentTB2.Text))
            {
                contentTB2.Text = contentTB1.Text;
                contentTB1.Text = DataBase.Database.GetReviews(userID,UserType.needy);
            }
            
            else
            {
                contentTB3.Text = contentTB2.Text;
                contentTB2.Text = contentTB1.Text;
                contentTB1.Text = DataBase.Database.GetReviews(userID,UserType.needy);
            }
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
            if (LBvol1.SelectedItem != null)
            {
                m_volunteer = (Volunteer)LBvol1.SelectedItem;
                // open chat met de geselecteerde vrijwilliger moet nog gebeuren
                if (m_chat == null || m_chat.IsDisposed)
                {
                    m_chat = new Chat(userID, m_volunteer.volunteerID) { Parent = this.Parent };
                    m_chat.Show();
                    MessageBox.Show(m_volunteer.volunteerID.ToString());
                }

                else
                {
                    m_chat.BringToFront();
                }
            }
            else if (LBvol2.SelectedItem != null)
            {
                m_volunteer = (Volunteer)LBvol2.SelectedItem;
                // open chat met de geselecteerde vrijwilliger moet nog gebeuren
                if (m_chat == null || m_chat.IsDisposed)
                {
                    m_chat = new Chat(userID, m_volunteer.volunteerID) { Parent = this.Parent };                    
                    m_chat.Show();
                    MessageBox.Show(m_volunteer.volunteerID.ToString());                    
                }

                else
                {
                    m_chat.BringToFront();
                }
            }
            else if (LBvol3.SelectedItem != null)
            {
                m_volunteer = (Volunteer)LBvol3.SelectedItem;
                // open chat met de geselecteerde vrijwilliger moet nog gebeuren
                if (m_chat == null || m_chat.IsDisposed)
                {
                    m_chat = new Chat(userID, m_volunteer.volunteerID) { Parent = this.Parent };
                    m_chat.Show();
                    MessageBox.Show(m_volunteer.volunteerID.ToString());
                }

                else
                {
                    m_chat.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Choose a volunteer to chat with.", "Chat", MessageBoxButtons.OK);
            }
            
        }


        private void LBvol1_Click(object sender, EventArgs e)
        {
            try
            {
                LBvol2.SetSelected(LBvol2.SelectedIndex, false);
            }
            catch (Exception) {}

            try
            {
                LBvol3.SetSelected(LBvol3.SelectedIndex, false);
            }
            catch (Exception) { }
        }

        private void LBvol2_Click(object sender, EventArgs e)
        {
            try
            {
                LBvol1.SetSelected(LBvol1.SelectedIndex, false);
            }
            catch (Exception) { }

            try
            {
                LBvol3.SetSelected(LBvol3.SelectedIndex, false);
            }
            catch (Exception) { }
        }

        private void LBvol3_Click(object sender, EventArgs e)
        {
            try
            {
                LBvol1.SetSelected(LBvol1.SelectedIndex, false);
            }
            catch (Exception) { }

            try
            {
                LBvol2.SetSelected(LBvol2.SelectedIndex, false);
            }
            catch (Exception) { }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            /////////////////// test code voor chat
            this.Hide();
            new Chat(userID, m_volunteer.volunteerID).Show();
        }
    }
}
