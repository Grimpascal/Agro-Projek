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
    public partial class UCriwayatUser : UserControl,IManage.ILoad
    {
        private Riwayat riwayat;
        UCriwayat uCriwayat;

        public UCriwayatUser(Riwayat riwayat)
        {
            InitializeComponent();
            this.riwayat = riwayat;
            LoadData();
        }

        public void LoadData()
        {
            labelProduk.Text = riwayat.nama_produk;
            labelJumlah.Text = riwayat.jumlah.ToString();
            labelHarga.Text = riwayat.total_harga.ToString();
        }

        private void UCriwayatUser_Load(object sender, EventArgs e)
        {

        }
    }
}
