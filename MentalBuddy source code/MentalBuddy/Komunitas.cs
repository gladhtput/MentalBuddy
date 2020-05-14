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
    public partial class Komunitas : Form
    {
        public Komunitas()
        {
            InitializeComponent();
            loadlist();
        }

        public void loadlist()
        {
            dataGridView1.DataSource = Kom.getList();
            dataGridView1.Columns["Id"].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Kom komunitas = dataGridView1.SelectedRows[0].DataBoundItem as Kom;

                KomunitasShow ks = new KomunitasShow(komunitas);
                ks.Show();
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
