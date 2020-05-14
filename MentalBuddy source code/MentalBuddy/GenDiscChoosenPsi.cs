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
    public partial class GenDiscChoosenPsi : Form
    {
        public GenDiscChoosenPsi(Diskusi diskusi)
        {
            InitializeComponent();
            loadDiskusi(diskusi);
        }

        public void loadDiskusi(Diskusi diskusi)
        {
            label1.Text = diskusi.Judul;
            label3.Text = diskusi.Dokter_nama;
            richTextBox1.Text = diskusi.Isi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenDiscMenuPsi GDP = new GenDiscMenuPsi();
            GDP.Show();
            this.Hide();
        }
    }
}
