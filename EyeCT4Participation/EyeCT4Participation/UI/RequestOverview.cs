using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;
using EyeCT4Participation.Business.User;

namespace EyeCT4Participation
{
    public class RequestOverview
    {
        public List<Request> requests { get; set; }

        public int needyID { get; set; }

        public int volunteerID { get; set; }

        public RequestOverview(List<Request> requests, int needyID, int volunteerID)
        {
            this.requests = requests;
            this.needyID = needyID;
            this.volunteerID = volunteerID;
        }

        public void GetRequestList()
        {
            
        }

        public void PostRequest(Request request)
        {

        }

        public void DeleteRequest(Request request)
        {

        }

        public void React(Needy needy, Request request)
        {

        }
    }
}
