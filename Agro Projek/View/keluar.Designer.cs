namespace Agro_Projek.View
{
    partial class keluar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(keluar));
            buttonKembali = new Button();
            buttonKeluar = new Button();
            SuspendLayout();
            // 
            // buttonKembali
            // 
            buttonKembali.BackColor = Color.Transparent;
            buttonKembali.FlatAppearance.BorderSize = 0;
            buttonKembali.FlatStyle = FlatStyle.Flat;
            buttonKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKembali.ForeColor = Color.WhiteSmoke;
            buttonKembali.Location = new Point(231, 220);
            buttonKembali.Name = "buttonKembali";
            buttonKembali.Size = new Size(141, 40);
            buttonKembali.TabIndex = 0;
            buttonKembali.Text = "Kembali";
            buttonKembali.UseVisualStyleBackColor = false;
            buttonKembali.Click += buttonKembali_Click;
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = Color.Transparent;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.ForeColor = Color.WhiteSmoke;
            buttonKeluar.Location = new Point(231, 292);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(141, 40);
            buttonKeluar.TabIndex = 1;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // keluar
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(600, 385);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonKembali);
            FormBorderStyle = FormBorderStyle.None;
            Name = "keluar";
            Text = "keluar";
            Load += keluar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKembali;
        private Button buttonKeluar;
    }
}