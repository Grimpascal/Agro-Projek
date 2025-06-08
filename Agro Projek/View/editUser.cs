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
    public partial class editUser : Form
    {
        private int userId;
        public editUser(int userId)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            PenggunaController penggunaController = new PenggunaController();
            string username = textBoxUsername.Text;
            string noTelepon = textBoxHp.Text;
            string password = textBoxPassword.Text;
            try
            {
                penggunaController.editPengguna(this.userId,username, password, noTelepon);
                MessageBox.Show("Pengguna berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada error yang ditemukan : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
