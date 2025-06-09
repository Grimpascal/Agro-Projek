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
        public pesanProduk()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userId = userId;
            this.produk = produk;
        }

        private void pesanProduk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKeranjang_Click(object sender, EventArgs e)
        {
            ProdukController produkController = new ProdukController();
            int idProduk = produk.id_produk; 
            int jumlah = Convert.ToInt32(textBoxJumlah.Text);
            if (jumlah <= 0)
            {
                MessageBox.Show("Jumlah harus lebih dari 0");
                return;
            } else if (jumlah > produk.quantity)
            {
                MessageBox.Show("Jumlah melebihi stok yang tersedia");
                return;
            }
            produkController.keranjang(userId,idProduk,jumlah);

        }
    }
}
