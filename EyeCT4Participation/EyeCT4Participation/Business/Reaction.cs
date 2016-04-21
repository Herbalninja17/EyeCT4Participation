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
        public long m_ReviewID
        {
            get;
            set;

        }
        public string m_Content
        {
            get;
            set;

        }
        //constructor
        public Reaction(long p_GebruikerID, long p_ReviewID, string p_Content)
        {
            this.m_GebruikerID = p_GebruikerID;
            this.m_ReviewID = p_ReviewID;
            this.m_Content = p_Content;

        }
    }
}
