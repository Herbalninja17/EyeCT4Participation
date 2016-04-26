using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Participation.DataBase;
using EyeCT4Participation.UI;
using EyeCT4Participation.Business;

namespace EyeCT4Participation
{
        public enum FormState
        {
            nothingSelected,
            reviews,
            hulpvraag
        }

    public partial class Vrijwilliger : Form
    {
        private int userID = DataBase.Database.acID;
        public int Formstate = (int)FormState.nothingSelected;
        public ReviewOverview reviewoverview;
        private List<Request> requests = new List<Request>();
        private List<Review> reviews = new List<Review>();
        private RequestOverview requestoverview;
        private Review review;

        public Vrijwilliger()
        {
            InitializeComponent();
            Review();
        }

        private void reviewBTN_Click(object sender, EventArgs e)
        {
            reviews.Clear();
            Formstate = 1;
            //listBox1.ResetText();
            //BtnReactionPost.Visible = true;
            //TxtBxReactionPost.Visible = true;
            listBox1.Items.Clear();
            Review();
            foreach (Review review in reviews)
            {
                listBox1.Items.Add(review);
            }

        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = (Login)Application.OpenForms["Login"];
            Login.Show();
        }

        private void helprequestBTN_Click(object sender, EventArgs e)
        {
            Formstate = 2;
            //BtnReactionPost.Visible = false;
            //TxtBxReactionPost.Visible = false;
            requests.Clear();
            listBox1.Items.Clear();
            requestoverview = new RequestOverview(requests);
            foreach (Request request in requestoverview.GetALLRequestList())
            {
                listBox1.Items.Add(request);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                if (Formstate == 1)
                {
                    review = (Review)listBox1.SelectedItem;
                    MessageBox.Show(review.ToString());
                }
                else if (Formstate == 2)
                {
                    Request a = (Request)listBox1.SelectedItem;
                    MessageBox.Show(a.ToString(), "Request");
                }
            }
        }

        private void replyBTN1_Click(object sender, EventArgs e)
        {
            
        }

        private void instresseBTN_Click(object sender, EventArgs e)
        {
            if (Formstate == 2)
            {
                if (listBox1.SelectedItem != null)
                {
                    Request a = (Request)listBox1.SelectedItem;
                    Database.reactneedy(a.requestID, Convert.ToInt32(userID));
                }
                else
                {
                    MessageBox.Show("Select a request first", "Chat");
                }
            }
    }

        private void openchatBTN_Click(object sender, EventArgs e)
        {
            if (Formstate == 2)
            {
                if (listBox1.SelectedItem != null)
                {
                    Request a = (Request)listBox1.SelectedItem;
                    new Chat(a.needyID, Convert.ToInt32(userID)).Show();
                }
                else
                {
                    MessageBox.Show("Select a request first", "Chat");
                }
            }
        }

        private void BtnReactionPost_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            //Database.PlaceReaction(index, userID, TxtBxReactionPost.Text);
            //Database.PlaceReaction(review.);
        }

        public void Review()
        {
            reviewoverview = new ReviewOverview(reviews, userID);
            foreach (Review rev in reviewoverview.Getreviews())
            {
                reviews.Add(rev);
            }
        }
    }
}
