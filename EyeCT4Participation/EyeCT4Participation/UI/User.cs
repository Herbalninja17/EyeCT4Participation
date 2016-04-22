using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.UI
{
    public abstract class User
    {
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public int phonenumber { get; set; }

        public User(string name, string address, string city, int phonenumber)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.phonenumber = phonenumber;
        }
    }
}
