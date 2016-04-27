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
using EyeCT4Participation.UI;

namespace EyeCT4Participation
{
    public partial class Hulpbehoevende : Form
    {
        //dit is ook een change
        //Business.User.Needy needy = new Business.User.Needy(DataBase.Database.acID);
        public static int userID = DataBase.Database.acID;
        private Information m_Information;
        private PlaceRequest m_PlaceRequest;
        private Chat m_chat;
        private Volunteer m_volunteer;
        private List<Request> requests = new List<Request>();
        private List<Volunteer> volunteer1 = new List<Volunteer>();
        private List<Volunteer> volunteer2 = new List<Volunteer>();
        private List<Volunteer> volunteer3 = new List<Volunteer>();
        public static int User2ID;
        private RequestOverview requestoverview;
        public static Volunteer selectedVolunteer;
        private ReviewOverview reviewoverview;
        private List<string> needyreviews = new List<string>();

        public Hulpbehoevende()
        {
            InitializeComponent();
            Request();
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
            if (m_Information == null || m_Information.IsDisposed)
            {
                m_Information = new Information { Parent = this.Parent };
                m_Information.Show();
                m_Information.fillHulpbehoevende();
            }

            else
            {
                m_Information.BringToFront();
            }
        }

        private void reviewBTN_Click(object sender, EventArgs e)
        {
            needyreviewsmethod();
        }

        private void appointmentBTN_Click(object sender, EventArgs e)
        {
            // Open de afspraken die deze user heeft
        }

        private void requestsBTN_Click(object sender, EventArgs e)
        {
            // Open de verzoeken die deze user heeft ingediend
            Request();
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
                    MessageBox.Show(m_volunteer.name.ToString());        
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
            this.Close();
            Login Login = (Login)Application.OpenForms["Login"];
            Login.Show();
        }

        public void Request()
        {
            contentTB1.Text = "";
            contentTB2.Text = "";
            contentTB3.Text = "";
            volunteer1.Clear();
            volunteer2.Clear();
            volunteer3.Clear();
            requests.Clear();
            LBvol1.Items.Clear();
            LBvol2.Items.Clear();
            LBvol3.Items.Clear();
            requestoverview = new RequestOverview(requests, userID);
            foreach (Request request in requestoverview.GetRequestList())
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

        private void reviewVolunteerBTN_Click(object sender, EventArgs e)
        {
            if (LBvol1.SelectedIndex != -1)
            {
                selectedVolunteer = (Volunteer)LBvol1.SelectedItem;
                new ReviewVolunteer().Show();
            }

            else if (LBvol2.SelectedIndex != -1)
            {
                selectedVolunteer = (Volunteer)LBvol2.SelectedItem;
                new ReviewVolunteer().Show();
            }

            else if (LBvol3.SelectedIndex != -1)
            {
                selectedVolunteer = (Volunteer)LBvol3.SelectedItem;
                new ReviewVolunteer().Show();
            }

            else
            {
                MessageBox.Show("Selecteer een vrijwilliger.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_Information == null || m_Information.IsDisposed)
            {
                if (LBvol1.SelectedIndex != -1)
                {
                    selectedVolunteer = (Volunteer)LBvol1.SelectedItem;
                    m_Information = new Information();
                    m_Information.Show();
                    m_Information.fillVrijwilliger(selectedVolunteer);
                }

                else if (LBvol2.SelectedIndex != -1)
                {
                    selectedVolunteer = (Volunteer)LBvol2.SelectedItem;
                    m_Information = new Information();
                    m_Information.Show();
                    m_Information.fillVrijwilliger(selectedVolunteer);
                }

                else if (LBvol3.SelectedIndex != -1)
                {
                    selectedVolunteer = (Volunteer)LBvol3.SelectedItem;
                    m_Information = new Information();
                    m_Information.Show();
                    m_Information.fillVrijwilliger(selectedVolunteer);
                }

                else
                {
                    MessageBox.Show("Selecteer een vrijwilliger.");
                }
            }

            else
            {
                m_Information.BringToFront();
            }

        }

        private void needyreviewsmethod()
        {
            LBvol1.Items.Clear();
            LBvol2.Items.Clear();
            LBvol3.Items.Clear();
            contentTB1.Text = "";
            contentTB2.Text = "";
            contentTB3.Text = "";
            needyreviews.Clear();
            reviewoverview = new ReviewOverview(needyreviews, userID);
            foreach (string showreview in reviewoverview.GetNeedyReviews())
            {
                needyreviews.Add(showreview);
            }

            needyreviews.Sort();
            int i = needyreviews.Count();

            if (i >= 1)
            {
                contentTB1.Text = Convert.ToString(needyreviews[i - 1]);
            }

            if (i >= 2)
            {
                contentTB2.Text = Convert.ToString(needyreviews[i - 2]);
            }

            if (i >= 3)
            {
                contentTB3.Text = Convert.ToString(needyreviews[i - 3]);
            }
        }
    }
}
