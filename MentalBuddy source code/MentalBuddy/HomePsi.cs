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
    public partial class HomePsi : Form
    {
        public HomePsi()
        {
            InitializeComponent();
        }

        private void btn_editobat_Click(object sender, EventArgs e)
        {
            EditPraktik EP = new EditPraktik();
            EP.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenDiscMenuPsi GDP = new GenDiscMenuPsi();
            GDP.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda Yakin Untuk Log Out?", "Mental Buddy", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Berhasil Log Out");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
