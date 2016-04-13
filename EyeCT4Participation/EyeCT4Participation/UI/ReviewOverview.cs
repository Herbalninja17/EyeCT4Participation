using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;
using EyeCT4Participation.Business.User;

namespace EyeCT4Participation.UI
{
    class ReviewOverview
    {
        public List<Review> reviews { get; set; }

        public int needyID { get; set; }

        public int volunteerID { get; set; }

        public ReviewOverview(List<Review> reviews, int needyID, int volunteerID)
        {
            this.reviews = reviews;
            this.needyID = needyID;
            this.volunteerID = volunteerID;
        }

        public void WriteReview(Review review)
        {

        }

        public void DeleteReview(Review review)
        {

        }

        public void ReadReview(Needy needy)
        {

        }
    }
}
