using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MentalBuddyDB;
using System.IO;

namespace MentalBuddy
{
    public partial class ProfilPsi : Form
    {
        public ProfilPsi(Dokter dokter = null)
        {
            InitializeComponent();
            loadData(dokter);
        }

        public void loadData(Dokter dokter)
        {
            label2.Text = dokter.Nama;
            label4.Text = dokter.Umur.ToString();
            richTextBox1.Text = dokter.Deskripsi;
            richTextBox2.Text = dokter.Alamat_praktik;
            richTextBox3.Text = dokter.Jadwal_praktik;
            label17.Text = "Kota: " + dokter.Kota;
            label7.Text = "Provinsi: " + dokter.Provinsi;
            richTextBox4.Text = dokter.Telepon;
            richTextBox5.Text = dokter.Social_media;
            label5.Text = "Rp." + dokter.Tarif;

            if (dokter.Image != "")
            {
                
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\images\\";
                Console.WriteLine(path);
                string fullPathImage = path + System.IO.Path.GetFileName(dokter.Image);
                Console.WriteLine(fullPathImage);
                pictureBox1.ImageLocation = fullPathImage;
            }

        }

        private void ProfilPsi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariJadwal cj = new CariJadwal();
            cj.Show();
            this.Hide();
        }
    }
}
