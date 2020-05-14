using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalBuddyAPI
{
    public class Provinsi
    {
        private string id;
        private string nama;

        public Provinsi(string id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public static string getIdFromName(Provinsi[] provincies, string name)
        {
            foreach(Provinsi province in provincies)
            {
                if(province.Nama == name)
                {
                    return province.Id;
                }
              
            }

            return null;
        }
        public static String[] getAllName(Provinsi[] provincies)
        {
            List<String> listNama = new List<string>();

            foreach(Provinsi province in provincies)
            {
                listNama.Add(province.Nama);
            }

            return listNama.ToArray();
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}
