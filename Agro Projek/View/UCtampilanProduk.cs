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
    public partial class UCtampilanProduk : UserControl
    {
        Produk produk;
        UCkelolaProduk parentMenu;

        private PictureBox pictureBoxGambar;

        public UCtampilanProduk(Produk produk, UCkelolaProduk parentMenu)
        {
            InitializeComponent();
            this.produk = produk;
            this.parentMenu = parentMenu;
            using (MemoryStream ms = new MemoryStream(produk.gambar_produk))
            {
                pictureBoxGambar.BackgroundImage = Image.FromStream(ms);
            }

            labelNama.Text = produk.nama_produk;
            labelHarga.Text = "Rp. " + produk.harga.ToString();

            if (produk.gambar_produk != null)
            {
                using (MemoryStream ms = new MemoryStream(produk.gambar_produk))
                {
                    pictureBoxGambar.Image = Image.FromStream(ms);
                }
            }
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
