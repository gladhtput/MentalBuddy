using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kom = MentalBuddyDB.Komunitas;

namespace MentalBuddy
{
    public partial class KomunitasShow : Form
    {
        public KomunitasShow(Kom komunitas)
        {
            InitializeComponent();
            loadkomunitas(komunitas);
        }
        public void loadkomunitas(Kom kom)
        {
            label4.Text = kom.Nama;
            richTextBox1.Text = kom.Deskripsi;
            label5.Text = kom.Link;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            HomeCapas hc = new HomeCapas();
            hc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Komunitas kom = new Komunitas();
            kom.Show();
            this.Hide();
        }
    }
}
