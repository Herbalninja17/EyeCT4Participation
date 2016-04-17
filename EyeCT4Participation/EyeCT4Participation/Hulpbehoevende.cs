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


        private PlaceRequest m_PlaceRequest;

        public Hulpbehoevende()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            if (m_PlaceRequest == null || m_PlaceRequest.IsDisposed)
            {
                m_PlaceRequest = new PlaceRequest();
                m_PlaceRequest.Parent = this.Parent;
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
        }
    }
}
