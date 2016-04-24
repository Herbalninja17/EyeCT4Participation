using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Unit_test
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginTest()
        {
            //Code
            //De gebruiker vult zijn of haar gebruikersnaam en wachtwoord 
            //in in het login scherm en drukt op Login.
            string username = "Sjef";
            string password = "Sjefke3";

            Assert.AreEqual(true, Database.Login(username, password));
        }

        [TestMethod]
        public void WrongLogin()
        {
            string username = "Sje3f";
            string password = "Sjefkee3";
            Assert.AreEqual(false, Database.Login(username, password));
        }
    }
}
