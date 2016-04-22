using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;
using EyeCT4Participation.Business.User;
using EyeCT4Participation.DataBase;

namespace EyeCT4Participation
{
    public class RequestOverview
    {
        public List<Request> requests { get; set; }

        public int needyID { get; set; }

        public RequestOverview(List<Request> requests, int needyID)
        {
            this.needyID = needyID;
            this.requests = requests;
        }

        public RequestOverview(List<Request> requests)
        {
            this.requests = requests;
        }

        public List<Request> GetALLRequestList()
        {
            return Database.GetAllRequests();
        }

        public List<Request> GetRequestList()
        {
            return Database.GetRequests(needyID);
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
