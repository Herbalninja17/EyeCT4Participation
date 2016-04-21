using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;

namespace EyeCT4Participation.Business.User
{
    class Volunteer : UI.User 
    {
        public int volunteerID { get; set; }
        public bool car { get; set; }
        public bool license { get; set; }
        public List<Appointment> appointmentList { get; set; }

        public Volunteer(int ID)
        {

            this.volunteerID = ID;
            //this.car = car;
            //this.license = license;
            //this.appointmentList = appointmentList;
            //bool car, bool license, List< Appointment > appointmentList
        }

        public override string ToString()
        {
            return this.volunteerID.ToString();
        }
    }
}
