namespace Agro_Projek.View
{
    partial class pesanProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesanProduk));
            textBoxJumlah = new TextBox();
            buttonPesan = new Button();
            button1 = new Button();
            labelNamaProduk = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBoxAlamat = new TextBox();
            SuspendLayout();
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(177, 144);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(453, 31);
            textBoxJumlah.TabIndex = 2;
            // 
            // buttonPesan
            // 
            buttonPesan.BackColor = Color.Transparent;
            buttonPesan.FlatAppearance.BorderSize = 0;
            buttonPesan.FlatStyle = FlatStyle.Flat;
            buttonPesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesan.ForeColor = SystemColors.ControlLightLight;
            buttonPesan.Location = new Point(139, 336);
            buttonPesan.Name = "buttonPesan";
            buttonPesan.Size = new Size(519, 34);
            buttonPesan.TabIndex = 4;
            buttonPesan.Text = "Pesan";
            buttonPesan.UseVisualStyleBackColor = false;
            buttonPesan.Click += buttonPesan_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(656, 76);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelNamaProduk
            // 
            labelNamaProduk.AutoSize = true;
            labelNamaProduk.BackColor = Color.Transparent;
            labelNamaProduk.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNamaProduk.Location = new Point(420, 76);
            labelNamaProduk.Name = "labelNamaProduk";
            labelNamaProduk.Size = new Size(68, 28);
            labelNamaProduk.TabIndex = 6;
            labelNamaProduk.Text = "Nama";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(177, 116);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 7;
            label1.Text = "Jumlah";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(177, 206);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(453, 33);
            comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(177, 178);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 9;
            label2.Text = "Pengiriman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(177, 245);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 11;
            label3.Text = "Alamat";
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.Location = new Point(177, 273);
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(453, 31);
            textBoxAlamat.TabIndex = 10;
            // 
            // pesanProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(778, 489);
            Controls.Add(label3);
            Controls.Add(textBoxAlamat);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(labelNamaProduk);
            Controls.Add(button1);
            Controls.Add(buttonPesan);
            Controls.Add(textBoxJumlah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pesanProduk";
            Text = "pesanProduk";
            Load += pesanProduk_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxJumlah;
        private Button buttonPesan;
        private Button button1;
        private Label labelNama;
        private Label labelNamaProduk;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAlamat;
    }
}