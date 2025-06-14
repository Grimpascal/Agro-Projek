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
    public partial class Pembayaran : Form
    {
        int totalHarga;
        int produkId;
        int jumlah;
        int userId;
        public Pembayaran(int totalHarga, int produkId, int jumlah, int userId)
        {
            InitializeComponent();
            this.totalHarga = totalHarga;
            this.produkId = produkId;
            this.jumlah = jumlah;
            this.userId = userId;

            comboBoxMetode.Items.Add("Transfer Bank");
            comboBoxMetode.Items.Add("Cash");
            comboBoxBayar.Items.Add("Tunai");
            comboBoxBayar.Items.Add("bank BRI");
            comboBoxBayar.Items.Add("bank BCA");
            comboBoxBayar.Items.Add("bank Mandiri");
            comboBoxBayar.Items.Add("bank BNI");
            comboBoxBayar.Enabled = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void Pembayaran_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxBayar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMetode_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxBayar.Items.Clear();
            if (comboBoxMetode.SelectedItem.ToString() == "Cash")
            {
                comboBoxBayar.Items.Add("Tunai");
            }
            else if (comboBoxMetode.SelectedItem.ToString() == "Transfer Bank")
            {
                comboBoxBayar.Items.Add("bank BRI");
                comboBoxBayar.Items.Add("bank BCA");
                comboBoxBayar.Items.Add("bank Mandiri");
                comboBoxBayar.Items.Add("bank BNI");
            }
            comboBoxBayar.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesan_Click(object sender, EventArgs e)
        {
            string metodePembayaran = comboBoxMetode.SelectedItem?.ToString();
            string namaBayar = comboBoxBayar.SelectedItem?.ToString();
            PembayaranProduk pembayaranProduk = new PembayaranProduk(metodePembayaran, namaBayar, totalHarga, produkId, jumlah, userId);
            if (string.IsNullOrEmpty(metodePembayaran) || string.IsNullOrEmpty(namaBayar))
            {
                MessageBox.Show("Pilih metode pembayaran dan pilihan bank terlebih dahulu.");
                return;
            }
            pembayaranProduk.ShowDialog();
            this.Close();
        }
    }
}
