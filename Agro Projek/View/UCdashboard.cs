using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agro_Projek.View
{
    public partial class UCdashboard : UserControl
    {
        public UCdashboard()
        {
            InitializeComponent();
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCdashboard());
            this.Hide();
        }

        private void buttonProduk_Click(object sender, EventArgs e)
        {
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UCproduk());
            this.Hide();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            keluar keluar = new keluar();
            keluar.StartPosition = FormStartPosition.CenterScreen;
            keluar.Show();
        }
    }
}
