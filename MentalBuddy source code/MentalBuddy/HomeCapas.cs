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
    public partial class HomeCapas : Form
    {
        public HomeCapas()
        {
            InitializeComponent();
        }

        private void btnCariJadwal_Click(object sender, EventArgs e)
        {
            CariJadwal cariJadwal = new CariJadwal();
            cariJadwal.Show();
            this.Hide();
        }

        private void btnKomunitas_Click(object sender, EventArgs e)
        {
            Komunitas komunitas = new Komunitas();
            komunitas.Show();
            this.Hide();
        }

        private void btnGenDisc_Click(object sender, EventArgs e)
        {
            GenDiscMenuCapas genDisc = new GenDiscMenuCapas();
            genDisc.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Awal awal = new Awal();
            awal.Show();
            this.Hide();
        }
    }
}
