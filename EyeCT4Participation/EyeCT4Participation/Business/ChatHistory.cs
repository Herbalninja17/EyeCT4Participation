using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.UI;
using System.Windows.Forms;

namespace EyeCT4Participation.Business
{
    class ChatHistory
    {
        Chat Chat = (Chat)Application.OpenForms["Chat"];
        //list in database class zetten ipv hier
        List<Chatbox> chatboxen = new List<Chatbox>();
        List<string> messages = new List<string>();
        bool Add = false;


        public void AddChat(Chatbox a)
        {
            chatboxen.Add(a);
        }

        public void GetChatFromList(int needy, int volunteer)
        {
            //linken naar database layer??
            Chatbox chatbox = new Chatbox(needy, volunteer, messages);
            chatboxen.Add(chatbox);
            Chat.ChatMessages(chatbox);
         }

        public void MessageToChat(int needy, int volunteer, string message)
        {
            foreach (Chatbox a in chatboxen)
            {
                if (a.needyID == needy && a.volunteerID == volunteer)
                {
                    a.messages.Add(message);
                    Chat.ChatMessages(a);
                }
            }
        }
    }
}
