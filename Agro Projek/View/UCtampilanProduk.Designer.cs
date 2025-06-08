namespace Agro_Projek.View
{
    partial class UCtampilanProduk
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNama = new Label();
            labelHarga = new Label();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(56, 28);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(68, 28);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = Color.Transparent;
            labelHarga.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHarga.Location = new Point(322, 28);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(69, 28);
            labelHarga.TabIndex = 1;
            labelHarga.Text = "Harga";
            // 
            // UCtampilanProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            Controls.Add(labelHarga);
            Controls.Add(labelNama);
            Name = "UCtampilanProduk";
            Size = new Size(1609, 797);
            Load += tampilanProduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelHarga;
    }
}
