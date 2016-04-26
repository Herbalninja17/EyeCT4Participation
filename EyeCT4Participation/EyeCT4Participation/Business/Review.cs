using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    public class Review
    {
        public int reviewID { get; set; }
        public int m_score { get; set; }

        public string m_review { get; set; }

        public int m_volunteerID { get; set; }

        public int m_NeedyID { get; set; }

        public bool m_reported { get; set; }

        public bool m_visible { get; set; }

        public int needyIDint { get; set; }

        public List<Reaction> reactions = new List<Reaction>();

        public Review(int reviewid, int p_score, string p_review, int p_volunteerID, int p_needyID)
        {
            this.reviewID = reviewid;
            this.m_score = p_score;
            this.m_review = p_review;
            this.m_volunteerID = p_volunteerID;
            this.m_NeedyID =p_needyID;
            this.needyIDint = Convert.ToInt32(p_needyID);

        }

        public override string ToString()
        {
            //return  "score"+m_score+":" + "Review" +":"+ m_review+Environment.NewLine+reactions;
            //return "Score :" + m_score + "\t" + "Needy name: " + m_NeedyID + "\t" + ", Review: " + m_review;
            return "ID: " + reviewID + "\t" + "Score: " + m_score + "\t" + "Needy name: " + DataBase.Database._needyname + "\t" + ", Review: " + m_review;
        }

      
    }
}
