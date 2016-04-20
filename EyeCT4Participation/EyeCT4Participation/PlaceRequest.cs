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
using Oracle.DataAccess.Client;

namespace EyeCT4Participation
{
    public partial class PlaceRequest : Form
    {
        public PlaceRequest()
        {
            InitializeComponent();
        }

        private void placeRequestBTN_Click(object sender, EventArgs e)
        {
            
            confirmed();
            this.Dispose();
        }

        public void confirmed()
        {
            string omschrijving = Convert.ToString(textBoxDescription.Text);
            string locatie = Convert.ToString(textBoxLocation.Text);
            int reistijd = Convert.ToInt32(textBoxTravelTime.Text);
            string vervoerType = Convert.ToString(textBoxTransportType.Text);
            string startDatum = Convert.ToString(textBoxStartTime.Text);
            string eindDatum = Convert.ToString(textBoxEndTime.Text);
            string urgent = "N";
            if (UrgencyRadioBTN.Checked) { urgent = "Y"; }
            if (UrgencyRadioBTN.Checked == false) { urgent = "N"; }
            int aantalVrijwilligers = Convert.ToInt32(textBoxVolunteersNeeded.Text);
            DataBase.Database.placeARequest(omschrijving, locatie, reistijd, vervoerType, startDatum, eindDatum, urgent, aantalVrijwilligers);

        }
    }
}
