namespace Agro_Projek.View
{
    partial class TambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahProduk));
            label1 = new Label();
            textNamaProduk = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxHarga = new TextBox();
            label4 = new Label();
            comboBoxJenis = new ComboBox();
            label5 = new Label();
            textBoxStok = new TextBox();
            buttonTambah = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(133, 24);
            label1.Name = "label1";
            label1.Size = new Size(285, 48);
            label1.TabIndex = 0;
            label1.Text = "Tambah Produk";
            // 
            // textNamaProduk
            // 
            textNamaProduk.Location = new Point(52, 150);
            textNamaProduk.Name = "textNamaProduk";
            textNamaProduk.Size = new Size(423, 31);
            textNamaProduk.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(52, 122);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama Produk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(52, 187);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 4;
            label3.Text = "Harga";
            // 
            // textBoxHarga
            // 
            textBoxHarga.Location = new Point(52, 215);
            textBoxHarga.Name = "textBoxHarga";
            textBoxHarga.Size = new Size(423, 31);
            textBoxHarga.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(52, 258);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 6;
            label4.Text = "Jenis";
            // 
            // comboBoxJenis
            // 
            comboBoxJenis.FormattingEnabled = true;
            comboBoxJenis.Location = new Point(52, 286);
            comboBoxJenis.Name = "comboBoxJenis";
            comboBoxJenis.Size = new Size(423, 33);
            comboBoxJenis.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(52, 329);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 9;
            label5.Text = "Stok";
            // 
            // textBoxStok
            // 
            textBoxStok.Location = new Point(52, 357);
            textBoxStok.Name = "textBoxStok";
            textBoxStok.Size = new Size(423, 31);
            textBoxStok.TabIndex = 8;
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.Transparent;
            buttonTambah.BackgroundImage = (Image)resources.GetObject("buttonTambah.BackgroundImage");
            buttonTambah.FlatAppearance.BorderSize = 0;
            buttonTambah.FlatStyle = FlatStyle.Flat;
            buttonTambah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambah.Location = new Point(205, 453);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(112, 34);
            buttonTambah.TabIndex = 10;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.Desktop;
            button2.Location = new Point(485, 24);
            button2.Name = "button2";
            button2.Size = new Size(35, 34);
            button2.TabIndex = 11;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TambahProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(543, 519);
            Controls.Add(button2);
            Controls.Add(buttonTambah);
            Controls.Add(label5);
            Controls.Add(textBoxStok);
            Controls.Add(comboBoxJenis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxHarga);
            Controls.Add(label2);
            Controls.Add(textNamaProduk);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahProduk";
            Text = "TambahProduk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textNamaProduk;
        private Label label2;
        private Label label3;
        private TextBox textBoxHarga;
        private Label label4;
        private ComboBox comboBoxJenis;
        private Label label5;
        private TextBox textBoxStok;
        private Button buttonTambah;
        private Button button2;
    }
}