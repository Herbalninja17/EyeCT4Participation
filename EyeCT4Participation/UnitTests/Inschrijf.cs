using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class Inschrijf
    {
        [TestMethod]
        public void Inschrijf_Test()
        {
            //Code
            //De gebruiker drukt op account aanmaken en vult zijn 
            //gegevens in. Daarna drukt de gebruiker op inschrijven.
            string username = "pietje1234";
            string password = "ZwartePiet";
            string acctype = "Needy";
            string email = "pieter420@hotmail.com";
            string fullname = "Pieter";
            string address = "kikker";
            string city = "Tilburg";
            int phone = 0669420360;
            string gender = "M";
            string rfid = "";
            string car = "";            
            string licence = "";
            string rfid_yn = "";
            Database.RegesterUser(username, password, acctype, email, fullname, address, city, phone, gender, rfid, car, licence);

            Assert.AreEqual(true, Database.Login(username, password));
        }
    }
}
