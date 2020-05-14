using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MentalBuddyDB;
using MentalBuddyAPI;

namespace MentalBuddy
{
    public partial class EditPraktik : Form
    {
        Dokter dokter;
        Provinsi[] provincies;

        public EditPraktik()
        {
            InitializeComponent();
            provincies = Alamat.GetProvinsiList();
            comboBox1.Items.AddRange(Provinsi.getAllName(provincies));
            loadData();
        }

        public void loadData()
        {

            this.dokter = Dokter.getDokter();

            tb_user.Text = dokter.Nama;
            textBox1.Text = dokter.Umur.ToString();
            richTextBox1.Text = dokter.Deskripsi;
            comboBox1.Text = dokter.Provinsi;
            comboBox2.Text = dokter.Kota;
            richTextBox2.Text = dokter.Alamat_praktik;
            richTextBox3.Text = dokter.Jadwal_praktik;
            textBox2.Text = dokter.Telepon;
            textBox3.Text = dokter.Social_media;
            textBox4.Text = dokter.Tarif;

            if (dokter.Type == "psikolog")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            if (dokter.Image != "")
            {
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\images\\";
                string fullPathImage = path + System.IO.Path.GetFileName(dokter.Image);
                Console.WriteLine(fullPathImage);
                image1.ImageLocation = fullPathImage;
            }



        }

        private void combo_change_select(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            string id = Provinsi.getIdFromName(provincies, comboBox1.Text);
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(Alamat.GetKotaList(id));

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files (*.png)|*.png| All files(*.)|*.";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    image1.ImageLocation = dialog.FileName;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Terjadi Kesalahan", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Simpan?", "Mental Buddy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && image1.ImageLocation != "")
            {

                string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10)) + "\\images\\";
                string correctFileName = tb_user.Text + System.IO.Path.GetFileName(image1.ImageLocation);

                if (!System.IO.Directory.Exists(path)) System.IO.Directory.CreateDirectory(path);

                System.IO.File.Copy(image1.ImageLocation, path + correctFileName, true);

                dokter.Nama = tb_user.Text;
                dokter.Umur = int.Parse(textBox1.Text);
                dokter.Deskripsi = richTextBox1.Text;
                dokter.Provinsi = comboBox1.Text;
                dokter.Kota = comboBox2.Text;
                dokter.Alamat_praktik = richTextBox2.Text;
                dokter.Jadwal_praktik = richTextBox3.Text;
                dokter.Telepon = textBox2.Text;
                dokter.Social_media = textBox3.Text;
                dokter.Tarif = textBox4.Text;
                dokter.Image = correctFileName;
                if (radioButton1.Checked) dokter.Type = "psikolog";
                else dokter.Type = "psikiater";


                if (Dokter.updateDokter(this.dokter)) MessageBox.Show("Data Berhasil Diperbaharui");
                else MessageBox.Show("Terjadi Kesalahan");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePsi hp = new HomePsi();
            hp.Show();
            this.Hide();
        }
    }
}
