using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;
using EyeCT4Participation.DataBase;

namespace EyeCT4Participation
{
    public partial class Login : Form
    {
        //RFID werk well!
        RFID rfid;
        public Login()
        {
            InitializeComponent();
        }

        public bool y = false;            

        private void loginBTN_Click(object sender, EventArgs e)
        {
            //if (rfid.Attached == true)
            //{
            //    //-----test conectivity------ //
            //    if (rfid.LED == false) { rfid.LED = true; }
            //    else if (rfid.LED == true) { rfid.LED = false; }

            //}
            string username = usernameTB.Text.ToString();
            string password = passwordTB.Text.ToString();
            DataBase.Database.Login(username, password);
            if (rfidcodetb.Text == Database.acRFID)
            {
                if (DataBase.Database.Login(username, password) == true)
                {
                    if (DataBase.Database.ac == "Needy")
                    {
                        this.Hide();
                        new Hulpbehoevende().Show();
                        //label1.BackColor = Color.Red;
                    }
                    else if (DataBase.Database.ac == "Volunteer")
                    {
                        this.Hide();
                        new Vrijwilliger().Show();
                        //label1.BackColor = Color.Red;
                    }
                    else if (DataBase.Database.ac == "Admin")
                    {
                        this.Hide();
                        new Beheerder().Show();
                        //label1.BackColor = Color.Red;
                    }
                }
            }
            else { MessageBox.Show("Incorrect login credentials or Fingerprint(If necessary)"); }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //if (rfid.Attached == true)
            //{
            //    rfid = new RFID();
            //    openCmdLine(rfid);
            //    rfid.Tag += new TagEventHandler(rfid_Tag);
            //    rfid.Attach += new AttachEventHandler(rfid_Attach);
            //    rfid.TagLost += new TagEventHandler(rfid_TagLost);
            //    rfid.Detach += new DetachEventHandler(rfid_Detach);
            //}
        }

        void rfid_Tag(object sender, TagEventArgs e)
        {
            rfidcodetb.Text = e.Tag;
            y = true;
        }
        void rfid_TagLost(object sender, TagEventArgs e)
        {
            rfidcodetb.Text = "NULL";
            y = false;
        }

        void rfid_Attach(object sender, AttachEventArgs e)
        {
            RFID attached = (RFID)sender;
        }

        void rfid_Detach(object sender, DetachEventArgs e)
        {
            RFID detached = (RFID)sender;
        }

