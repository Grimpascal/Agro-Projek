namespace Agro_Projek.View
{
    partial class UCkelolaProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCkelolaProduk));
            buttonKeluar = new Button();
            buttonKpengguna = new Button();
            buttonKstok = new Button();
            buttonKproduk = new Button();
            buttonDBadmin = new Button();
            buttonTambahProduk = new Button();
            SuspendLayout();
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = Color.Transparent;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.ForeColor = SystemColors.Control;
            buttonKeluar.Location = new Point(0, 532);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(251, 44);
            buttonKeluar.TabIndex = 9;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
            // 
            // buttonKpengguna
            // 
            buttonKpengguna.BackColor = Color.Transparent;
            buttonKpengguna.FlatAppearance.BorderSize = 0;
            buttonKpengguna.FlatStyle = FlatStyle.Flat;
            buttonKpengguna.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKpengguna.ForeColor = SystemColors.Control;
            buttonKpengguna.Location = new Point(0, 475);
            buttonKpengguna.Name = "buttonKpengguna";
            buttonKpengguna.Size = new Size(251, 42);
            buttonKpengguna.TabIndex = 8;
            buttonKpengguna.Text = "Kelola Pengguna";
            buttonKpengguna.UseVisualStyleBackColor = false;
            buttonKpengguna.Click += buttonKpengguna_Click;
            // 
            // buttonKstok
            // 
            buttonKstok.BackColor = Color.Transparent;
            buttonKstok.FlatAppearance.BorderSize = 0;
            buttonKstok.FlatStyle = FlatStyle.Flat;
            buttonKstok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKstok.ForeColor = SystemColors.Control;
            buttonKstok.Location = new Point(0, 417);
            buttonKstok.Name = "buttonKstok";
            buttonKstok.Size = new Size(251, 42);
            buttonKstok.TabIndex = 7;
            buttonKstok.Text = "Kelola Stok";
            buttonKstok.UseVisualStyleBackColor = false;
            buttonKstok.Click += buttonKstok_Click;
            // 
            // buttonKproduk
            // 
            buttonKproduk.BackColor = Color.Transparent;
            buttonKproduk.FlatAppearance.BorderSize = 0;
            buttonKproduk.FlatStyle = FlatStyle.Flat;
            buttonKproduk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKproduk.ForeColor = SystemColors.Control;
            buttonKproduk.Location = new Point(0, 358);
            buttonKproduk.Name = "buttonKproduk";
            buttonKproduk.Size = new Size(251, 42);
            buttonKproduk.TabIndex = 6;
            buttonKproduk.Text = "Kelola Produk";
            buttonKproduk.UseVisualStyleBackColor = false;
            buttonKproduk.Click += buttonKproduk_Click;
            // 
            // buttonDBadmin
            // 
            buttonDBadmin.BackColor = Color.Transparent;
            buttonDBadmin.FlatAppearance.BorderSize = 0;
            buttonDBadmin.FlatStyle = FlatStyle.Flat;
            buttonDBadmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDBadmin.ForeColor = SystemColors.Control;
            buttonDBadmin.Location = new Point(0, 297);
            buttonDBadmin.Name = "buttonDBadmin";
            buttonDBadmin.Size = new Size(251, 45);
            buttonDBadmin.TabIndex = 5;
            buttonDBadmin.Text = "Dashboard";
            buttonDBadmin.UseVisualStyleBackColor = false;
            buttonDBadmin.Click += buttonDBadmin_Click;
            // 
            // buttonTambahProduk
            // 
            buttonTambahProduk.BackColor = Color.Transparent;
            buttonTambahProduk.BackgroundImage = (Image)resources.GetObject("buttonTambahProduk.BackgroundImage");
            buttonTambahProduk.FlatStyle = FlatStyle.Flat;
            buttonTambahProduk.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambahProduk.ForeColor = SystemColors.Control;
            buttonTambahProduk.Location = new Point(1174, 102);
            buttonTambahProduk.Name = "buttonTambahProduk";
            buttonTambahProduk.Size = new Size(220, 65);
            buttonTambahProduk.TabIndex = 10;
            buttonTambahProduk.Text = "Tambah Produk";
            buttonTambahProduk.UseVisualStyleBackColor = false;
            buttonTambahProduk.Click += buttonTambahProduk_Click;
            // 
            // UCkelolaProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(buttonTambahProduk);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonKpengguna);
            Controls.Add(buttonKstok);
            Controls.Add(buttonKproduk);
            Controls.Add(buttonDBadmin);
            Name = "UCkelolaProduk";
            Size = new Size(1440, 1024);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKeluar;
        private Button buttonKpengguna;
        private Button buttonKstok;
        private Button buttonKproduk;
        private Button buttonDBadmin;
        private Button buttonTambahProduk;
    }
}
