using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;
using EyeCT4Participation.Business.User;
using EyeCT4Participation.DataBase;

namespace EyeCT4Participation.UI
{
   public class ReviewOverview
    {
        public List<Review> m_reviews { get; set; }

        public long m_GebruikerID{ get; set; }


        public ReviewOverview(List<Review> p_reviews, long p_gebruikerID)
        {
          this.m_reviews = p_reviews;
           this.m_GebruikerID = p_gebruikerID;

        }

        public void GetMyReviews(UserType TypeUser)
        {
            //switch (/*UserType*/)
            //{
            //    //default:
            //}
            //string Myreviews = DataBase.Database.GetReviews(m_GebruikerID, TypeUser);
            //List<string> SplitString = Myreviews.Split('@').ToList();
            //foreach (string X in SplitString)
            //{
            //int score= 0;
            //    string review ="";
            //   long volunteerID = this.m_GebruikerID;
            //    long needyID = 1;

            //    Review MyReview = new Review(score, review, volunteerID, needyID);
            //    m_reviews.Add(MyReview);
            //}

        
            
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
