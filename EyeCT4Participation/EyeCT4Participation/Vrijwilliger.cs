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
        public Vrijwilliger()
        {
            InitializeComponent();

           reviews= new ReviewOverview(userID);
        }
        private void reviewBTN_Click(object sender, EventArgs e)
        {
            Formstate = 2;
            BtnReactionPost.Visible = true;
            TxtBxReactionPost.Visible = true;
            foreach (Review review in reviews.GetMyReviews(UserType.volunteer))
            { 
                    listBox1.Items.Add(Convert.ToString(review));
            }
            
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            /////////////////// test code voor chat
            this.Hide();
            new Chat().Show();
        }
    }
}
