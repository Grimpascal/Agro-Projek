using Agro_Projek.View;

namespace Agro_Projek
{
    public partial class panelBox : Form
    {
        public panelBox()
        {
            InitializeComponent();
            loadControl(new UClogin());
        }

        public void loadControl(UserControl uc)
        {
            this.Controls.Clear();
            uc.Dock = DockStyle.None;
            uc.Anchor = AnchorStyles.None;
            this.Controls.Add(uc);
        }

        private void panelBox_Load(object sender, EventArgs e)
        {

        }
    }
}