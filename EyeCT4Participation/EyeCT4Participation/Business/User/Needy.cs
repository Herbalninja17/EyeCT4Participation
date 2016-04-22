using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;

namespace EyeCT4Participation.Business.User
{
    public class Needy : UI.User 
    {
        public int needyID { get; set; }
        public List<Appointment> appointmentList { get; set;}

        public Needy(string name, string address, string city, int phonenumber, int needyID/*, List<Appointment> appointmentList*/) :base(name, address, city, phonenumber)
        {
            this.needyID = needyID;
            //this.appointmentList = appointmentList;
        }

    }
}
