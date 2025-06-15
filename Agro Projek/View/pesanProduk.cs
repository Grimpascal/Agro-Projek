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
        public pesanProduk(Produk produk, int jumlah)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userId = userId;
            this.produk = produk;
            labelNamaProduk.Text = produk.nama_produk;

            comboBox1.Items.Add("Ambil Ditempat");
            comboBox1.Items.Add("Diantar");
        }

        private void pesanProduk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  // This will close the form when the custom button is clicked
        }

        private void pesanProduk_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Optional: Show confirmation message before closing
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Confirm Close", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close operation
            }
        }


        public int jumlah;
        private void buttonPesan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxJumlah.Text, out jumlah))
            {
                if (jumlah < 1)
                {
                    MessageBox.Show("Jumlah harus lebih besar dari 0.");
                    return;
                }

                // Check if the user selects 'Diantar' and the address is empty
                if (comboBox1.SelectedItem.ToString() == "Diantar" && string.IsNullOrWhiteSpace(textBoxAlamat.Text))
                {
                    MessageBox.Show("Alamat harus diisi jika pengiriman menggunakan 'Diantar'.");
                    return;  // Stop further processing if address is empty
                }

                int stokTersedia = new ProdukController().cekStokProduk(produk.id_produk);
                if (jumlah > stokTersedia)
                {
                    MessageBox.Show($"Stok tidak mencukupi. Stok tersedia: {stokTersedia}");
                    return;
                }

                int totalHarga = produk.harga * jumlah;
                string alamat = textBoxAlamat.Text;
                string pengiriman = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(pengiriman))
                {
                    MessageBox.Show("Pilih metode pengiriman terlebih dahulu.");
                    return;
                }

                int userId = LoginController.LoggedInUserId;
                Transaksi transaksiForm = new Transaksi(produk, jumlah, totalHarga, alamat, pengiriman, userId);

                // Do not call kurangiStok here. It will be done in the PembayaranProduk form after successful payment.

                transaksiForm.ShowDialog();
                this.Close();
            }
            else if (string.IsNullOrWhiteSpace(textBoxJumlah.Text))
            {
                MessageBox.Show("Jumlah tidak boleh kosong.");
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
            if (comboBox1.SelectedItem == "Ambil Ditempat")
            {
                textBoxAlamat.Enabled = false;
                textBoxAlamat.Clear();
            }
            else if (comboBox1.SelectedItem == "Diantar")
            {
                textBoxAlamat.Enabled = true;
            }
        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void pesanProduk_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();  
        }

    }
}
