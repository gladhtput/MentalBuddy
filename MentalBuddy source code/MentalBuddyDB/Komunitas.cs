using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MentalBuddyDB
{
  

    public class Komunitas
    {
        private string id;
        private string nama;
        private string deskripsi;
        private string link;

        public Komunitas(string id,string nama,string deskripsi,string link)
        {
            this.Id = id;
            this.Nama = nama;
            this.Deskripsi = deskripsi;
            this.Link = link;
        }

        public static Komunitas[] getList()
        {

            string queryString = "SELECT * FROM komunitas";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            List<Komunitas> listkomunitas = new List<Komunitas>();

            while (reader.Read())
            {
                Komunitas komunitas = new Komunitas(
                reader[0].ToString(),
                reader[1].ToString(),
                reader[2].ToString(),
                reader[3].ToString()
                );
                listkomunitas.Add(komunitas);
            }

            return listkomunitas.ToArray();
        }


        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public string Link { get => link; set => link = value; }
    }
}
