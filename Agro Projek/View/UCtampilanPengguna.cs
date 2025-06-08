using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agro_Projek.Model;

namespace Agro_Projek.View
{
    public partial class UCtampilanPengguna : UserControl
    {
        Login login;
        UCkelolaPengguna uCkelolaPengguna;
        public UCtampilanPengguna(Login login, UCkelolaPengguna uCkelolaPengguna)
        {
            InitializeComponent();
            this.login = login;
            this.uCkelolaPengguna = uCkelolaPengguna;

            labelNama.Text = login.Username;
            labelHp.Text = login.no_telepon;
            labelId.Text = login.user_id.ToString();
        }

        private void tampilanPengguna_Load(object sender, EventArgs e)
        {

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            hapusUser hapusUser = new hapusUser(int.Parse(labelId.Text));
            hapusUser.ShowDialog();
        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            editUser editUser = new editUser(int.Parse(labelId.Text));
            editUser.ShowDialog();
        }
    }
}
