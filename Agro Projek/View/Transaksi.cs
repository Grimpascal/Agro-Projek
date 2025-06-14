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
        int userId;
        public Transaksi(Produk produk, int jumlah, int totalHarga, string alamat, string pengiriman, int userId)
        {
            InitializeComponent();
            labelNama.Text = $"Nama Produk : " + produk.nama_produk;
            labelHarga.Text = $"Harga Produk : " + produk.harga.ToString();
            labelJumlah.Text = $"Jumlah : " + jumlah.ToString();
            labelTotal.Text = $"Total Harga : " + totalHarga.ToString();
            labelAlamat.Text = $"Alamat: {alamat}";
            labelPengiriman.Text = $"Pengiriman: {pengiriman}";
            this.produk = produk;
            this.pengiriman = pengiriman;
            this.alamat = alamat;
            this.jumlah = jumlah;
            this.userId = userId;
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

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            int totalHarga = produk.harga * jumlah;
            int produkId = produk.id_produk;
            Pembayaran pembayaranForm = new Pembayaran(totalHarga, produkId, jumlah, userId);
            pembayaranForm.ShowDialog();
            this.Close();
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
