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
        public List<Chatbox> chatboxen { get; set; }

        public ChatHistory(List<Chatbox> chatboxen)
        {
            this.chatboxen = chatboxen;
        }

        public void AddChat(Chatbox a)
        {
            chatboxen.Add(a);
        }

        public void GetChatFromList(int needy, int volunteer)
        {
            foreach (Chatbox c in chatboxen)
            {
                if (c.needyID == needy && c.volunteerID == volunteer)
                {
                    //methode open chat.
                }
            }
        }
    }
}
