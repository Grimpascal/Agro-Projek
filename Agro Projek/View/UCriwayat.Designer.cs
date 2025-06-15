namespace Agro_Projek.View
{
    partial class UCriwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCriwayat));
            buttonKeluar = new Button();
            buttonRiwayat = new Button();
            buttonProduk = new Button();
            flowRiwayat = new FlowLayoutPanel();
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
            buttonKeluar.Location = new Point(0, 604);
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
            buttonRiwayat.Location = new Point(0, 519);
            buttonRiwayat.Name = "buttonRiwayat";
            buttonRiwayat.Size = new Size(276, 70);
            buttonRiwayat.TabIndex = 8;
            buttonRiwayat.Text = "Riwayat";
            buttonRiwayat.UseVisualStyleBackColor = false;
            buttonRiwayat.Click += buttonRiwayat_Click;
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
            // flowRiwayat
            // 
            flowRiwayat.BackColor = Color.Transparent;
            flowRiwayat.Location = new Point(341, 214);
            flowRiwayat.Name = "flowRiwayat";
            flowRiwayat.Size = new Size(825, 652);
            flowRiwayat.TabIndex = 10;
            flowRiwayat.Paint += flowRiwayat_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 161);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 12;
            label1.Text = "List Riwayat :";
            // 
            // UCriwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label1);
            Controls.Add(flowRiwayat);
            Controls.Add(buttonKeluar);
            Controls.Add(buttonRiwayat);
            Controls.Add(buttonProduk);
            Name = "UCriwayat";
            Size = new Size(1440, 1024);
            Load += UCriwayat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonKeluar;
        private Button buttonRiwayat;
        private Button buttonProduk;
        private FlowLayoutPanel flowRiwayat;
        private Label label1;
    }
}
