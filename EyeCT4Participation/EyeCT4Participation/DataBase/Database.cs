using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Oracle.DataAccess.Client;
using EyeCT4Participation.Business;
using EyeCT4Participation.Business.User;
//using Oracle.DataAccess.Types;


namespace EyeCT4Participation.DataBase
{
    public enum UserType { needy, volunteer };
    public static class Database
    {

        static readonly string m_databaseFilename = "Database.sql";
        static OracleConnection m_conn;
        static OracleCommand m_command;
        static string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));User ID=dbi338530;PASSWORD=Hoi;";


        // Open de verbinding met de database
        public static bool OpenConnection()
        {
            bool returnvalue = false;
            m_conn = new OracleConnection();
            try
            {
                m_conn.ConnectionString = connectionString;
                m_conn.Open();
                // Controleer of de verbinding niet al open is
                if (m_conn.State != System.Data.ConnectionState.Open)
                { return true; }
            }
            catch (Exception ex) { Console.WriteLine("Connection failed: " + ex.Message); }
            return returnvalue;
        }

        public static void CloseConnection()
        {
            try
            { m_conn.Close(); }
            catch (Exception ex)
            { Console.WriteLine("Connection failed: " + ex.Message); }
        }

        public static string Query
        {
            set
            {
                OpenConnection();
                try
                {
                    m_command = new OracleCommand(value, m_conn);
                    m_conn.Open();
                }
                catch (Exception ex) { Console.WriteLine("Connection failed: " + ex.Message); }
            }
        }

        /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
        public static OracleCommand Command { get { return m_command; } }

        /// Haal de bestandsnaam op van de database.
        public static string DatabaseFilename { get { return m_databaseFilename; } }

        ///insert query example/////////////////////////////////////////////////////////////////////////////////
        public static void TestMethode(string data) // zet all uw data in als parameter in volgorde <Rechard>
        {
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                //                                   kolom   table             data    //de : link met de parameter
                m_command.CommandText = "INSERT INTO testt (testdata) VALUES (:test2)";
                //                      :linken                datatype          value
                m_command.Parameters.Add("test2", OracleDbType.Varchar2).Value = data;
                m_command.ExecuteNonQuery();        //execute het query
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        } //goodluck! </Rechard>        
          /// /////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string GetUser(int accountid) // Gebruik deze om jullie command en results te testen jongens
        {
            string _test = "no";
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT Gebruikerid from Gebruiker WHERE Gebruikerid = :GebruikerID";
                Command.Parameters.Add(":GebruikerID", OracleDbType.Long).Value = accountid;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        _test = Convert.ToString(Convert.ToInt32(_Reader["Gebruikerid"]));
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return _test;
        }

        //Rechard
        public static void RegesterUser(string username, string password, string acctype, string email, string fullname, string address, string city, int phone, string gender, string rfid, string yncar, string ynlicence)
        {
            int AutoID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(GebruikerID) from Gebruiker";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        AutoID = Convert.ToInt32(_Reader["COUNT(GebruikerID)"]) + 1;
                    }
                }
                m_command.CommandText = "INSERT INTO Gebruiker (GebruikerID, Gebruikersnaam, Wachtwoord, Naam, Geslacht, Adres, Woonplaats, Telefoonnummer, HeeftRijbewijs, HeeftAuto, Email, Gebruikerstype, Rfidcode) VALUES (:GebruikerID, :Gebruikersnaam, :Wachtwoord, :Naam, :Geslacht, :Adres, :Woonplaats, :Telefoonnummer, :rij, :auto, :Email, :Gebruikerstype, :rfid)";
                m_command.Parameters.Add("GebruikerID", OracleDbType.Int32).Value = AutoID;
                m_command.Parameters.Add("Gebruikersnaam", OracleDbType.Varchar2).Value = username;
                m_command.Parameters.Add("Wachtwoord", OracleDbType.Varchar2).Value = password;
                m_command.Parameters.Add("Naam", OracleDbType.Varchar2).Value = fullname;
                m_command.Parameters.Add("Geslacht", OracleDbType.Varchar2).Value = gender;
                m_command.Parameters.Add("Adres", OracleDbType.Varchar2).Value = address;
                m_command.Parameters.Add("Woonplaats", OracleDbType.Varchar2).Value = city;
                m_command.Parameters.Add("Telefoonnummer", OracleDbType.Int32).Value = phone;
                m_command.Parameters.Add("rij", OracleDbType.Varchar2).Value = ynlicence;
                m_command.Parameters.Add("auto", OracleDbType.Varchar2).Value = yncar;
                m_command.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                m_command.Parameters.Add("Gebruikerstype", OracleDbType.Varchar2).Value = acctype;
                m_command.Parameters.Add("rfid", OracleDbType.Varchar2).Value = rfid;

                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        } //goodluck! </Rechard>  


        public static string ac;
        public static int acID;
        public static string acRFID;

        //Rechard
        public static bool Login(string username, string password)
        {
            string result = "no";
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT GebruikerID, Gebruikersnaam, Wachtwoord, Gebruikerstype, Rfidcode FROM gebruiker WHERE Wachtwoord = :password AND Gebruikersnaam = :username";
                m_command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                m_command.Parameters.Add("username", OracleDbType.Varchar2).Value = username;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        ac = acctype;
                        int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        acID = accID;
                        result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        if (result == username) { ok = true; }
                        string rfid = Convert.ToString(_Reader["Rfidcode"]);
                        acRFID = rfid;
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }




        // REVIEWID - OPMERKINGEN, CHATID - BERICHT, HULPVRAAGID - OMSCHRIJVING
        // Get ID from selected chat/review/request to change visibility/reported
        public static string ItemIDSelected;
        public static bool getSelected(string column, string message, string IDFromWich, string nameOfMessage)
        {
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT " + IDFromWich + " FROM " + column + " WHERE " + nameOfMessage + " = :GEKOZENBERICHT";
                //Command.Parameters.Add("COLUMN", OracleDbType.Varchar2).Value = column;
                Command.Parameters.Add("GEKOZENBERICHT", OracleDbType.Varchar2).Value = message;
                //Command.Parameters.Add("ITEMID", OracleDbType.Varchar2).Value = IDFromWich;
                //Command.Parameters.Add("BERICHT", OracleDbType.Varchar2).Value = nameOfMessage;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {

                        ItemIDSelected = (Convert.ToString(_Reader["" + IDFromWich + ""]));

                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;

        }


        // Update table IsVisible/IsReported <Raphael>
        public static bool alterYorN(string COLUMN, int ID, string IDFromWich, string visibleOrReported, string YorN)
        {
            bool ok = false;

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "UPDATE " + COLUMN + " SET " + visibleOrReported + " = '" + YorN + "' WHERE " + IDFromWich + "=" + ID;
                //Command.Parameters.Add("Y", OracleDbType.Varchar2).Value = YorN;
                //Command.Parameters.Add("IDFromWich", OracleDbType.Varchar2).Value = IDFromWich;
                //Command.Parameters.Add("1", OracleDbType.Int32).Value = Convert.ToString(ID);
                //Command.Parameters.Add("COLUMN", OracleDbType.Varchar2).Value = COLUMN;
                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }




        // GetReviews admin <Raphael>
        public static List<string> reviewsListAdmin = new List<string>();
        public static bool getReviewAdmin()
        {
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT * FROM REVIEW";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        //string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        //ac = acctype;
                        //int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        //acID = accID;
                        //result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        //if (result == username) { ok = true; }
                        reviewsListAdmin.Add(Convert.ToString(_Reader["OPMERKINGEN"]));

                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;

        }

        // GetChat admin <Raphael>
        public static List<string> chats = new List<string>();
        public static bool getChat(long UserID1, long UserID2)
        {
            bool ok = false;

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT * FROM CHAT";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        //string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        //ac = acctype;
                        //int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        //acID = accID;
                        //result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        //if (result == username) { ok = true; }
                        chats.Add(Convert.ToString(_Reader["BERICHT"]));

                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

        // GetReported reviews admin <Raphael>
        public static List<string> reportedReviews = new List<string>();
        public static bool getReportedReviews(string query)
        {
            bool ok = false;

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = query;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        ////string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        ////ac = acctype;
                        ////int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        ////acID = accID;
                        ////result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        ////if (result == username) { ok = true; }
                        //if (query == "SELECT OPMERKINGEN FROM REVIEW WHERE ISREPORTED = 'N'")
                        //{
                        //reported.Add(Convert.ToString(_Reader["OPMERKINGEN"]));
                        //}
                        //if (query == "SELECT BERICHT FROM CHAT WHERE ISREPORTED = 'N'")
                        //{
                        //reported.Add(Convert.ToString(_Reader["BERICHT"]));
                        //}
                        //if (query == "SELECT OMSCHRIJVING FROM HULPVRAAG WHERE ISREPORTED = 'N'")
                        //{
                        reportedReviews.Add(Convert.ToString(_Reader["OPMERKINGEN"]));
                        //}
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

        // GetreportedChat admin <Raphael>
        public static List<string> reportedChats = new List<string>();
        public static bool getreportedChat()
        {
            bool ok = false;

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT BERICHT FROM CHAT WHERE ISREPORTED = 'Y'";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        //string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        //ac = acctype;
                        //int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        //acID = accID;
                        //result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        //if (result == username) { ok = true; }
                        reportedChats.Add(Convert.ToString(_Reader["BERICHT"]));

                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

        // GetReported requests admin <Raphael>
        public static List<string> reportedRequests = new List<string>();
        public static bool getReportedRequests(string query)
        {
            bool ok = false;

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = query;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        ////string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        ////ac = acctype;
                        ////int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        ////acID = accID;
                        ////result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        ////if (result == username) { ok = true; }
                        //if (query == "SELECT OPMERKINGEN FROM REVIEW WHERE ISREPORTED = 'N'")
                        //{
                        //reported.Add(Convert.ToString(_Reader["OPMERKINGEN"]));
                        //}
                        //if (query == "SELECT BERICHT FROM CHAT WHERE ISREPORTED = 'N'")
                        //{
                        //reported.Add(Convert.ToString(_Reader["BERICHT"]));
                        //}
                        //if (query == "SELECT OMSCHRIJVING FROM HULPVRAAG WHERE ISREPORTED = 'N'")
                        //{
                        reportedRequests.Add(Convert.ToString(_Reader["OMSCHRIJVING"]));
                        //}
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return ok;
        }

        // GetRequests admin <Raphael>
        public static List<string> reviewsRequests = new List<string>();
        public static bool getRequests()
        {
            bool ok = false;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT * FROM HULPVRAAG";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        //string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        //ac = acctype;
                        //int accID = Convert.ToInt32(_Reader["GebruikerID"]);
                        //acID = accID;
                        //result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        //if (result == username) { ok = true; }
                        reviewsRequests.Add(Convert.ToString(_Reader["OMSCHRIJVING"]));

                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }


            //    try
            //    {
            //        OpenConnection();
            //        m_command = new OracleCommand();
            //        m_command.Connection = m_conn;
            //        m_command.CommandText = "SELECT * FROM REVIEW";
            //        m_command.ExecuteNonQuery();
            //        using (OracleDataReader _Reader = Database.Command.ExecuteReader())
            //        {
            //            while (_Reader.Read())
            //            {
            //                //string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
            //                //ac = acctype;
            //                //int accID = Convert.ToInt32(_Reader["GebruikerID"]);
            //                //acID = accID;
            //                //result = Convert.ToString(_Reader["Gebruikersnaam"]);
            //                //if (result == username) { ok = true; }
            //                reviewsRequests.Add(Convert.ToString(_Reader["OPMERKINGEN"]));

            //            }
            //        }
            //    }
            //    catch (OracleException ex)
            //    {
            //        Database.CloseConnection();
            //        Console.WriteLine(ex.Message);
            //    }
            return ok;

        }

        // HULPVRAAG UITZETTEN <THOM>
        public static void placeARequest(int accountid, string omschrijving, string locatie, int reistijd,
            string vervoerType, string startDatum, string eindDatum, string urgent, int aantalVrijwilligers)
        {
            int my_UserID = 0;
            int this_hulpvraagID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(HulpvraagID) from Hulpvraag";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        this_hulpvraagID = Convert.ToInt32(_Reader["COUNT(HulpvraagID)"]) + 1;
                    }
                }

                m_command.CommandText =
                    "INSERT INTO Hulpvraag(HulpvraagID, Omschrijving, Locatie, Reistijd, VervoerType, Startdatum, Einddatum, Urgent, AantalVrijwilligers, GebruikerID) VALUES(:HulpvraagID, :Omschrijving, :Locatie, :Reistijd, :Vervoertype, :Startdatum, :Einddatum, :Urgent, :AantalVrijwilligers, :GebruikerID)";

                Command.Parameters.Add("HulpvraagID", OracleDbType.Int32).Value = this_hulpvraagID;
                Command.Parameters.Add("Omschrijving", OracleDbType.Varchar2).Value = omschrijving;
                Command.Parameters.Add("Locatie", OracleDbType.Varchar2).Value = locatie;
                Command.Parameters.Add("Reistijd", OracleDbType.Int32).Value = reistijd;
                Command.Parameters.Add("Vervoertype", OracleDbType.Varchar2).Value = vervoerType;
                Command.Parameters.Add("Startdatum", OracleDbType.Varchar2).Value = startDatum;
                Command.Parameters.Add("Einddatum", OracleDbType.Varchar2).Value = eindDatum;
                Command.Parameters.Add("Urgent", OracleDbType.Char).Value = urgent;
                Command.Parameters.Add("AantalVrijwilligers", OracleDbType.Int32).Value = aantalVrijwilligers;
                Command.Parameters.Add("GebruikerID", OracleDbType.Int32).Value = accountid;

                Command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        // REVIEWS UIT DATABASE HALEN <THOM>
        public static string _needyname = "";
        public static List<string> GetNeedyReviews(int accountid)
        {
            List<string> needyreviews = new List<string>();
            string reviews = "";
            string needyName = "";
            string needyRate = "";
            string needyRemark = "";
            string volunteerName = "";
            string id = "";

            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT R.ReviewID, G.Naam AS Needy, Beoordeling, Opmerkingen, G2.Naam AS Volunteer FROM Gebruiker G JOIN Review R ON G.GebruikerID = R.NeedyID JOIN Gebruiker G2 ON G2.GebruikerID = R.VolunteerID WHERE G.GebruikerID = :GebruikerID";
                Command.Parameters.Add(":GebruikerID", OracleDbType.Long).Value = accountid;
                m_command.ExecuteNonQuery();
                //case UserType.volunteer:
                //    m_command.CommandText = "SELECT G.Naam AS Needy, Beoordeling, Opmerkingen, G2.Naam AS Volunteer FROM Gebruiker G JOIN Review R ON G.GebruikerID = R.NeedyID JOIN Gebruiker G2 ON G2.GebruikerID = R.VolunteerID WHERE G2.GebruikerID = :GebruikerID";
                //    Command.Parameters.Add(":GebruikerID", OracleDbType.Long).Value = accountid;
                //    m_command.ExecuteNonQuery();
                //    break;
                // Weet niet of het nodig is.
                // case UserType.admin:

                //    break;

                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        id = _Reader["ReviewID"].ToString();
                        needyName = Convert.ToString((_Reader["Needy"]));
                        _needyname = needyName;
                        needyRate = Convert.ToString((_Reader["Beoordeling"]));
                        needyRemark = Convert.ToString((_Reader["Opmerkingen"]));
                        volunteerName = Convert.ToString((_Reader["Volunteer"]));
                        //@Voor makkelijke split
                        reviews = Convert.ToString("ID: " + id + Environment.NewLine + "Hulpbehoevende " + needyName + "." + "beoordeelt vrijwilliger " + volunteerName + " met een :" + needyRate + " en heeft de volgende opmerkingen gemaakt:" + " " + needyRemark);
                        needyreviews.Add(reviews);
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return needyreviews;
        }

        public static List<Review> GetReviews(int ID)
        {
            List<Review> reviews = new List<Review>();

            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT R.REVIEWID, R.BEOORDELING, R.OPMERKINGEN, R.NEEDYID, R.VOLUNTEERID, G.GEBRUIKERSNAAM FROM REVIEW R, GEBRUIKER G WHERE VOLUNTEERID = :ID AND R.NEEDYID = G.GEBRUIKERID ORDER BY REVIEWID";
                m_command.Parameters.Add("ID", OracleDbType.Int32).Value = ID;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    if (_Reader.HasRows)
                    {
                        while (_Reader.Read())
                        {
                            Review review = new Review(Convert.ToInt32(_Reader["REVIEWID"]), Convert.ToInt32(_Reader["BEOORDELING"]), _Reader["OPMERKINGEN"].ToString(), Convert.ToInt32(_Reader["VOLUNTEERID"]), Convert.ToInt32(_Reader["NEEDYID"]), _Reader["GEBRUIKERSNAAM"].ToString());
                            reviews.Add(review);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return reviews;
        }

        // REQUEST UIT DATABASE <OLAF>
        public static List<Request> GetRequests(int ID)
        {
            List<Request> requests = new List<Request>();

            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT * FROM HULPVRAAG WHERE GEBRUIKERID = :ID ORDER BY HULPVRAAGID";
                m_command.Parameters.Add("ID", OracleDbType.Int32).Value = ID;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    if (_Reader.HasRows)
                    {
                        while (_Reader.Read())
                        {
                            CultureInfo provider = CultureInfo.InvariantCulture;
                            string start = Convert.ToString(_Reader["STARTDATUM"]);
                            string end = Convert.ToString(_Reader["EINDDATUM"]);
                            DateTime startdate = DateTime.ParseExact(start, "HH:mm", provider);
                            DateTime enddate = DateTime.ParseExact(end, "HH:mm", provider);
                            Request request = new Request(Convert.ToInt32(_Reader["HULPVRAAGID"]), Convert.ToInt32(_Reader["GEBRUIKERID"]), _Reader["OMSCHRIJVING"].ToString(), _Reader["LOCATIE"].ToString(), Convert.ToInt32(_Reader["REISTIJD"]), _Reader["VERVOERTYPE"].ToString(), startdate, enddate, Convert.ToInt32(_Reader["AANTALVRIJWILLIGERS"]));
                            requests.Add(request);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return requests;
        }

        public static List<Request> GetAllRequests()
        {
            List<Request> requests = new List<Request>();

            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT * FROM HULPVRAAG";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    if (_Reader.HasRows)
                    {
                        while (_Reader.Read())
                        {
                            CultureInfo provider = CultureInfo.InvariantCulture;
                            string start = Convert.ToString(_Reader["STARTDATUM"]);
                            string end = Convert.ToString(_Reader["EINDDATUM"]);
                            DateTime startdate = DateTime.ParseExact(start, "HH:mm", provider);
                            DateTime enddate = DateTime.ParseExact(end, "HH:mm", provider);
                            Request request = new Request(Convert.ToInt32(_Reader["HULPVRAAGID"]), Convert.ToInt32(_Reader["GEBRUIKERID"]), _Reader["OMSCHRIJVING"].ToString(), _Reader["LOCATIE"].ToString(), Convert.ToInt32(_Reader["REISTIJD"]), _Reader["VERVOERTYPE"].ToString(), startdate, enddate, Convert.ToInt32(_Reader["AANTALVRIJWILLIGERS"]));
                            requests.Add(request);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return requests;
        }

        //dit is een change
        public static List<Volunteer> GetVolunteers(int HulpvraagID)
        {
            List<Volunteer> volunteers = new List<Volunteer>();

            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT G.GEBRUIKERSNAAM, G.ADRES, G.WOONPLAATS, G.TELEFOONNUMMER , G.GEBRUIKERID FROM GEBRUIKER G, INTRESSE I, HULPVRAAG H WHERE H.HULPVRAAGID = :HULPVRAAGID AND H.HULPVRAAGID = I.HULPVRAAGID AND I.GEBRUIKERID = G.GEBRUIKERID";
                m_command.Parameters.Add("HULPVRAAGID", OracleDbType.Int32).Value = HulpvraagID;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    if (_Reader.HasRows)
                    {
                        while (_Reader.Read())
                        {
                            Volunteer volunteer = new Volunteer(_Reader["GEBRUIKERSNAAM"].ToString(), _Reader["ADRES"].ToString(), _Reader["WOONPLAATS"].ToString(), Convert.ToInt32(_Reader["TELEFOONNUMMER"]), Convert.ToInt32(_Reader["GEBRUIKERID"]));
                            volunteers.Add(volunteer);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return volunteers;
        }

        public static List<string> chathistory = new List<string>();
        // CHATHALEN <RECHARD>

        
        public static string chatbox(int needy, int volunteer)
        {
            chathistory.Clear();
            string bericht = "";
            string hetzender = "";
            string chatstring = "";
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT c.Bericht, c.Zender, g.Gebruikersnaam from Chat c LEFT JOIN Gebruiker g ON c.Zender = g.GebruikerID WHERE c.GebruikerID = :needy AND c.GebruikerID2 = :volunteer ORDER BY ChatID ";
                m_command.Parameters.Add("needy", OracleDbType.Varchar2).Value = needy;
                m_command.Parameters.Add("volunteer", OracleDbType.Varchar2).Value = volunteer;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        hetzender = Convert.ToString(_Reader["Gebruikersnaam"]);
                        bericht = Convert.ToString(_Reader["Bericht"]);
                        chatstring = hetzender + ": " + bericht;
                        chathistory.Add(chatstring);
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return bericht;

        }

        // CHAT INSERTS <RECHARD>
        public static void chatsend(int needy, int volunteer, string bericht, int zender)
        {
            int AutoID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(ChatID) from Chat";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        AutoID = Convert.ToInt32(_Reader["COUNT(ChatID)"]) + 1;
                    }
                }
                m_command.CommandText = "INSERT INTO Chat (ChatID, Zender, GebruikerID, GebruikerID2, Bericht) VALUES (:ChatID, :Zender, :GebruikerID, :GebruikerID2, :Bericht)";
                m_command.Parameters.Add("ChatID", OracleDbType.Int32).Value = AutoID;
                m_command.Parameters.Add("Zender", OracleDbType.Int32).Value = zender;
                m_command.Parameters.Add("GebruikerID", OracleDbType.Int32).Value = needy;
                m_command.Parameters.Add("GebruikerID2", OracleDbType.Int32).Value = volunteer;
                m_command.Parameters.Add("Bericht", OracleDbType.Varchar2).Value = bericht;
                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        }

        public static long UserID2;
        public static long GetDiffUserID(string UserName)
        {
            long UserID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT GebruikerID From Gebruiker Where naam = :naam";
                m_command.Parameters.Add(":naam", OracleDbType.Varchar2).Value = UserName;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        UserID = Convert.ToInt64(_Reader["GebruikerID"]);
                    }
                    return UserID;
                }

            }

            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return UserID;
        }

        public static void ReviewVolunteer(string beoordeling, string opmerkingen, int needyID, int volunteerID)
        {
            int my_UserID = 0;
            int this_reviewID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(ReviewID) FROM Review";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        this_reviewID = Convert.ToInt32(_Reader["COUNT(ReviewID)"]) + 1;
                    }
                }

                m_command.CommandText =
                    "INSERT INTO Review(ReviewID, Beoordeling, Opmerkingen, NeedyID, VolunteerID) VALUES(:ReviewID, :Beoordeling, :Opmerkingen, :NeedyID, :VolunteerID)";

                Command.Parameters.Add("ReviewID", OracleDbType.Int32).Value = this_reviewID;
                Command.Parameters.Add("Beoordeling", OracleDbType.Varchar2).Value = beoordeling;
                Command.Parameters.Add("Opmerkingen", OracleDbType.Varchar2).Value = opmerkingen;
                Command.Parameters.Add("NeedyID", OracleDbType.Int32).Value = needyID;
                Command.Parameters.Add("VolunteerID", OracleDbType.Int32).Value = Convert.ToInt32(Hulpbehoevende.selectedVolunteer.volunteerID);

                Command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }


        public static void reactneedy(int hulpvraagID, int myID)
        {

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "INSERT INTO Intresse (HulpvraagID, GebruikerID) VALUES (:HID, :GID)";
                m_command.Parameters.Add("HID", OracleDbType.Int32).Value = hulpvraagID;
                m_command.Parameters.Add("GID", OracleDbType.Int32).Value = myID;
                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        }

        public static string getUserInformation(long userinformationid)
        {
            string userInformation = "";
            string gebruikersnaam = "";
            string wachtwoord = "";
            string naam = "";
            string geslacht = "";
            string adres = "";
            string woonplaats = "";
            string telefoonnummer = "";
            string email = "";

            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT * From Gebruiker Where GebruikerID = :id";
                m_command.Parameters.Add(":id", OracleDbType.Varchar2).Value = userinformationid;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        gebruikersnaam = Convert.ToString((_Reader["Gebruikersnaam"]));
                        wachtwoord = Convert.ToString((_Reader["Wachtwoord"]));
                        naam = Convert.ToString((_Reader["Naam"]));
                        geslacht = Convert.ToString((_Reader["Geslacht"]));
                        adres = Convert.ToString((_Reader["Adres"]));
                        woonplaats = Convert.ToString((_Reader["Woonplaats"]));
                        telefoonnummer = Convert.ToString((_Reader["telefoonnummer"]));
                        email = Convert.ToString((_Reader["email"]));
                        userInformation = ("Gebruikersnaam: " + gebruikersnaam + "#" + "Wachtwoord: " + wachtwoord + "#" + "Naam: " + naam + "#" + "Geslacht: " + geslacht + "#" + "Adres: " + adres + "#" + "Woonplaats: " + woonplaats + "#" + "Telefoonnummer: " + telefoonnummer + "#" + "E-mail: " + email);

                        userInformation = userInformation.Replace("#", System.Environment.NewLine);
                    }
                    return userInformation;
                }
            }

            catch (OracleException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return userInformation;
        }

        public static void PlaceReaction(int reviewID, long volunteerID, string inhoud)
        {
            int this_reactionID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(REACTIONID) FROM REACTION";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        this_reactionID = Convert.ToInt32(_Reader["COUNT(REACTIONID)"]) + 1;
                    }
                }

                m_command.CommandText = "INSERT INTO REACTION (REACTIONID, REVIEWID, VOLUNTEERID, INHOUD) VALUES (:REAID, :REVID, :VID, :INHOUD)";
                m_command.Parameters.Add("REAID", OracleDbType.Int32).Value = this_reactionID;
                m_command.Parameters.Add("REVID", OracleDbType.Int32).Value = reviewID;
                m_command.Parameters.Add("VID", OracleDbType.Int32).Value = volunteerID;
                m_command.Parameters.Add("INHOUD", OracleDbType.Varchar2).Value = inhoud;

                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        }

        public static int COUNTHULP()
        {
            int count = 0;
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT COUNT(*) FROM HULPVRAAG";
                count = int.Parse(m_command.ExecuteScalar().ToString());
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return count;
        }

        public static int COUNTREVIEW()
        {
            int count = 0;
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT COUNT(*) FROM REVIEW";
                count = int.Parse(m_command.ExecuteScalar().ToString());
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return count;
        }

        public static int COUNTMESSAGES(int needy, int volunteer)
        {
            int count = 0;
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT COUNT(*) FROM CHAT WHERE GEBRUIKERID = :GEBRUIKERID AND GEBRUIKERID2 = :GEBRUIKERID2";
                m_command.Parameters.Add("GEBRUIKERID", OracleDbType.Int32).Value = needy;
                m_command.Parameters.Add("GEBRUIKERID2", OracleDbType.Int32).Value = volunteer;
                count = int.Parse(m_command.ExecuteScalar().ToString());
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return count;
        }

        public static int COUNTREACTION(long volunteerid)
        {
            int count = 0;
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT COUNT(*) FROM REACTION WHERE VOLUNTEERID = :VID";
                m_command.Parameters.Add("GEBRUIKERID2", OracleDbType.Int32).Value = volunteerid;
                count = int.Parse(m_command.ExecuteScalar().ToString());
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            return count;
        }

        public static void ReviewVolunteerUnitTest(string beoordeling, string opmerkingen, int needyID, int volunteerID)
        {
            int my_UserID = 0;
            int this_reviewID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(ReviewID) FROM Review";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        this_reviewID = Convert.ToInt32(_Reader["COUNT(ReviewID)"]) + 1;
                    }
                }

                m_command.CommandText =
                    "INSERT INTO Review(ReviewID, Beoordeling, Opmerkingen, NeedyID, VolunteerID) VALUES(:ReviewID, :Beoordeling, :Opmerkingen, :NeedyID, :VolunteerID)";

                Command.Parameters.Add("ReviewID", OracleDbType.Int32).Value = this_reviewID;
                Command.Parameters.Add("Beoordeling", OracleDbType.Varchar2).Value = beoordeling;
                Command.Parameters.Add("Opmerkingen", OracleDbType.Varchar2).Value = opmerkingen;
                Command.Parameters.Add("NeedyID", OracleDbType.Int32).Value = needyID;
                Command.Parameters.Add("VolunteerID", OracleDbType.Int32).Value = volunteerID;

                Command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {

                Console.WriteLine(ex.Message);
            }
        
        }

        public static void makeapointment(int request, int needy, int volunteer)
        {
            int AutoID = 0;
            try
            {
                OpenConnection();
                m_command = new OracleCommand();
                m_command.Connection = m_conn;
                m_command.CommandText = "SELECT COUNT(AfspraakID) from Afspraak";
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        AutoID = Convert.ToInt32(_Reader["COUNT(AfspraakID)"]) + 1;
                    }
                }
                m_command.CommandText = "INSERT INTO Afspraak (AfspraakID, HulpvraagID, NeedyID, VolunteerID) VALUES (:AID, :HID, :NID, :VID)";
                m_command.Parameters.Add("AID", OracleDbType.Int32).Value = AutoID;
                m_command.Parameters.Add("HID", OracleDbType.Int32).Value = request;
                m_command.Parameters.Add("NID", OracleDbType.Int32).Value = needy;
                m_command.Parameters.Add("VID", OracleDbType.Int32).Value = volunteer;
                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        }

        //nog niet af
        //public static string getap(int account)
        //{
        //    string agenda = "";
        //    string Hulpvraag = "";
        //    string Needy = "";
        //    string Volunteer = "";
        //    try
        //    {
        //        OpenConnection();
        //        m_command = new OracleCommand();
        //        m_command.Connection = m_conn;
        //        m_command.CommandText = "SELECT g.GEBRUIKERSNAAM, g.GEBRUIKERSNAAM, h.OMSCHRIJVING from gebruiker g, gebruiker g1, afspraak a join hulpvraag h on a.HULPVRAAGID = h.HULPVRAAGID where a.NEEDYID = g.:ID or a.VOLUNTEERID = g1.:ID";
        //        m_command.Parameters.Add("ID", OracleDbType.Int32).Value = account;
        //        m_command.ExecuteNonQuery();
        //        using (OracleDataReader _Reader = Database.Command.ExecuteReader())
        //        {
        //            while (_Reader.Read())
        //            {
        //                Hulpvraag = Convert.ToString(_Reader["h.OMSCHRIJVING"]);
        //                Needy = Convert.ToString(_Reader["g.GEBRUIKERSNAAM"]);
        //                Volunteer = Convert.ToString(_Reader["g.GEBRUIKERSNAAM"]);
        //            }
        //        }

        //        agenda = Needy + Volunteer + Hulpvraag;


        //    }
        //    catch (OracleException ex)
        //    {
        //        Database.CloseConnection();
        //        Console.WriteLine(ex.Message);
        //    }
        //    return agenda;
        //}

    }
}