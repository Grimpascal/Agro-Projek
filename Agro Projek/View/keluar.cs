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
    public partial class keluar : Form
    {
        private panelBox panelBox;
        public keluar(panelBox form)
        {
            InitializeComponent();
            panelBox = form;
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainform = this.Parent as panelBox;
            mainform.loadControl(new UClogin());
        }

        private void keluar_Load(object sender, EventArgs e)
        {

        }
    }
}
