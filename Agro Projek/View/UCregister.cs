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
using Npgsql;

namespace Agro_Projek.View
{
    public partial class UCregister : UserControl
    {

        public UCregister()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textUsername.Text;
            string password = textPw.Text;
            string no_telepon = textTelepon.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(no_telepon))
            {
                textUsername.Clear();
                textPw.Clear();
                textTelepon.Clear();
                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show($"Username tidak boleh kosong");
                    return;
                }
                else if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show($"Password tidak boleh kosong");
                    return;
                }
                else if (string.IsNullOrEmpty(no_telepon))
                {
                    MessageBox.Show($"Nomor Telepon tidak boleh kosong");
                    return;
                }
            }

            if (no_telepon.Length < 12)
            {
                textUsername.Clear();
                textPw.Clear();
                textTelepon.Clear();
                MessageBox.Show("Nomor telepon tidak sesuai ketentuan(12 nomor)", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            registerController daftarUser = new registerController();

            if (daftarUser.cekUser(username))
            {
                textUsername.Clear();
                textPw.Clear();
                textTelepon.Clear();
                MessageBox.Show("Username sudah digunakan, gunakan username lain!");
                return;
            }
            bool daftar = daftarUser.RegisterUser(username, password, no_telepon);

            if (daftar)
            {
                MessageBox.Show("Registrasi Berhasil", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var mainForm = this.Parent as panelBox;
                mainForm.loadControl(new UClogin());
            }
            else
            {
                MessageBox.Show("Registrasi gagal");
                textUsername.Clear();
                textPw.Clear();
                textTelepon.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var mainform = this.Parent as panelBox;
            mainform.loadControl(new UClogin());
        }

        private void UCregister_Load(object sender, EventArgs e)
        {

        }
    }
}
