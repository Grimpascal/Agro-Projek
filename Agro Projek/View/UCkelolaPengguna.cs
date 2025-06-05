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
            var mainForm = this.Parent as panelBox;
            mainForm.loadControl(new UClogin());
        }
    }
}
