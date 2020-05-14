using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace MentalBuddyDB
{
    public class DBConnection
    {
        private static DBConnection _instance;

        private OleDbConnection dbConnection;
        private OleDbCommand dbCommand;
        private OleDbDataReader dbDataReader;

        private string query;

      //Menerapkan Design Pattern Singleton, hanya satu object Connection yang bisa digunakan
        private DBConnection()
        {
            dbConnection = new OleDbConnection(ConfigurationManager.ConnectionStrings["MentalBuddy.Properties.Settings.Constring"].ConnectionString);
            dbConnection.Open();
        }

        public void makeQuery(string query)
        {
            this.query = query;
            dbCommand = new OleDbCommand(this.query, dbConnection);
        }

        public bool insert()
        {
            try
            {

                dbCommand.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool update()
        {
            try
            {
                
                dbCommand.ExecuteReader();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public OleDbDataReader retrive()
        {
            try
            {
               
                dbDataReader = dbCommand.ExecuteReader();
            }
            catch
            {
                throw;
            }

            return dbDataReader;
        }

        public static DBConnection getConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }

            return _instance;
        }



    }
}
