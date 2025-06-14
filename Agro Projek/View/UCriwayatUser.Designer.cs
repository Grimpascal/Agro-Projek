namespace Agro_Projek.View
{
    partial class UCriwayatUser
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
            labelProduk = new Label();
            labelJumlah = new Label();
            labelHarga = new Label();
            SuspendLayout();
            // 
            // labelProduk
            // 
            labelProduk.AutoSize = true;
            labelProduk.BackColor = Color.Transparent;
            labelProduk.Location = new Point(26, 26);
            labelProduk.Name = "labelProduk";
            labelProduk.Size = new Size(69, 25);
            labelProduk.TabIndex = 0;
            labelProduk.Text = "Produk";
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.BackColor = Color.Transparent;
            labelJumlah.Location = new Point(209, 26);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(67, 25);
            labelJumlah.TabIndex = 1;
            labelJumlah.Text = "Jumlah";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = Color.Transparent;
            labelHarga.Location = new Point(410, 26);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(57, 25);
            labelHarga.TabIndex = 2;
            labelHarga.Text = "harga";
            // 
            // UCriwayatUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelHarga);
            Controls.Add(labelJumlah);
            Controls.Add(labelProduk);
            Name = "UCriwayatUser";
            Size = new Size(527, 75);
            Load += UCriwayatUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelProduk;
        private Label labelJumlah;
        private Label labelHarga;
    }
}
