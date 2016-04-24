using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class KMV
    {
        [TestMethod]
        public void KMV_Test()
        {
            //Code
            //De hulpbehoevende klikt op een vrijwilliger die heeft 
            //aangegeven dat hij/zij geïnteresseerd is om te helpen. 
            long hulpid = 3;
            long vrijid = 2;

            Assert.AreEqual(false, Database.getChat(hulpid, vrijid));
        }
    }
}