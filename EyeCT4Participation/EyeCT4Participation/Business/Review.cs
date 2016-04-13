using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeCT4Participation.Business
{
    class Review
    {
        public int score { get; set; }

        public string review { get; set; }

        public int volunteerID { get; set; }

        public bool reported { get; set; }

        public Review(int score, string review, int volunteerID, bool reported)
        {
            this.score = score;
            this.review = review;
            this.volunteerID = volunteerID;
            this.reported = reported;
        }
    }
}
