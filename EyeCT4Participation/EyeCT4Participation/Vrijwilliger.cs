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

    public partial class Vrijwilliger : Form
    {
        public long userID = DataBase.Database.acID;
        enum FormState
        {
            nothingSelected,
            reviews,
            hulpvraag
        }
        public Vrijwilliger()
        {
            InitializeComponent();
        }

        private void reviewBTN_Click(object sender, EventArgs e)
        {
            DataBase.Database.GetReviews(userID);
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            /////////////////// test code voor chat
            this.Hide();
            new Chat().Show();
        }
    }
}
