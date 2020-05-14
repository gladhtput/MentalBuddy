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
    public partial class GenDiscChosen : Form
    {
        public GenDiscChosen(Diskusi diskusi)
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
            GenDiscMenuCapas GDC = new GenDiscMenuCapas();
            GDC.Show();
            this.Hide();
        }
    }
}
