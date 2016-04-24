using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class React
    {
        [TestMethod]
        public void React_Test()
        {
            //Code
            //De gebruiker selecteert een beoordeling waar hij/zij mee 
            //te maken heeft. En plaatst een reactie.
            int reviewID = 1;
            long volunteerID = 2;
            string inhoud = "Unit test like a boss";
            int count1;
            int count2;

            count1 = Database.COUNTREACTION(volunteerID);
            Database.PlaceReaction(reviewID, volunteerID, inhoud);
            count2 = Database.COUNTREACTION(volunteerID);

            Assert.AreEqual(count1 + 1, count2);
        }
    }
}

