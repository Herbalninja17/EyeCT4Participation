using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EyeCT4Participation.DataBase;
using Oracle.DataAccess.Client;

//Voeg "using 'Naam Project'" en de reference naar het project toe.
namespace Login_test
{
    [TestClass]
    public class Report
    {
        private string COLUMN1 = "HULPVRAAG";
        private string COLUMN2 = "REACTION";
        private string COLUMN3 = "REVIEW";
        private int ID = 1;
        private string Y = "Y";
        private string N = "N";
        private string visibleOrReported = "ISREPORTED";


        [TestMethod]
        public void ReportRequest_Test()
        {
            //Code
            //De gebruiker rapporteert een hulpvraag.
            Assert.AreEqual(false, Database.alterYorN(COLUMN1, ID, Y, "HULPVRAAGID", visibleOrReported));

            //Hulpvraag wordt weer ongerapporteerd zodat de test vaker kan worden uitgevoerd.
            Assert.AreEqual(false, Database.alterYorN(COLUMN1, ID, N, "HULPVRAAGID", visibleOrReported));
        }

        [TestMethod]
        public void ReportReaction_Test()
        {
            //Code
            //De gebruiker rapporteert een opmerking.
            Assert.AreEqual(false, Database.alterYorN(COLUMN2, ID, Y, "REACTIONID", visibleOrReported));

            //Opmerking wordt weer ongerapporteert zodat de test vaker kan worden uitgevoerd.
            Assert.AreEqual(false, Database.alterYorN(COLUMN2, ID, N, "REACTIONID", visibleOrReported));
        }

        [TestMethod]
        public void ReportReview_Test()
        {
            //Code
            //De gebruiker rapporteert een review.
            Assert.AreEqual(false, Database.alterYorN(COLUMN3, ID, Y, "REVIEWID", visibleOrReported));

            //Review wordt weer ongerapporteert zodat de test vaker kan worden uitgevoerd.
            Assert.AreEqual(false, Database.alterYorN(COLUMN3, ID, N, "REVIEWID", visibleOrReported));
        }
    }
}