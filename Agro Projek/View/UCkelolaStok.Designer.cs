﻿namespace Agro_Projek.View
{
    partial class UCkelolaStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCkelolaStok));
            buttonKeluar = new Button();
            buttonKpengguna = new Button();
            buttonKstok = new Button();
            buttonKproduk = new Button();
            buttonDBadmin = new Button();
            flowStok = new FlowLayoutPanel();
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
            buttonKeluar.Size = new Size(251, 45);
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
            // flowStok
            // 
            flowStok.AutoScroll = true;
            flowStok.BackColor = Color.Transparent;
            flowStok.Location = new Point(330, 226);
            flowStok.Name = "flowStok";
            flowStok.Size = new Size(1110, 611);
            flowStok.TabIndex = 10;
            flowStok.Paint += flowUser_Paint;
            // 
            // UCkelolaStok
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(flowStok);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonKpengguna);
            Controls.Add(buttonKstok);
            Controls.Add(buttonKproduk);
            Controls.Add(buttonDBadmin);
            Name = "UCkelolaStok";
            Size = new Size(1440, 1024);
            Load += UCkelolaStok_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonKeluar;
        private Button buttonKpengguna;
        private Button buttonKstok;
        private Button buttonKproduk;
        private Button buttonDBadmin;
        private FlowLayoutPanel flowStok;
    }
}
