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
    public partial class UCcontainerProduk : UserControl
    {
        private int userId;
        Produk produk;
        UCkelolaStok UCkelolaStok;
        public UCcontainerProduk(Produk produk, UCkelolaStok uCkelolaStok)
        {
            InitializeComponent();
            this.produk = produk;
            this.UCkelolaStok = uCkelolaStok;
            labelNama.Text = produk.nama_produk;
            labelHarga.Text = produk.harga.ToString();
            labelStok.Text = produk.quantity.ToString();
            labelid.Text = produk.id_produk.ToString();
        }

        private void UCcontainerProduk_Load(object sender, EventArgs e)
        {
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            ProdukController produkController = new ProdukController();
            produkController.tambahStok(int.Parse(labelid.Text));
            produk.quantity += 1;
        }
    }
}
