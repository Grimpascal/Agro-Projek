namespace Agro_Projek.View
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            labelNama = new Label();
            label1 = new Label();
            labelHarga = new Label();
            labelJumlah = new Label();
            labelTotal = new Label();
            buttonPesan = new Button();
            buttonBatal = new Button();
            labelPengiriman = new Label();
            labelAlamat = new Label();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(410, 280);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(79, 32);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 209);
            label1.Name = "label1";
            label1.Size = new Size(407, 60);
            label1.TabIndex = 1;
            label1.Text = "Informasi Pesanan";
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = Color.Transparent;
            labelHarga.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHarga.Location = new Point(410, 325);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(81, 32);
            labelHarga.TabIndex = 2;
            labelHarga.Text = "Harga";
            // 
            // labelJumlah
            // 
            labelJumlah.AutoSize = true;
            labelJumlah.BackColor = Color.Transparent;
            labelJumlah.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelJumlah.Location = new Point(410, 376);
            labelJumlah.Name = "labelJumlah";
            labelJumlah.Size = new Size(92, 32);
            labelJumlah.TabIndex = 3;
            labelJumlah.Text = "Jumlah";
            labelJumlah.Click += labelJumlah_Click;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.BackColor = Color.Transparent;
            labelTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(410, 520);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(67, 32);
            labelTotal.TabIndex = 4;
            labelTotal.Text = "Total";
            labelTotal.Click += labelTotal_Click;
            // 
            // buttonPesan
            // 
            buttonPesan.BackColor = Color.FromArgb(0, 192, 0);
            buttonPesan.FlatAppearance.BorderSize = 0;
            buttonPesan.FlatStyle = FlatStyle.Flat;
            buttonPesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesan.ForeColor = SystemColors.ControlLightLight;
            buttonPesan.Location = new Point(410, 569);
            buttonPesan.Name = "buttonPesan";
            buttonPesan.Size = new Size(112, 34);
            buttonPesan.TabIndex = 5;
            buttonPesan.Text = "Pesan";
            buttonPesan.UseVisualStyleBackColor = false;
            buttonPesan.Click += buttonPesan_Click;
            // 
            // buttonBatal
            // 
            buttonBatal.BackColor = Color.Red;
            buttonBatal.FlatAppearance.BorderSize = 0;
            buttonBatal.FlatStyle = FlatStyle.Flat;
            buttonBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBatal.ForeColor = SystemColors.ControlLightLight;
            buttonBatal.Location = new Point(121, 763);
            buttonBatal.Name = "buttonBatal";
            buttonBatal.Size = new Size(112, 34);
            buttonBatal.TabIndex = 6;
            buttonBatal.Text = "Keluar";
            buttonBatal.UseVisualStyleBackColor = false;
            buttonBatal.Click += buttonBatal_Click;
            // 
            // labelPengiriman
            // 
            labelPengiriman.AutoSize = true;
            labelPengiriman.BackColor = Color.Transparent;
            labelPengiriman.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPengiriman.Location = new Point(410, 423);
            labelPengiriman.Name = "labelPengiriman";
            labelPengiriman.Size = new Size(137, 32);
            labelPengiriman.TabIndex = 7;
            labelPengiriman.Text = "Pengiriman";
            labelPengiriman.Click += labelPengiriman_Click;
            // 
            // labelAlamat
            // 
            labelAlamat.AutoSize = true;
            labelAlamat.BackColor = Color.Transparent;
            labelAlamat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAlamat.Location = new Point(410, 471);
            labelAlamat.Name = "labelAlamat";
            labelAlamat.Size = new Size(92, 32);
            labelAlamat.TabIndex = 8;
            labelAlamat.Text = "Alamat";
            labelAlamat.Click += labelAlamat_Click;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1418, 968);
            Controls.Add(labelAlamat);
            Controls.Add(labelPengiriman);
            Controls.Add(buttonBatal);
            Controls.Add(buttonPesan);
            Controls.Add(labelTotal);
            Controls.Add(labelJumlah);
            Controls.Add(labelHarga);
            Controls.Add(label1);
            Controls.Add(labelNama);
            Name = "Transaksi";
            Text = "Transaksi";
            Load += Transaksi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label label1;
        private Label labelHarga;
        private Label labelJumlah;
        private Label labelTotal;
        private Button buttonPesan;
        private Button buttonBatal;
        private Label labelPengiriman;
        private Label labelAlamat;
    }
}