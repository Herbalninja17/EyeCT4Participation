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
        public long userID = DataBase.Database.acID;
        private int Formstate = (int)FormState.nothingSelected;
  
        public Vrijwilliger()
        {
            InitializeComponent();
        }

        private void reviewBTN_Click(object sender, EventArgs e)
        {
            Formstate = 2;
           
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            /////////////////// test code voor chat
            this.Hide();
            new Chat().Show();
        }
    }
}
