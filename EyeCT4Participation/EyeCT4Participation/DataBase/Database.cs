﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;


namespace EyeCT4Participation.DataBase
{
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
                {return true;}
            }
            catch (Exception ex) {Console.WriteLine("Connection failed: " + ex.Message);}
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
        
        public static string GetUser() // Gebruik deze om jullie command en results te testen jongens
        {
            string _test = "no";
            try
            {
                OpenConnection();                   // om connection open te maken
                m_command = new OracleCommand();    // hoef eingelijk niet doordat het all in OpenConnection() zit
                m_command.Connection = m_conn;      // een connection maken met het command
                m_command.CommandText = "SELECT COUNT(Gebruikerid) from Gebruiker";
                m_command.ExecuteNonQuery();                
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        _test = Convert.ToString(Convert.ToInt32(_Reader["COUNT(Gebruikerid)"]));
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
        public static void RegesterUser(string username, string password, string acctype, string email, string fullname, string address, string city, int phone, string gender)
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
                        AutoID = Convert.ToInt32(_Reader["COUNT(Gebruikerid)"]) + 1;
                    }
                }
                m_command.CommandText = "INSERT INTO Gebruiker (GebruikerID, Gebruikersnaam, Wachtwoord, Naam, Geslacht, Adres, Woonplaats, Telefoonnummer, Email, Gebruikerstype) VALUES (:GebruikerID, :Gebruikersnaam, :Wachtwoord, :Naam, :Geslacht, :Adres, :Woonplaats, :Telefoonnummer, :Email, :Gebruikerstype)";
                m_command.Parameters.Add("GebruikerID", OracleDbType.Int32).Value = AutoID;
                m_command.Parameters.Add("Gebruikersnaam", OracleDbType.Varchar2).Value = username;
                m_command.Parameters.Add("Wachtwoord", OracleDbType.Varchar2).Value = password;
                m_command.Parameters.Add("Naam", OracleDbType.Varchar2).Value = fullname;
                m_command.Parameters.Add("Geslacht", OracleDbType.Varchar2).Value = gender;
                m_command.Parameters.Add("Adres", OracleDbType.Varchar2).Value = address;
                m_command.Parameters.Add("Woonplaats", OracleDbType.Varchar2).Value = city;
                m_command.Parameters.Add("Telefoonnummer", OracleDbType.Int32).Value = phone;
                m_command.Parameters.Add("Email", OracleDbType.Varchar2).Value = email;
                m_command.Parameters.Add("Gebruikerstype", OracleDbType.Varchar2).Value = acctype;
                m_command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
        } //goodluck! </Rechard>  

        public static string ac;
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
                m_command.CommandText = "SELECT Gebruikersnaam, Wachtwoord, Gebruikerstype FROM gebruiker WHERE Wachtwoord = :password AND Gebruikersnaam = :username"; 
                m_command.Parameters.Add("password", OracleDbType.Varchar2).Value = password;
                m_command.Parameters.Add("ussername", OracleDbType.Varchar2).Value = username;
                m_command.ExecuteNonQuery();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        string acctype = Convert.ToString(_Reader["Gebruikerstype"]);
                        ac = acctype;
                        result = Convert.ToString(_Reader["Gebruikersnaam"]);
                        if(result == username) { ok = true; }
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

        // HULPVRAAG UITZETTEN <Thom>

        public static void placeARequest(string omschrijving, string locatie, int reistijd, string vervoerType, string startDatum, string eindDatum, string urgent, int aantalVrijwilligers)
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

                m_command.CommandText = "INSERT INTO Hulpvraag(HulpvraagID, Omschrijving, Locatie, Reistijd, VervoerType, Startdatum, Einddatum, Urgent, AantalVrijwilligers, GebruikerID) VALUES(:HulpvraagID, :Omschrijving, :Locatie, :Reistijd, :Vervoertype, :Startdatum, :Einddatum, :Urgent, :AantalVrijwilligers, :GebruikerID)";

                Command.Parameters.Add("HulpvraagID", OracleDbType.Int32).Value = this_hulpvraagID;
                Command.Parameters.Add("Omschrijving", OracleDbType.Varchar2).Value = omschrijving;
                Command.Parameters.Add("Locatie", OracleDbType.Varchar2).Value = locatie;
                Command.Parameters.Add("Reistijd", OracleDbType.Int32).Value = reistijd;
                Command.Parameters.Add("Vervoertype", OracleDbType.Varchar2).Value = vervoerType;
                Command.Parameters.Add("Startdatum", OracleDbType.Varchar2).Value = startDatum;
                Command.Parameters.Add("Einddatum", OracleDbType.Varchar2).Value = eindDatum;
                Command.Parameters.Add("Urgent", OracleDbType.Char).Value = urgent;
                Command.Parameters.Add("AantalVrijwilligers", OracleDbType.Int32).Value = aantalVrijwilligers;
                Command.Parameters.Add("GebruikerID", OracleDbType.Int32).Value = "1";

                Command.ExecuteNonQuery();
            }
            catch (OracleException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}



