using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agro_Projek.Controller;
using Agro_Projek.Model;

namespace Agro_Projek.View
{
    public partial class UClogin : UserControl
    {
        public UClogin()
        {
            InitializeComponent();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UClogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            LoginController login = new LoginController();
            bool isValid = login.validasilogin(username, password);

            if (isValid)
            {
                MessageBox.Show("Login Berhasil", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                var mainForm = this.Parent as panelBox;

                if (mainForm != null)
                {
                    mainForm.loadControl(new UCproduk());
                }
            }
            else
            {
                MessageBox.Show("Maaf, Username atau Kata Sandi Salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkPw_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPw.Checked == true)
            {
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCregister());
            this.Hide();
        }

        private void linkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCloginAdmin());
            this.Hide();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
