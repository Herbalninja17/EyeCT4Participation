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

namespace EyeCT4Participation
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        public void fillHulpbehoevende()
        {
            textBox1.Text = DataBase.Database.getUserInformation(Hulpbehoevende.userID);
        }

        public void fillVrijwilliger(Volunteer a)
        {
            textBox1.Text = a.getUserInfo();
        }

    }
}
