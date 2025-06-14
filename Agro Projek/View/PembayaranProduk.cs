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
    public partial class PembayaranProduk : Form
    {
        string metodePembayaran;
        string namaBayar;
        int totalHarga;
        int produkId;
        int jumlah;
        int userId;
        public PembayaranProduk(string metodePembayaran, string namaBayar, int totalHarga, int produkId, int jumlah, int userId)
        {
            InitializeComponent();
            this.metodePembayaran = metodePembayaran;
            this.namaBayar = namaBayar;
            this.totalHarga = totalHarga;
            this.produkId = produkId;
            this.jumlah = jumlah;
            this.userId = userId;
            labelMetode.Text = $"Metode Pembayaran: {metodePembayaran}";
            labelNamaBayar.Text = $"Nama Pembayaran: {namaBayar}";
        }

        private void labelMetode_Click(object sender, EventArgs e)
        {

        }

        private void PembayaranProduk_Load(object sender, EventArgs e)
        {

        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            if (produkId > 0 && jumlah > 0 && totalHarga > 0)
            {
                try
                {
                    ProdukController produkController = new ProdukController();
                    produkController.riwayat(userId, produkId, jumlah, totalHarga);
                    produkController.kurangiStok(produkId, jumlah);
                    MessageBox.Show("Pembayaran berhasil dilakukan dan stok produk telah diperbarui.",
                                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat memproses pembayaran.\n\nDetail: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Data pembayaran tidak valid",
                                "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
