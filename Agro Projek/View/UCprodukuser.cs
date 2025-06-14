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
    public partial class UCprodukuser : UserControl
    {
        Produk produk;
        UCproduk UCproduk;
        pesanProduk pesanProduk;
        Transaksi transaksi;
        public UCprodukuser(Produk produk, UCproduk uCproduk)
        {
            InitializeComponent();
            this.produk = produk;
            this.UCproduk = uCproduk;
            labelNama.Text = produk.nama_produk;
            labelHarga.Text = produk.harga.ToString();
            labelStok.Text = produk.quantity.ToString();
            labelIdProduk.Text = produk.id_produk.ToString();
        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void UCprodukuser_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            if (produk.quantity <= 0)
            {
                MessageBox.Show("Maaf, stok produk habis. Tidak dapat memesan saat ini.",
                                "Stok Kosong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            pesanProduk pesanProduk = new pesanProduk(this.produk, 1);
            pesanProduk.ShowDialog();
        }

    }
}
