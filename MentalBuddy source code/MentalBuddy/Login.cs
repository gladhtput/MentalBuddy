using MentalBuddyDB;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Awal aw = new Awal();
            aw.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = textBox1.Text;

           
            //Memanggil fungsi static dari class user, jika username & sandi benar maka akan return true
            if(User.auth(username, password))
            {
                MessageBox.Show("Login Berhasil, Selamat Datang "+ username);
                HomePsi home = new HomePsi();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, Password atau Kata Sandi Salah");
                tbUser.Text = "";
                textBox1.Text = "";
            }

           
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
