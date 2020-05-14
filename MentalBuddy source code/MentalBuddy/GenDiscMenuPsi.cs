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
    public partial class GenDiscMenuPsi : Form
    {
        public GenDiscMenuPsi()
        {
            InitializeComponent();
            loadDiscussionist();
        }

        public void loadDiscussionist()
        {
            dataGridView1.DataSource = Diskusi.getList();
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Dokter_id"].Visible = false;
            dataGridView1.Columns["Dokter_nama"].HeaderText = "By";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(dataGridView1.SelectedRows.Count > 0)
            {
                Diskusi diskusi = dataGridView1.SelectedRows[0].DataBoundItem as Diskusi;
                GenDiscChoosenPsi genDisc = new GenDiscChoosenPsi(diskusi);
                genDisc.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Silahkan Pilih Salah Satu Diskusi");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePsi HP = new HomePsi();
            HP.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenDiscPost GDP = new GenDiscPost();
            GDP.Show();
            this.Hide();
        }
    }
}
