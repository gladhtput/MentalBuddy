using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MentalBuddyDB
{
    public class Diskusi
    {
        private string id;
        private string judul;
        private string isi;
        private string dokter_id;
        private string dokter_nama;

        public Diskusi(string id, string judul, string isi, string dokter_id, string dokter_nama)
        {
            this.Id = id;
            this.Judul = judul;
            this.Isi = isi;
            this.Dokter_id = dokter_id;
            this.Dokter_nama = dokter_nama;
        }

        //Menyimpan Data Diskusi yg baru dibuat
        public static bool store(string judul, string isi)
        {
            string queryString = "INSERT INTO diskusi(judul,isi,dokter_id) VALUES ('" + judul+ "','" + isi + "','" + User.loginuser.Dokter_id + "')";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            return db.insert();
        }

        public static Diskusi[] getList()
        {

            string queryString = "SELECT diskusi.id, diskusi.judul, diskusi.isi, diskusi.dokter_id, dokter.nama FROM diskusi INNER JOIN dokter ON diskusi.dokter_id = dokter.id;";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            List<Diskusi> listdiskusi = new List<Diskusi>();

            while (reader.Read())
            {
               Diskusi diskusi = new Diskusi(
               reader[0].ToString(),
               reader[1].ToString(),
               reader[2].ToString(),
               reader[3].ToString(),
               reader[4].ToString()
               );
                listdiskusi.Add(diskusi);
            }

            return listdiskusi.ToArray();
        }

        public string Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Isi { get => isi; set => isi = value; }
        public string Dokter_id { get => dokter_id; set => dokter_id = value; }
        public string Dokter_nama { get => dokter_nama; set => dokter_nama = value; }
    }
}
