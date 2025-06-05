namespace Agro_Projek.View
{
    partial class UCproduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCproduk));
            buttonKeluar = new Button();
            buttonRiwayat = new Button();
            buttonPesanan = new Button();
            buttonProduk = new Button();
            buttonDB = new Button();
            SuspendLayout();
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = Color.Transparent;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.ForeColor = Color.White;
            buttonKeluar.Location = new Point(0, 702);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(276, 70);
            buttonKeluar.TabIndex = 9;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // buttonRiwayat
            // 
            buttonRiwayat.BackColor = Color.Transparent;
            buttonRiwayat.FlatAppearance.BorderSize = 0;
            buttonRiwayat.FlatStyle = FlatStyle.Flat;
            buttonRiwayat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRiwayat.ForeColor = Color.White;
            buttonRiwayat.Location = new Point(0, 611);
            buttonRiwayat.Name = "buttonRiwayat";
            buttonRiwayat.Size = new Size(276, 70);
            buttonRiwayat.TabIndex = 8;
            buttonRiwayat.Text = "Riwayat";
            buttonRiwayat.UseVisualStyleBackColor = false;
            buttonRiwayat.Click += buttonRiwayat_Click;
            // 
            // buttonPesanan
            // 
            buttonPesanan.BackColor = Color.Transparent;
            buttonPesanan.FlatAppearance.BorderSize = 0;
            buttonPesanan.FlatStyle = FlatStyle.Flat;
            buttonPesanan.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesanan.ForeColor = Color.White;
            buttonPesanan.Location = new Point(0, 519);
            buttonPesanan.Name = "buttonPesanan";
            buttonPesanan.Size = new Size(276, 70);
            buttonPesanan.TabIndex = 7;
            buttonPesanan.Text = "Pesanan";
            buttonPesanan.UseVisualStyleBackColor = false;
            buttonPesanan.Click += buttonPesanan_Click;
            // 
            // buttonProduk
            // 
            buttonProduk.BackColor = Color.Transparent;
            buttonProduk.FlatAppearance.BorderSize = 0;
            buttonProduk.FlatStyle = FlatStyle.Flat;
            buttonProduk.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProduk.ForeColor = Color.White;
            buttonProduk.Location = new Point(0, 429);
            buttonProduk.Name = "buttonProduk";
            buttonProduk.Size = new Size(276, 70);
            buttonProduk.TabIndex = 6;
            buttonProduk.Text = "Produk";
            buttonProduk.UseVisualStyleBackColor = false;
            buttonProduk.Click += buttonProduk_Click;
            // 
            // buttonDB
            // 
            buttonDB.BackColor = Color.Transparent;
            buttonDB.FlatAppearance.BorderSize = 0;
            buttonDB.FlatStyle = FlatStyle.Flat;
            buttonDB.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDB.ForeColor = Color.White;
            buttonDB.Location = new Point(0, 338);
            buttonDB.Name = "buttonDB";
            buttonDB.Size = new Size(276, 70);
            buttonDB.TabIndex = 5;
            buttonDB.Text = "Dashboard";
            buttonDB.UseVisualStyleBackColor = false;
            buttonDB.Click += buttonDB_Click;
            // 
            // UCproduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(buttonKeluar);
            Controls.Add(buttonRiwayat);
            Controls.Add(buttonPesanan);
            Controls.Add(buttonProduk);
            Controls.Add(buttonDB);
            Name = "UCproduk";
            Size = new Size(1440, 1024);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKeluar;
        private Button buttonRiwayat;
        private Button buttonPesanan;
        private Button buttonProduk;
        private Button buttonDB;
    }
}
