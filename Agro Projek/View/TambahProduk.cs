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
    public partial class TambahProduk : Form
    {
        public panelBox panelBox;
        public TambahProduk(panelBox form)
        {
            InitializeComponent();
            panelBox = form;
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadJenisProduk();
        }

        private void LoadJenisProduk()
        {
            comboBoxJenis.Items.Add("Sayur");
            comboBoxJenis.Items.Add("Buah");
        }

        private void TambahProduk_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaProduk = textNamaProduk.Text;

            if (!int.TryParse(textBoxHarga.Text, out int hargaProduk))
            {
                textBoxHarga.Clear();
                MessageBox.Show("Masukkan input yang benar untuk harga.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHarga.Focus();
                return;
            }

            if (hargaProduk < 0)
            {
                textBoxHarga.Clear();
                MessageBox.Show("Harga tidak boleh kurang dari 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxHarga.Focus();
                return;
            }

            if (!int.TryParse(textBoxStok.Text, out int quantityProduk))
            {
                textBoxStok.Clear();
                MessageBox.Show("Masukkan input yang benar untuk stok.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxStok.Focus();
                return;
            }

            if (quantityProduk < 0)
            {
                textBoxStok.Clear();
                MessageBox.Show("Stok tidak boleh kurang dari 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxStok.Focus();
                return;
            }

            int idJenisProduk = 0;
            if (comboBoxJenis.SelectedItem != null && comboBoxJenis.SelectedItem.ToString() == "Buah")
            {
                idJenisProduk = 1;
            }
            else if (comboBoxJenis.SelectedItem != null && comboBoxJenis.SelectedItem.ToString() == "Sayur")
            {
                idJenisProduk = 2;
            }

            ProdukController produkController = new ProdukController();
            if (produkController.cekNamaProduk(namaProduk))
            {
                textNamaProduk.Clear();
                textBoxHarga.Clear();
                textBoxStok.Clear();
                MessageBox.Show("Produk dengan nama tersebut sudah ada. Silakan gunakan nama lain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                produkController.tambah(namaProduk, idJenisProduk, hargaProduk, quantityProduk);
                MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ada kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        public void textNamaProduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TambahProduk_Load_1(object sender, EventArgs e)
        {

        }
    }
}
