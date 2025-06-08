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
    public partial class UCkelolaPengguna : UserControl
    {
        public UCkelolaPengguna()
        {
            InitializeComponent();
        }

        private void buttonDBadmin_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCdashboardAdmin());
        }

        private void buttonKproduk_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCkelolaProduk());
        }

        private void buttonKstok_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCkelolaStok());
        }

        private void buttonKpengguna_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCkelolaPengguna());
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            keluar keluar = new keluar(this.Parent as panelBox);
            keluar.ShowDialog();
        }

        private void flowPengguna_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadMenu()
        {
            flowPengguna.Controls.Clear();
            var list_pengguna = PenggunaController.tampilPengguna();
            foreach (var pengguna in list_pengguna)
            {
                UCtampilanPengguna ucPengguna = new UCtampilanPengguna(pengguna, this);
                flowPengguna.Controls.Add(ucPengguna);
            }
        }

        private void UCkelolaPengguna_Load(object sender, EventArgs e)
        {
            loadMenu();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            TambahPengguna tambahPengguna = new TambahPengguna();
            tambahPengguna.ShowDialog();
        }
    }
}
