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
        public List<Review> m_reviews = new List<Review>();

        public int m_GebruikerID { get; set; }

        public List<string> needyreviews = new List<string>();
        private Review m_review;

        public ReviewOverview(List<Review> reviews, int p_gebruikerID)
        {
            this.m_reviews = reviews;
            this.m_GebruikerID = p_gebruikerID;
        }

        public ReviewOverview(List<string> needyreviews, int needyID)
        {
            this.needyreviews = needyreviews;
            this.m_GebruikerID = needyID;
        }

        //public List<Review> LoadMyReviews(UserType TypeUser)
        //{
        //    string Myreviews = DataBase.Database.GetReviews(m_GebruikerID, TypeUser);
        //    List<string> SplitString = Myreviews.Split('@').ToList();
        //    switch (TypeUser)
        //    {
        //        case UserType.volunteer:
        //            foreach (string X in SplitString)
        //            { // om string te ontleden
        //                if (X != "")
        //                {
        //                    int EndOfstring = X.Length;
        //                    int IndexScore = X.LastIndexOf("een :") + 5;
        //                    int IndexOfReview = X.LastIndexOf("opmerkingen gemaakt: ");
        //                    int IndexOfVolunteerNaam = X.IndexOf("Hulpbehoevende :") + 16;
        //                    int LenghtNaam = X.IndexOf(".") - IndexOfVolunteerNaam;
        //                    int score = Convert.ToInt32(X.Substring(IndexScore, 1));
        //                    string review = X.Substring(IndexOfReview, EndOfstring - IndexOfReview);
        //                    string Naam = X.Substring(IndexOfVolunteerNaam, LenghtNaam);
        //                    long NeedyID = DataBase.Database.GetDiffUserID(Naam);
        //                    long volunteerID = this.m_GebruikerID;
        //                    m_review = new Review(score, review, volunteerID, NeedyID);
        //                    if (m_review != null)
        //                    {

        //                      m_reviews.Add(m_review); 


        //                    }
        //                }
        //            }
        //            break;


        //    }
        //    return m_reviews;
        //}

        public List<Review> Getreviews()
        {
            return Database.GetReviews(m_GebruikerID);
        }

        public List<string> GetNeedyReviews()
        {
            return Database.GetNeedyReviews(m_GebruikerID);
        }

        public void ReactToReview(Review review, int UserID, string content)
        {
            Reaction NewReaction = new Reaction(UserID, review, content);
            review.reactions.Add(NewReaction);

        }

        public void DeleteReview(Review review)
        {

        }

        public void ReadReview(Needy needy)
        {

        }
    }
}
