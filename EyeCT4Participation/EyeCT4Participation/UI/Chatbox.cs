using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;

namespace EyeCT4Participation.UI
{
    class Chatbox
    {
        public int volunteerID { get; set; }

        public int needyID { get; set; }

        public List<string> messages { get; set; }

        public Chatbox(int volunteerID, int needyID, List<string> messages)
        {
            this.volunteerID = volunteerID;
            this.needyID = needyID;
            this.messages = messages;
        }

        public void GetChat(int gVolunteerID, int gNeedyID)
        {
            
        }
    }
}
