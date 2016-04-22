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
        private List<Review> m_reviews = new List<Review>();

        public long m_GebruikerID{ get; set; }
        private Review m_review;

        public ReviewOverview( long p_gebruikerID)
        {
          
           this.m_GebruikerID = p_gebruikerID;

        }

        public List<Review> GetMyReviews(UserType TypeUser)
        {
            string Myreviews = DataBase.Database.GetReviews(m_GebruikerID, TypeUser);
            List<string> SplitString = Myreviews.Split('@').ToList();
            switch (TypeUser)
            {
                case UserType.volunteer:
                    foreach (string X in SplitString)
                    { // om string te ontleden
                        if (X != "")
                        {
                            int EndOfstring = X.Length;
                            int IndexScore = X.LastIndexOf("een :") + 5;
                            int IndexOfReview = X.LastIndexOf("opmerkingen gemaakt: ");
                            int IndexOfVolunteerNaam = X.IndexOf("Hulpbehoevende :") + 16;
                            int LenghtNaam = X.IndexOf(".") - IndexOfVolunteerNaam;
                            int score = Convert.ToInt32(X.Substring(IndexScore, 1));
                            string review = X.Substring(IndexOfReview, EndOfstring - IndexOfReview);
                            string Naam = X.Substring(IndexOfVolunteerNaam, LenghtNaam);
                            long NeedyID = DataBase.Database.GetDiffUserID(Naam);
                            long volunteerID = this.m_GebruikerID;
                            m_review = new Review(score, review, volunteerID, NeedyID);
                            if (m_review != null)
                            {
                             
                              m_reviews.Add(m_review);

                                
                            }
                        }
                    }
                    break;
                   
                   
            }
            return m_reviews;
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
