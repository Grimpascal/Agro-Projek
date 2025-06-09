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
            label1 = new Label();
            label2 = new Label();
            textBoxJumlah = new TextBox();
            buttonKeranjang = new Button();
            buttonPesan = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 21);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 0;
            label1.Text = "Pesan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 1;
            label2.Text = "Jumlah";
            // 
            // textBoxJumlah
            // 
            textBoxJumlah.Location = new Point(30, 124);
            textBoxJumlah.Name = "textBoxJumlah";
            textBoxJumlah.Size = new Size(364, 31);
            textBoxJumlah.TabIndex = 2;
            // 
            // buttonKeranjang
            // 
            buttonKeranjang.Location = new Point(44, 180);
            buttonKeranjang.Name = "buttonKeranjang";
            buttonKeranjang.Size = new Size(112, 34);
            buttonKeranjang.TabIndex = 3;
            buttonKeranjang.Text = "keranjang";
            buttonKeranjang.UseVisualStyleBackColor = true;
            buttonKeranjang.Click += buttonKeranjang_Click;
            // 
            // buttonPesan
            // 
            buttonPesan.Location = new Point(258, 180);
            buttonPesan.Name = "buttonPesan";
            buttonPesan.Size = new Size(112, 34);
            buttonPesan.TabIndex = 4;
            buttonPesan.Text = "Pesan";
            buttonPesan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(397, 19);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 5;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pesanProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 247);
            Controls.Add(button1);
            Controls.Add(buttonPesan);
            Controls.Add(buttonKeranjang);
            Controls.Add(textBoxJumlah);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pesanProduk";
            Text = "pesanProduk";
            Load += pesanProduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxJumlah;
        private Button buttonKeranjang;
        private Button buttonPesan;
        private Button button1;
    }
}