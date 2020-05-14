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
    public partial class GenDiscMenuCapas : Form
    {
        public GenDiscMenuCapas()
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

            if (dataGridView1.SelectedRows.Count > 0)
            {
                Diskusi diskusi = dataGridView1.SelectedRows[0].DataBoundItem as Diskusi;

                GenDiscChosen GDC = new GenDiscChosen(diskusi);
                GDC.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Salah Satu Diskusi");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeCapas HC = new HomeCapas();
            HC.Show();
            this.Hide();
        }
    }
}
