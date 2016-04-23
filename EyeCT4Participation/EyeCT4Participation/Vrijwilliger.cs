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
        private long userID = DataBase.Database.acID;
        public int Formstate = (int)FormState.nothingSelected;
        public ReviewOverview reviews;
        private List<Request> requests = new List<Request>();
        private RequestOverview requestoverview;

        public Vrijwilliger()
        {
            InitializeComponent();

           reviews= new ReviewOverview(userID);
        }

        private void reviewBTN_Click(object sender, EventArgs e)
        {
            Formstate = 2;
            listBox1.ResetText();
            BtnReactionPost.Visible = true;
            TxtBxReactionPost.Visible = true;
            foreach (Review review in reviews.LoadMyReviews(UserType.volunteer))
            { 
                    listBox1.Items.Add(Convert.ToString(review));
            }
            
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            /////////////////// test code voor chat
            //this.Hide();
            //new Chat().Show();
        }

        private void helprequestBTN_Click(object sender, EventArgs e)
        {
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
                Request a = (Request)listBox1.SelectedItem;
                MessageBox.Show(a.ToString(), "Request");
            }
        }

        private void replyBTN1_Click(object sender, EventArgs e)
        {
            
        }

        private void instresseBTN_Click(object sender, EventArgs e)
        {
            Request a = (Request)listBox1.SelectedItem;
            Database.reactneedy(a.requestID, Convert.ToInt32(userID));
        }

        private void openchatBTN_Click(object sender, EventArgs e)
        {
            Request a = (Request)listBox1.SelectedItem;
            new Chat( a.needyID, Convert.ToInt32(userID)).Show();
        }
    }
}
