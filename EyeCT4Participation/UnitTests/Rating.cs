using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class Rating
    {
        [TestMethod]
        public void Rating_Test()
        {
            //Code
            //Wanneer de hulpvraag voldaan is, geeft de hulpbehoevende aan 
            //hoe tevreden hij/zij was met de hulp.
            string beoordeling = "2";
            string opmerkingen = "Unit test test";
            int needyid = 3;
            int volunid = 2;
            int count1;
            int count2;

            count1 = Database.COUNTREVIEW();
            Database.ReviewVolunteer(beoordeling, opmerkingen, needyid, volunid);
            count2 = Database.COUNTREVIEW();

            Assert.AreSame(count1 + 1, count2);
        }
    }
}