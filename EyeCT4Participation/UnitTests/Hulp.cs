using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class Hulp
    {
        [TestMethod]
        public void Hulp_Test()
        {
            //Code
            //De hulpbehoevende vult de gegevens van de hulpvraag in en post de vraag.
            int accountID = 1;
            string omschrijving = "Unit test test";
            string locatie = "Bij Olaf thuis";
            int reistijd = 20;
            string vervoersType = "Driewieler";
            string startDatum = "13:00";
            string eindDatum = "13:01";
            string urgent = "Y";
            int aantalVrijwilligers = 5;

            int count1;
            int count2;


            count1 = Database.COUNTHULP();
            Database.placeARequest(accountID, omschrijving, locatie, reistijd, vervoersType, startDatum, eindDatum, urgent, aantalVrijwilligers);
            count2 = Database.COUNTHULP();
            Assert.Equals(count1 + 1, count2);
        }
    }
}
