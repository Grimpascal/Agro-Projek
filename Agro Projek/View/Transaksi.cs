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
    public partial class Transaksi : Form
    {
        Produk produk;
        public int jumlah;
        public string alamat;
        public string pengiriman;
        public Transaksi(Produk produk, int jumlah, int totalHarga, string alamat, string pengiriman)
        {
            InitializeComponent();
            this.produk = produk;
            labelNama.Text = $"Nama Produk : " + produk.nama_produk;
            labelHarga.Text = $"Jumlah Produk : " + produk.harga.ToString();
            labelJumlah.Text = $"Jumlah : " + jumlah.ToString();
            labelTotal.Text = $"Total Harga : " + totalHarga.ToString();
            this.alamat = alamat;
            this.pengiriman = pengiriman;
            labelAlamat.Text = $"Alamat: {alamat}";
            labelPengiriman.Text = $"Pengiriman: {pengiriman}";
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void labelAlamat_Click(object sender, EventArgs e)
        {

        }

        private void labelPengiriman_Click(object sender, EventArgs e)
        {

        }

        private void labelJumlah_Click(object sender, EventArgs e)
        {

        }
    }
}
