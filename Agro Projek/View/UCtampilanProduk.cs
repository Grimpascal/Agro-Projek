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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Agro_Projek.View
{
    public partial class UCtampilanProduk : UserControl,IManage.ILoad
    {
        private Produk produk;
        UCkelolaProduk parentProduk;

        public UCtampilanProduk(Produk produk, UCkelolaProduk parentProduk)
        {
            InitializeComponent();
            this.produk = produk;
            this.parentProduk = parentProduk;
            string harga = produk.harga.ToString();
            LoadData();
        }

        public void LoadData()
        {
            labelNama.Text = produk.nama_produk;
            labelHarga.Text = $"Rp. {produk.harga}/Kg";
        }

        public UCtampilanProduk(Produk produk, UCproduk uCproduk)
        {
            this.produk = produk;
        }

        private void tampilanProduk_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureProduk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
