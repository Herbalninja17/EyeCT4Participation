using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    class Request
    {
        public int requestID { get; set; }
        public int needyID { get; set; }
        public string description { get; set; }
        public bool urgency { get; set; }
        public string location { get; set; }
        public int travelTime { get; set; }
        public string transportType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int totalVolunteer { get; set; }
        public string reactionList { get; set; }
        public bool reported { get; set; }

        public Request(int ID, int needyID, string description, bool urgency, string location, int traveltime, string transporttype,
            DateTime startdate, DateTime enddate, int totalvolunteers, string reactionlist, bool reported)
        {
            this.requestID = ID;
            this.needyID = needyID;
            this.description = description;
            this.urgency = urgency;
            this.location = location;
            this.travelTime = traveltime;
            this.transportType = transporttype;
            this.startDate = startdate;
            this.endDate = enddate;
            this.totalVolunteer = totalvolunteers;
            this.reactionList = reactionlist;
            this.reported = reported;

                
        }
    }
}
