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

namespace Agro_Projek.View
{
    public partial class UCloginAdmin : UserControl
    {
        public UCloginAdmin()
        {
            InitializeComponent();
        }

        private void UCloginAdmin_Load(object sender, EventArgs e)
        {

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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPassword.Text;

            LoginController login = new LoginController();
            bool isValid = login.validasiloginAdmin(username, password);

            if (isValid)
            {
                MessageBox.Show("Login Berhasil", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var mainForm = this.Parent as panelBox;
                mainForm.loadControl(new UCdashboardAdmin());
            }
            else
            {
                MessageBox.Show("Akun admin tidak ditemukan, silahkan login sebagai user biasa!!", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textUsername.Clear();
                textPassword.Clear();
            }
        }

        private void linkUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UClogin());
            this.Hide();
        }
    }
}
