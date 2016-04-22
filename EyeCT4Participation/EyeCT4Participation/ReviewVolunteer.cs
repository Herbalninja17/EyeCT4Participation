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
    public partial class ReviewVolunteer : Form
    {
        public ReviewVolunteer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            confirmed();
            this.Dispose();
        }

        private void confirmed()
        {
            string beoordeling = Convert.ToString(trackBarReview.Value);
            string opmerkingen = Convert.ToString(textBoxOpmerkingen.Text);
            DataBase.Database.ReviewVolunteer(beoordeling, opmerkingen, DataBase.Database.acID, Hulpbehoevende.selectedVolunteer.volunteerID);
        }
    }
}
