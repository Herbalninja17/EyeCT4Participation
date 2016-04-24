using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class SendM
    {
        [TestMethod]
        public void SendM_Test()
        {
            //Code
            //Gebruiker stuurt bericht naar een offline gebruiker.
            int needy = 3;
            int volunteer = 2;
            string bericht = "Unit test test";
            int count1;
            int count2;

            count1 = Database.COUNTMESSAGES(needy, volunteer);
            Database.chatsend(needy, volunteer, bericht, needy);
            count2 = Database.COUNTMESSAGES(needy, volunteer);

            Assert.AreEqual(count1 + 1, count2);
        }
    }
}