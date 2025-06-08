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
    public partial class TambahPengguna : Form
    {
        public TambahPengguna()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxPassword.Text;
            string nomor = textBoxHp.Text;
            PenggunaController penggunaController = new PenggunaController();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(nomor))
            {
                MessageBox.Show("Semua field harus diisi.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (nomor.Length < 12 || nomor.Length > 13)
            {
                MessageBox.Show("Nomor telepon harus 12 nomor", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password tidak boleh kosong.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                penggunaController.tambah(username, password, nomor);
                MessageBox.Show("Pengguna berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void buttonbalek_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TambahPengguna_Load(object sender, EventArgs e)
        {

        }
    }
}
