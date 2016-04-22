using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business.User
{
    public class Admin : UI.User 
    {
        public int adminID { get; set; }

        public Admin (string name, string address, string city, int phonenumber, int ID) :base(name, address, city, phonenumber)
        {
            this.adminID = ID;
        }
    }
    
    
}

