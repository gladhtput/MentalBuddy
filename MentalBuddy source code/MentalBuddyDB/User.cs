using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MentalBuddyDB
{
    public class User
    {
        private string id;
        private string username;
        private string password;
        private string dokter_id;
        public static User loginuser = null;


        private User(string id, string username, string password, string dokter_id)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Dokter_id = dokter_id;
        }

        public string Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Dokter_id { get => dokter_id; set => dokter_id = value; }

        public static bool auth(string username, string password)
        {
            string queryString = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + password + "'";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            User user = null;


            while (reader.Read())
            {
                user = new User(
               reader[0].ToString(),
               reader[1].ToString(),
               reader[2].ToString(),
               reader[3].ToString()
               );
            }

            if (user != null)
            {
                loginuser = user;   
                return true;
            }
            else return false;
            
        }
    }
}
