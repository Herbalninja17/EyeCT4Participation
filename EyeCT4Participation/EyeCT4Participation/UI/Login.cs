using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.UI
{
    class Login
    {
        public string name { get; set; }

        public string password { get; set; }

        public string fingerprint{ get; set; }

        public bool finger { get; set; }

        public Login(string name, string password, string fingerprint, bool finger)
        {
            this.name = name;
            this.password = password;
            this.fingerprint = fingerprint;
            this.finger = finger;
        }

        public void CheckCredentials()
        {

        }

        public void BewaarCredentials()
        {

        }
    }
}
