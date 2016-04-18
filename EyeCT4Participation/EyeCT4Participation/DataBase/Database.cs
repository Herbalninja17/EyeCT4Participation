using System;
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
        
        public static string GetUser()
        {
            string _test = "no";
            try
            {
                Query = "SELECT Gebruikersnaam FROM gebruiker";
                //m_command.Parameters.Add("@UserID", System.Data.DbType.Int32).Value = p_UserID;
                List<String> Namen = new List<String>();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        _test = Convert.ToString(_Reader["Gebruikersnaam"]);
                    }
                }
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
            }
            CloseConnection();
            return _test;
        }


        
    }
}



