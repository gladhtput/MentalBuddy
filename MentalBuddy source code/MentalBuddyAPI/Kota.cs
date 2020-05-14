using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentalBuddyAPI
{
    public class Kota
    {
        private string id;
        private string nama;

        public Kota(string id, string nama)
        {
            this.Id = id;
            this.Nama = nama;
        }

        public string Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}
