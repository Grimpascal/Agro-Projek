namespace Agro_Projek.View
{
    partial class TambahPengguna
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
            textBoxusername = new TextBox();
            textBoxPassword = new TextBox();
            labelPw = new Label();
            textBoxHp = new TextBox();
            label3 = new Label();
            buttonTambah = new Button();
            buttonbalek = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 18);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 0;
            label1.Text = "tambah Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(41, 116);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // textBoxusername
            // 
            textBoxusername.Location = new Point(41, 144);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(361, 31);
            textBoxusername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(41, 215);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(361, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // labelPw
            // 
            labelPw.AutoSize = true;
            labelPw.BackColor = Color.Transparent;
            labelPw.Location = new Point(41, 187);
            labelPw.Name = "labelPw";
            labelPw.Size = new Size(87, 25);
            labelPw.TabIndex = 3;
            labelPw.Text = "Password";
            // 
            // textBoxHp
            // 
            textBoxHp.Location = new Point(41, 280);
            textBoxHp.Name = "textBoxHp";
            textBoxHp.Size = new Size(361, 31);
            textBoxHp.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(41, 252);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 5;
            label3.Text = "Nomor Hp";
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.FromArgb(0, 192, 0);
            buttonTambah.Location = new Point(152, 344);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(112, 34);
            buttonTambah.TabIndex = 7;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = false;
            buttonTambah.Click += buttonTambah_Click;
            // 
            // buttonbalek
            // 
            buttonbalek.BackColor = Color.Red;
            buttonbalek.Location = new Point(406, 24);
            buttonbalek.Name = "buttonbalek";
            buttonbalek.Size = new Size(36, 34);
            buttonbalek.TabIndex = 8;
            buttonbalek.Text = "X";
            buttonbalek.UseVisualStyleBackColor = false;
            buttonbalek.Click += buttonbalek_Click;
            // 
            // TambahPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 427);
            Controls.Add(buttonbalek);
            Controls.Add(buttonTambah);
            Controls.Add(textBoxHp);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPw);
            Controls.Add(textBoxusername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TambahPengguna";
            Text = "TambahPengguna";
            Load += TambahPengguna_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxusername;
        private TextBox textBoxPassword;
        private Label labelPw;
        private TextBox textBoxHp;
        private Label label3;
        private Button buttonTambah;
        private Button buttonbalek;
    }
}