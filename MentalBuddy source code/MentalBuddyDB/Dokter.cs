using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace MentalBuddyDB
{
    public class Dokter
    {

        private string id;
        private string nama;
        private int umur;
        private string deskripsi;
        private string provinsi;
        private string kota;
        private string alamat_praktik;
        private string jadwal_praktik;
        private string telepon;
        private string social_media;
        private string type;
        private string tarif;
        private string image;

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Umur { get => umur; set => umur = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public string Provinsi { get => provinsi; set => provinsi = value; }
        public string Kota { get => kota; set => kota = value; }
        public string Alamat_praktik { get => alamat_praktik; set => alamat_praktik = value; }
        public string Jadwal_praktik { get => jadwal_praktik; set => jadwal_praktik = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        public string Social_media { get => social_media; set => social_media = value; }
        public string Type { get => type; set => type = value; }
        public string Tarif { get => tarif; set => tarif = value; }
        public string Image { get => image; set => image = value; }

        public Dokter(string id, string nama, int umur, string deskripsi, string provinsi, string kota, string alamat_praktik, string jadwal_praktik, string telepon, string social_media, string type, string tarif, string image)
        {
            this.Id = id;
            this.Nama = nama;
            this.Umur = umur;
            this.Deskripsi = deskripsi;
            this.Provinsi = provinsi;
            this.Kota = kota;
            this.Alamat_praktik = alamat_praktik;
            this.Jadwal_praktik = jadwal_praktik;
            this.Telepon = telepon;
            this.Social_media = social_media;
            this.Type = type;
            this.Tarif = tarif;
            this.Image = image;
        }


        public static bool updateDokter(Dokter dokter)
        {

            string queryString = "UPDATE dokter SET "
               + "nama = '" + dokter.nama
               + "',umur = " + dokter.umur
               + ",deskripsi = '" + dokter.deskripsi
               + "',provinsi = '" + dokter.provinsi
               + "',kota = '" + dokter.kota
               + "',alamat_praktik='" + dokter.alamat_praktik
               + "',jadwal_praktik='" + dokter.jadwal_praktik
               + "',telepon='" + dokter.telepon
               + "',social_media='" + dokter.social_media
               + "',type= '" + dokter.type
               + "',tarif='" + dokter.tarif
               + "',gambar = '" + dokter.Image + "'"
               + " WHERE id = " + dokter.Id;

            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            bool status = db.update();

            return status;

        }


        public static Dokter[] getByProvince(string province, string type)
        {
            string queryString = "SELECT * FROM dokter WHERE type = '" + type + "' AND provinsi = '" + province + "'";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            List<Dokter> listdokter = new List<Dokter>();

            while (reader.Read())
            {
                Dokter dokter = new Dokter(
                reader[0].ToString(),
                reader[1].ToString(),
                Int32.Parse(reader[2].ToString()),
                reader[3].ToString(),
                reader[4].ToString(),
                reader[5].ToString(),
                reader[6].ToString(),
                reader[7].ToString(),
                reader[8].ToString(),
                reader[9].ToString(),
                reader[10].ToString(),
                reader[11].ToString(),
                reader[12].ToString()
                );

                listdokter.Add(dokter);
            }

            return listdokter.ToArray();
        }

        public static Dokter[] getByType(string type)
        {
            string queryString = "SELECT * FROM dokter WHERE type = '" + type + "'";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            List<Dokter> listdokter = new List<Dokter>();

            while (reader.Read())
            {
                Dokter dokter = new Dokter(
                reader[0].ToString(),
                reader[1].ToString(),
                Int32.Parse(reader[2].ToString()),
                reader[3].ToString(),
                reader[4].ToString(),
                reader[5].ToString(),
                reader[6].ToString(),
                reader[7].ToString(),
                reader[8].ToString(),
                reader[9].ToString(),
                reader[10].ToString(),
                reader[11].ToString(),
                reader[12].ToString()
                );

                listdokter.Add(dokter);
            }

            return listdokter.ToArray();
        }

        public static Dokter getByName(string nama, string type)
        {
            string queryString = "SELECT * FROM dokter WHERE type = '" + type + "' AND nama LIKE '%" + nama + "%'";
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            Dokter dokter = null;

            while (reader.Read())
            {
                dokter = new Dokter(
               reader[0].ToString(),
               reader[1].ToString(),
               Int32.Parse(reader[2].ToString()),
               reader[3].ToString(),
               reader[4].ToString(),
               reader[5].ToString(),
               reader[6].ToString(),
               reader[7].ToString(),
               reader[8].ToString(),
               reader[9].ToString(),
               reader[10].ToString(),
               reader[11].ToString(),
               reader[12].ToString()
               );

            }

            return dokter;
        }

        public static Dokter getDokter()
        {
            string queryString = "SELECT * FROM dokter WHERE id =" + User.loginuser.Dokter_id;
            DBConnection db = DBConnection.getConnection();
            db.makeQuery(queryString);
            OleDbDataReader reader = db.retrive();

            Dokter dokter = null;

            while (reader.Read())
            {
                dokter = new Dokter(
               reader[0].ToString(),
               reader[1].ToString(),
               Int32.Parse(reader[2].ToString()),
               reader[3].ToString(),
               reader[4].ToString(),
               reader[5].ToString(),
               reader[6].ToString(),
               reader[7].ToString(),
               reader[8].ToString(),
               reader[9].ToString(),
               reader[10].ToString(),
               reader[11].ToString(),
               reader[12].ToString()
               );

            }

            return dokter;

        }
    }
}
