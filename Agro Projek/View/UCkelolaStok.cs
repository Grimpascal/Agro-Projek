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
    public partial class UCkelolaStok : UserControl
    {
        ProdukController produkController;
        public UCkelolaStok()
        {
            InitializeComponent();
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

        private void flowUser_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadMenu()
        {
            flowStok.Controls.Clear();
            var list_produk = ProdukController.ambilProduk();
            foreach (var produk in list_produk)
            {
                UCcontainerProduk uCcontainerProduk = new UCcontainerProduk(produk, this);
                flowStok.Controls.Add(uCcontainerProduk);

            }
        }

        private void UCkelolaStok_Load(object sender, EventArgs e)
        {
            loadMenu();
        }
    }
}
