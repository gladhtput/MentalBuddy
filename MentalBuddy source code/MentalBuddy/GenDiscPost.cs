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
    public partial class GenDiscPost : Form
    {
        public GenDiscPost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Simpan?", "Mental Buddy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Insert data dengan model Diskusi DB
                bool status = Diskusi.store(textBox2.Text, textBox1.Text);
                if (status)
                {
                    MessageBox.Show("Berhasil Disimpan");
                    GenDiscMenuPsi GDP = new GenDiscMenuPsi();
                    GDP.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Something Wrong :(");
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenDiscMenuPsi GDP = new GenDiscMenuPsi();
            GDP.Show();
            this.Hide();
        }
    }
}
