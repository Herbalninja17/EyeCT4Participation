using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    public class Reaction
    {
        //fields 
        public long m_GebruikerID
        {
            get;
            set;
        }
        public Review m_MEINREVIEW;
        public string m_Content
        {
            get;
            set;

        }
        //constructor
        public Reaction(long p_GebruikerID, Review p_Review, string p_Content)
        {
            this.m_GebruikerID = p_GebruikerID;
            this.m_MEINREVIEW = p_Review;
            this.m_Content = p_Content;

        }
        public override string ToString()
        {
            return "gebruikerID" + m_GebruikerID + "content" + m_Content;
        }
    }
}
