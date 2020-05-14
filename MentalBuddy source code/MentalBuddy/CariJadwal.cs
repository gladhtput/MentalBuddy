using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MentalBuddy
{
    public partial class CariJadwal : Form
    {
        public CariJadwal()
        {
            InitializeComponent();
        }

        private void CariJadwal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CJLokasi lokasi = new CJLokasi();
                lokasi.Show();
                this.Hide();
            }

            else if (radioButton3.Checked)
            {
                CJProfesi profesi = new CJProfesi();
                profesi.Show();
                this.Hide();
            }

            else if (radioButton2.Checked)
            {
                CJNama nama = new CJNama();
                nama.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Silahkan Memilih Menu Pencarian");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeCapas HC = new HomeCapas();
            HC.Show();
            this.Hide();
        }
    }
}
