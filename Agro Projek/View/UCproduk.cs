﻿using System;
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
    public partial class UCproduk : UserControl
    {
        ProdukController ProdukController;
        public UCproduk()
        {
            InitializeComponent();
            this.ProdukController = new ProdukController();
        }

        private void buttonProduk_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCproduk());
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            keluar keluar = new keluar(this.Parent as panelBox);
            keluar.ShowDialog();
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCriwayat());
            this.Hide();
        }

        private void UCproduk_Load(object sender, EventArgs e)
        {
            loadMenu();
        }

        public void loadMenu()
        {
            flowProdukUser.Controls.Clear();
            var list_produk = ProdukController.ambilProduk();
            foreach (var produk in list_produk)
            {
                UCprodukuser uCprodukuser = new UCprodukuser(produk, this);
                flowProdukUser.Controls.Add(uCprodukuser);
                uCprodukuser.LoadData();
            }
        }

        private void flowProdukUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
