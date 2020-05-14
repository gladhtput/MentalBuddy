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
namespace MentalBuddy
{
    public partial class CJNama : Form
    {
        public CJNama()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cari1_Click(object sender, EventArgs e)
        {
            string nama = tb_nama.Text;
            string type = comboBox1.Text;

            Dokter dokter = Dokter.getByName(nama,type);

            if (tb_nama.Text == "")
            {
                MessageBox.Show("Jangan Kosongkan Nama");
            }

            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Jangan Kosongkan Profesi");
            }

            else if(dokter != null)
            {
                ProfilPsi Psi = new ProfilPsi(dokter);
                Psi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tidak ada data, Cari lagi");
                tb_nama.Text = "";
            } 

           
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            CariJadwal cj = new CariJadwal();
            cj.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
