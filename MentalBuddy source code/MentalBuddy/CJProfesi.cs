using MentalBuddyDB;
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
    public partial class CJProfesi : Form
    {
        public CJProfesi()
        {
            InitializeComponent();
        }



        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Dokter dokter = dataGridView1.SelectedRows[0].DataBoundItem as Dokter;
                ProfilPsi Psi = new ProfilPsi(dokter);
                Psi.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Silahkan Pilih Salah Satu");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariJadwal cj = new CariJadwal();
            cj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                dataGridView1.DataSource = Dokter.getByType("psikolog");
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Deskripsi"].Visible = false;
                dataGridView1.Columns["Provinsi"].Visible = false;
                dataGridView1.Columns["Kota"].Visible = false;
                dataGridView1.Columns["Alamat_praktik"].Visible = false;
                dataGridView1.Columns["Jadwal_praktik"].Visible = false;
                dataGridView1.Columns["Social_media"].Visible = false;
                dataGridView1.Columns["Tarif"].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = Dokter.getByType("psikiater");
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Deskripsi"].Visible = false;
                dataGridView1.Columns["Provinsi"].Visible = false;
                dataGridView1.Columns["Kota"].Visible = false;
                dataGridView1.Columns["Alamat_praktik"].Visible = false;
                dataGridView1.Columns["Jadwal_praktik"].Visible = false;
                dataGridView1.Columns["Social_media"].Visible = false;
                dataGridView1.Columns["Tarif"].Visible = false;
            }
        }
    }
}
