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
    public partial class UCriwayat : UserControl
    {
        Riwayat Riwayat;
        public UCriwayat()
        {
            InitializeComponent();
            loadMenu();
        }

        private void buttonProduk_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCproduk());
            this.Hide();
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCriwayat());
            this.Hide();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            keluar keluar = new keluar(this.Parent as panelBox);
            keluar.ShowDialog();
        }

        private void UCriwayat_Load(object sender, EventArgs e)
        {

        }

        private void flowRiwayat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadMenu()
        {
            flowRiwayat.Controls.Clear();
            int userId = LoginController.LoggedInUserId;
            var list_riwayat = ProdukController.cekRiwayat(userId);
            foreach (var riwayat in list_riwayat)
            {
                UCriwayatUser uCriwayatuser = new UCriwayatUser(riwayat);
                flowRiwayat.Controls.Add(uCriwayatuser);
            }
        }

    }
}
