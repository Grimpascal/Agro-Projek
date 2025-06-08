namespace Agro_Projek.View
{
    partial class UCcontainerProduk
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
            labelHarga = new Label();
            labelNama = new Label();
            labelStok = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = Color.Transparent;
            labelHarga.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHarga.Location = new Point(69, 137);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(61, 25);
            labelHarga.TabIndex = 0;
            labelHarga.Text = "Harga";
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(70, 103);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(60, 25);
            labelNama.TabIndex = 1;
            labelNama.Text = "Nama";
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.BackColor = Color.Transparent;
            labelStok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStok.Location = new Point(70, 171);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(48, 25);
            labelStok.TabIndex = 2;
            labelStok.Text = "Stok";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(148, 166);
            button1.Name = "button1";
            button1.Size = new Size(32, 34);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Location = new Point(20, 166);
            button2.Name = "button2";
            button2.Size = new Size(32, 34);
            button2.TabIndex = 4;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            // 
            // UCcontainerProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelStok);
            Controls.Add(labelNama);
            Controls.Add(labelHarga);
            Name = "UCcontainerProduk";
            Size = new Size(196, 234);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHarga;
        private Label labelNama;
        private Label labelStok;
        private Button button1;
        private Button button2;
    }
}
