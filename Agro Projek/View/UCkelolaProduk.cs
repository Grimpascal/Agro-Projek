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
    public partial class UCkelolaProduk : UserControl
    {
        public UCkelolaProduk()
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

        private void buttonTambahProduk_Click(object sender, EventArgs e)
        {
            TambahProduk addProduk = new TambahProduk(this.Parent as panelBox);
            addProduk.ShowDialog();
        }

        private void UCkelolaProduk_Load(object sender, EventArgs e)
        {
            loadMenu();
        }

        public void loadMenu()
        {
            flowListMakanan.Controls.Clear();
            var list_makanan = ProdukController.TampilanProduk();
            foreach (var produkk in list_makanan)
            {
                UCtampilanProduk tampilanProduk = new UCtampilanProduk(produkk, this);
                flowListMakanan.Controls.Add(new UCtampilanProduk(produkk, this));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowListMakanan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
