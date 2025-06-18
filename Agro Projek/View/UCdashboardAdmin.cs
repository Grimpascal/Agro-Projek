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
    public partial class UCdashboardAdmin : UserControl
    {
        private DashboardController dashboardController;
        public UCdashboardAdmin()
        {
            InitializeComponent();
            dashboardController = new DashboardController();
        }

        private void buttonDBadmin_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCdashboardAdmin());
        }

        private void buttonKproduk_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCkelolaProduk());
        }

        private void buttonKstok_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCkelolaStok());
        }

        private void buttonKpengguna_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCkelolaPengguna());
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            keluar keluar = new keluar(this.Parent as panelBox);
            keluar.ShowDialog();
        }

        private void UCdashboardAdmin_Load(object sender, EventArgs e)
        {
            int totalProduk = dashboardController.produkTotal();
            labelProduk.Text = totalProduk.ToString();

            int totalPengguna = dashboardController.penggunaTotal();
            labelPengguna.Text = totalPengguna.ToString();
        }

        private void labelProduk_Click(object sender, EventArgs e)
        {

        }
    }
}
