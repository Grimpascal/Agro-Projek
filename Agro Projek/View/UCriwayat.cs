using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro_Projek.View
{
    public partial class UCriwayat : UserControl
    {
        public UCriwayat()
        {
            InitializeComponent();
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCdashboard());
            this.Hide();
        }

        private void buttonProduk_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCproduk());
            this.Hide();
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCpesanan());
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
    }
}
