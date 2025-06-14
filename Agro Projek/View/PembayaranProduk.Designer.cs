namespace Agro_Projek.View
{
    partial class PembayaranProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembayaranProduk));
            labelMetode = new Label();
            labelNamaBayar = new Label();
            buttonBayar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelMetode
            // 
            labelMetode.AutoSize = true;
            labelMetode.BackColor = Color.Transparent;
            labelMetode.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMetode.Location = new Point(403, 229);
            labelMetode.Name = "labelMetode";
            labelMetode.Size = new Size(83, 28);
            labelMetode.TabIndex = 0;
            labelMetode.Text = "Metode";
            labelMetode.Click += labelMetode_Click;
            // 
            // labelNamaBayar
            // 
            labelNamaBayar.AutoSize = true;
            labelNamaBayar.BackColor = Color.Transparent;
            labelNamaBayar.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaBayar.Location = new Point(403, 267);
            labelNamaBayar.Name = "labelNamaBayar";
            labelNamaBayar.Size = new Size(65, 28);
            labelNamaBayar.TabIndex = 1;
            labelNamaBayar.Text = "Nama";
            // 
            // buttonBayar
            // 
            buttonBayar.BackColor = Color.Red;
            buttonBayar.Location = new Point(403, 365);
            buttonBayar.Name = "buttonBayar";
            buttonBayar.Size = new Size(112, 34);
            buttonBayar.TabIndex = 2;
            buttonBayar.Text = "Bayar";
            buttonBayar.UseVisualStyleBackColor = false;
            buttonBayar.Click += buttonBayar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 312);
            label1.Name = "label1";
            label1.Size = new Size(325, 28);
            label1.TabIndex = 3;
            label1.Text = "Nomor Rekening : 6214352878392";
            // 
            // PembayaranProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 968);
            Controls.Add(label1);
            Controls.Add(buttonBayar);
            Controls.Add(labelNamaBayar);
            Controls.Add(labelMetode);
            Name = "PembayaranProduk";
            Text = "PembayaranProduk";
            Load += PembayaranProduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMetode;
        private Label labelNamaBayar;
        private Button buttonBayar;
        private Label label1;
    }
}