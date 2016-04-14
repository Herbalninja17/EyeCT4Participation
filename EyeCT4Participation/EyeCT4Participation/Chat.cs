using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeCT4Participation.UI;

namespace EyeCT4Participation
{
    public partial class Chat : Form
    {
        int needyid;
        int volunteerid;
        List<string> messages = new List<string>();

        public Chat()
        {
            InitializeComponent();
            Chatbox chat = new Chatbox(volunteerid, needyid, messages);
            chat.GetChat(needyid, volunteerid);
        }

        private void closechatBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
