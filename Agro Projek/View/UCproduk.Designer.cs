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
            buttonProduk = new Button();
            flowProdukUser = new FlowLayoutPanel();
            buttonRiwayat = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonKeluar
            // 
            buttonKeluar.BackColor = Color.Transparent;
            buttonKeluar.FlatAppearance.BorderSize = 0;
            buttonKeluar.FlatStyle = FlatStyle.Flat;
            buttonKeluar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonKeluar.ForeColor = Color.White;
            buttonKeluar.Location = new Point(0, 602);
            buttonKeluar.Name = "buttonKeluar";
            buttonKeluar.Size = new Size(276, 70);
            buttonKeluar.TabIndex = 9;
            buttonKeluar.Text = "Keluar";
            buttonKeluar.UseVisualStyleBackColor = false;
            buttonKeluar.Click += buttonKeluar_Click;
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
            // flowProdukUser
            // 
            flowProdukUser.AutoScroll = true;
            flowProdukUser.BackColor = Color.Transparent;
            flowProdukUser.Location = new Point(324, 92);
            flowProdukUser.Name = "flowProdukUser";
            flowProdukUser.Size = new Size(1072, 651);
            flowProdukUser.TabIndex = 10;
            flowProdukUser.Paint += flowProdukUser_Paint;
            // 
            // buttonRiwayat
            // 
            buttonRiwayat.BackColor = Color.Transparent;
            buttonRiwayat.FlatAppearance.BorderSize = 0;
            buttonRiwayat.FlatStyle = FlatStyle.Flat;
            buttonRiwayat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRiwayat.ForeColor = Color.White;
            buttonRiwayat.Location = new Point(0, 511);
            buttonRiwayat.Name = "buttonRiwayat";
            buttonRiwayat.Size = new Size(276, 70);
            buttonRiwayat.TabIndex = 8;
            buttonRiwayat.Text = "Riwayat";
            buttonRiwayat.UseVisualStyleBackColor = false;
            buttonRiwayat.Click += buttonRiwayat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 51);
            label1.Name = "label1";
            label1.Size = new Size(181, 38);
            label1.TabIndex = 11;
            label1.Text = "List Produk :";
            // 
            // UCproduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label1);
            Controls.Add(flowProdukUser);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonRiwayat);
            Controls.Add(buttonProduk);
            Name = "UCproduk";
            Size = new Size(1440, 1024);
            Load += UCproduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKeluar;
        private Button buttonProduk;
        private FlowLayoutPanel flowProdukUser;
        private Button buttonRiwayat;
        private Label label1;
    }
}
