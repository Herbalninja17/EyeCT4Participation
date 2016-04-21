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
        public List<Review> m_reviews { get; set; }

        public long m_GebruikerID{ get; set; }


        public ReviewOverview(List<Review> p_reviews, long p_gebruikerID)
        {
            this.m_reviews = p_reviews;
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
