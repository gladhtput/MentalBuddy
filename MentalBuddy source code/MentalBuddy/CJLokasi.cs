using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MentalBuddyAPI;
using MentalBuddyDB;

namespace MentalBuddy
{
    public partial class CJLokasi : Form
    {
        public CJLokasi()
        {
            InitializeComponent();
            loadProvinsi();
            radioButton1.Checked = true;
        }

        public void loadProvinsi()
        {
            //Ambil data api kemudian taruh di combobox
            comboBox1.Items.AddRange(Provinsi.getAllName(Alamat.GetProvinsiList()));
        }

        private void CJLokasi_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string type = radioButton1.Checked ? "psikolog" : "psikiater";

                dataGridView1.DataSource = Dokter.getByProvince(comboBox1.Text, type);
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
                MessageBox.Show("Pastikan Memilih Provinsi yang tersedia");
                   
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CariJadwal cj = new CariJadwal();
            cj.Show();
            this.Hide();
        }

        private void button3_click(Object sender, EventArgs e)
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
                MessageBox.Show("Silahkan Pilih Salah Satu ");
            }
        }
    }
}
