﻿using System;
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
    public partial class MyProfile : Form
    {

        public MyProfile()
        {
            InitializeComponent();
            textBox1.Text = DataBase.Database.getUserInformation(Hulpbehoevende.userID);
        }

    }
}