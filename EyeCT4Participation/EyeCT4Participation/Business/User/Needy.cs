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

        public Needy(int needyID/*, List<Appointment> appointmentList*/)
        {
            this.needyID = needyID;
            //this.appointmentList = appointmentList;
        }

    }
}
