using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    public class Appointment
    {
        public DateTime date { get; set; }
        public DateTime time { get; set; }
        public int volunteerID { get; set; }
        public int needyID { get; set; }

        public Appointment(DateTime date, DateTime time, int volunteerID, int needyID)
        {
            this.date = date;
            this.time = time;
            this.volunteerID = volunteerID;
            this.needyID = needyID;
        }
    }

}
