using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    public class Review
    {
        public int m_score { get; set; }

        public string m_review { get; set; }

        public long m_volunteerID { get; set; }

        public long m_NeedyID { get; set; }

        public bool m_reported { get; set; }

        public bool m_visible { get; set; }

        public Review(int p_score, string p_review, long p_volunteerID, long p_needyID)
        {
            this.m_score = p_score;
            this.m_review = p_review;
            this.m_volunteerID = p_volunteerID;
            this.m_NeedyID =p_needyID;

        }
    }
}