        private void openCmdLine(Phidget p)
        {
            openCmdLine(p, null);
        }
        private void openCmdLine(Phidget p, String pass)
        {
            int serial = -1;
            String logFile = null;
            int port = 5001;
            String host = null;
            bool remote = false, remoteIP = false;
            string[] args = Environment.GetCommandLineArgs();
            String appName = args[0];

            try
            { //Parse the flags
                for (int i = 1; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                        switch (args[i].Remove(0, 1).ToLower())
                        {
                            case "l":
                                logFile = (args[++i]);
                                break;
                            case "n":
                                serial = int.Parse(args[++i]);
                                break;
                            case "r":
                                remote = true;
                                break;
                            case "s":
                                remote = true;
                                host = args[++i];
                                break;
                            case "p":
                                pass = args[++i];
                                break;
                            case "i":
                                remoteIP = true;
                                host = args[++i];
                                if (host.Contains(":"))
                                {
                                    port = int.Parse(host.Split(':')[1]);
                                    host = host.Split(':')[0];
                                }
                                break;
                            default:
                                goto usage;
                        }
                    else
                        goto usage;
                }
                if (logFile != null)
                    Phidget.enableLogging(Phidget.LogLevel.PHIDGET_LOG_INFO, logFile);
                if (remoteIP)
                    p.open(serial, host, port, pass);
                else if (remote)
                    p.open(serial, host, pass);
                else
                    p.open(serial);
                return; //success
            }
            catch { }
            usage:
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Invalid Command line arguments." + Environment.NewLine);
            sb.AppendLine("Usage: " + appName + " [Flags...]");
            sb.AppendLine("Flags:\t-n   serialNumber\tSerial Number, omit for any serial");
            sb.AppendLine("\t-l   logFile\tEnable phidget21 logging to logFile.");
            sb.AppendLine("\t-r\t\tOpen remotely");
            sb.AppendLine("\t-s   serverID\tServer ID, omit for any server");
            sb.AppendLine("\t-i   ipAddress:port\tIp Address and Port. Port is optional, defaults to 5001");
            sb.AppendLine("\t-p   password\tPassword, omit for no password" + Environment.NewLine);
            sb.AppendLine("Examples: ");
            sb.AppendLine(appName + " -n 50098");
            sb.AppendLine(appName + " -r");
            sb.AppendLine(appName + " -s myphidgetserver");
            sb.AppendLine(appName + " -n 45670 -i 127.0.0.1:5001 -p paswrd");
            MessageBox.Show(sb.ToString(), "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Application.Exit();
        }

        bool x = false;

        private void registerBTN_Click(object sender, EventArgs e)
        {
            accounttypeCB.Enabled = false;
            if (accounttypeCB.Text == "Volunteer")
            {
                register();                
                carCKB.Visible = true;
                licenceCKB.Visible = true;                
            }
            else if (accounttypeCB.Text == "Needy" || accounttypeCB.Text == "Admin" )
            {
                register();         
            }
            if (x == true)
            {
                confirm();
                Test();
                MessageBox.Show("Register complete");
                this.Hide();
                new Login().Show();
            }
            x = true;
            if (loginBTN.Enabled == false)
            {
                
            }
        }

        public void register()
        {
            emailTB.Visible = true; 
            fullnameTB.Visible = true;
            addressTB.Visible = true;
            cityTB.Visible = true;
            phoneTB.Visible = true;
            maleCHK.Visible = true;
            femaleCHK.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;            
            registerBTN.Text = "Confirm";
            fingerprintCKB.Visible = true;
            loginBTN.Enabled = false;
        }

        string rfidcode = null;
        string rfid_yn = "X";        

        public void confirm()
        {
            string userrfid = null;
            string username = usernameTB.Text.ToString();
            string password = passwordTB.Text.ToString();
            string acctype = accounttypeCB.Text.ToString();
            string email = emailTB.Text.ToString();
            string fullname = fullnameTB.Text.ToString();
            string address = addressTB.Text.ToString();
            string city = cityTB.Text.ToString();
            string p = phoneTB.Text.ToString();
            int phone = Convert.ToInt32(p);
            string gender = "";            
            if (maleCHK.Checked == true) { gender = "M"; }
            if (femaleCHK.Checked == true) { gender = "V"; }
            if (fingerprintCKB.Checked == true) { rfid_yn = "Y"; }
            if (fingerprintCKB.Checked == false) { rfid_yn = "N"; }
            if (rfid_yn == "Y")            
            {
                userrfid = rfidcodetb.Text;
            }
            string car = "";
            if ( carCKB.Checked == true) { car = "Y"; }
            if ( carCKB.Checked == false) { car = "N"; }
            string licence = "";
            if (licenceCKB.Checked == true) { licence = "Y"; }
            if (licenceCKB.Checked == false) { licence = "N"; }

            DataBase.Database.RegesterUser(username, password, acctype, email, fullname, address, city, phone, gender, userrfid, car, licence);
            
        }

        public void Test()
        {
            registerBTN.BackColor = Color.Red;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (fingerprintCKB.Checked == true) { rfid_yn = "Y"; }
            if (fingerprintCKB.Checked == false) { rfid_yn = "N"; }
            if (rfid_yn == "Y")
            {
                label11.Text = "Place finger on scanner";
                if (y == true)
                {
                    rfidcode = rfidcodetb.Text.ToString();
                    label11.Text = "Press confirm to register";
                }   
                else 
                {
                    label11.Text = "Place finger on scanner";
                }                          
            }
            
        }
    }
}
