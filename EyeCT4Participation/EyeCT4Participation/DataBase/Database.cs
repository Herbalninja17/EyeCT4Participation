using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace EyeCT4Participation.DataBase
{
    public static class Database
    {
        private static readonly string m_databaseFilename = "Database.sql";
        private static OracleConnection m_conn;
        private static OracleCommand m_command;
        static string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS=(PROTOCOL=TCP)(HOST=fhictora01.fhict.local)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=fhictora)));User ID=dbi325648;PASSWORD=Hoi;";
        

        /// Open de verbinding met de database
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
                {
                    m_conn.Open();
                    return true;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return returnvalue;
        }

        public static string Query
        {
            set
            {
                OpenConnection();

                try
                {
                    m_command = new OracleCommand(value, m_conn);
                    //m_conn.Open();

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }



        /// Haalt het command-object op waarmee queries uitgevoerd kunnen worden.
        public static OracleCommand Command { get { return m_command; } }

        /// Haal de bestandsnaam op van de database.
        public static string DatabaseFilename { get { return m_databaseFilename; } }

        public static void CloseConnection()
        {

            try
            {
                // Controleer of de verbinding niet al gesloten is
                if (m_conn.State != System.Data.ConnectionState.Closed)
                {
                    m_conn.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// Controleert of de database al bestaat. Zo niet, wordt deze aangemaakt
        /// en gevuld met wat dummy data. Daarnaast wordt altijd de connectie opgezet
        /// met de database indien deze nog niet opgezet was.
        /// </summary>
        private static void PrepareConnection()
        {

            bool createNew = !File.Exists(m_databaseFilename);

            // Zet een verbinding op met de database
            if (m_conn == null)
            {
                m_conn = new OracleConnection("Data Source=" + m_databaseFilename);
            }

            // Als we een nieuwe database gemaakt hebben, voegen we alvast wat records toe.
            // We doen dit nu pas omdat we een connection nodig hebben om te communiceren met
            // de database: vandaar dat deze code niet boven bij de CreateFile functie staat.
            if (createNew)
            {
                //CreateDummyData();
            }

           
        }

        public static void getUser(string userName, string wachtwoord)
        {

        }
        public static void GetUser()
        {  
            try
            {
                Query = "SELECT Gebruikersnaam FROM gebruiker;";
               // m_command.Parameters.Add("@UserID", System.Data.DbType.Int32).Value = p_UserID;
                List<String> Namen = new List<String>();
                using (OracleDataReader _Reader = Database.Command.ExecuteReader())
                {
                    while (_Reader.Read())
                    {
                        string _Test = Convert.ToString(_Reader["Gebruikersnaam"]);
                    }
                }
                    
	         
	
                 
            }
            catch (OracleException ex)
            {
                Database.CloseConnection();
                Console.WriteLine(ex.Message);
      
            }
        }
    }
}