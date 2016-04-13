using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.UI
{
    class Chatbox
    {
        public int volunteerID { get; set; }

        public int needyID { get; set; }

        public Chatbox(int volunteerID, int needyID)
        {
            this.volunteerID = volunteerID;
            this.needyID = needyID;
        }

        public void GetChat(int gVolunteerID, int gNeedyID)
        {

        }
    }
}
