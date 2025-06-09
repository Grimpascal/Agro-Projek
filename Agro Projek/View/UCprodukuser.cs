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
        public UCprodukuser(Produk produk, UCproduk uCproduk)
        {
            InitializeComponent();
            this.produk = produk;
            this.UCproduk = uCproduk;
            labelNama.Text = produk.nama_produk;
            labelHarga.Text = produk.harga.ToString();
            labelStok.Text = produk.quantity.ToString();
        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }
    }
}
