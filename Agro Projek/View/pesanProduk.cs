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
    public partial class pesanProduk : Form
    {
        public int userId;
        public Produk produk;
        Login login;
        public pesanProduk(Produk produk)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userId = userId;
            this.produk = produk;
            labelNamaProduk.Text = produk.nama_produk;
            comboBox1.Items.Add("COD");
            comboBox1.Items.Add("Diantar");
        }

        private void pesanProduk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            int jumlah;
            if (int.TryParse(textBoxJumlah.Text, out jumlah))
            {
                int totalHarga = produk.harga * jumlah;
                string alamat = textBoxAlamat.Text;
                string pengiriman = comboBox1.SelectedItem?.ToString();
                Transaksi transaksiForm = new Transaksi(produk, jumlah, totalHarga, alamat, pengiriman);
                transaksiForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Masukkan jumlah yang valid.");
            }
        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNamaProduk_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
