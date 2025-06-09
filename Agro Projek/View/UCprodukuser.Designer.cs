namespace Agro_Projek.View
{
    partial class UCprodukuser
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
            labelNama = new Label();
            labelHarga = new Label();
            labelStok = new Label();
            buttonPesan = new Button();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(73, 131);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(60, 25);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            labelNama.Click += labelNama_Click;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.BackColor = Color.Transparent;
            labelHarga.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHarga.Location = new Point(73, 156);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(61, 25);
            labelHarga.TabIndex = 1;
            labelHarga.Text = "Harga";
            // 
            // labelStok
            // 
            labelStok.AutoSize = true;
            labelStok.BackColor = Color.Transparent;
            labelStok.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStok.Location = new Point(85, 181);
            labelStok.Name = "labelStok";
            labelStok.Size = new Size(48, 25);
            labelStok.TabIndex = 2;
            labelStok.Text = "Stok";
            // 
            // buttonPesan
            // 
            buttonPesan.BackColor = Color.FromArgb(0, 192, 0);
            buttonPesan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesan.Location = new Point(51, 209);
            buttonPesan.Name = "buttonPesan";
            buttonPesan.Size = new Size(112, 34);
            buttonPesan.TabIndex = 3;
            buttonPesan.Text = "Pesan";
            buttonPesan.UseVisualStyleBackColor = false;
            // 
            // UCprodukuser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(buttonPesan);
            Controls.Add(labelStok);
            Controls.Add(labelHarga);
            Controls.Add(labelNama);
            Name = "UCprodukuser";
            Size = new Size(213, 256);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelHarga;
        private Label labelStok;
        private Button buttonPesan;
    }
}
