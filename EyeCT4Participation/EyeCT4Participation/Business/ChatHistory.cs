using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.UI;

namespace EyeCT4Participation.Business
{
    class ChatHistory
    {
        //list in database class zetten ipv hier
        List<Chatbox> chatboxen = new List<Chatbox>();

        public void AddChat(Chatbox a)
        {
            chatboxen.Add(a);
        }

        public void GetChatFromList(int needy, int volunteer)
        {
            //linken naar database layer??

        }
    }
}
