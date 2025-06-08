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
            buttonPlus = new Button();
            buttonMin = new Button();
            labelid = new Label();
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
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.Green;
            buttonPlus.Location = new Point(148, 166);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(32, 34);
            buttonPlus.TabIndex = 3;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMin
            // 
            buttonMin.BackColor = Color.FromArgb(192, 0, 0);
            buttonMin.Location = new Point(20, 166);
            buttonMin.Name = "buttonMin";
            buttonMin.Size = new Size(32, 34);
            buttonMin.TabIndex = 4;
            buttonMin.Text = "-";
            buttonMin.UseVisualStyleBackColor = false;
            // 
            // labelid
            // 
            labelid.AutoSize = true;
            labelid.Location = new Point(3, 0);
            labelid.Name = "labelid";
            labelid.Size = new Size(28, 25);
            labelid.TabIndex = 5;
            labelid.Text = "Id";
            // 
            // UCcontainerProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(labelid);
            Controls.Add(buttonMin);
            Controls.Add(buttonPlus);
            Controls.Add(labelStok);
            Controls.Add(labelNama);
            Controls.Add(labelHarga);
            Name = "UCcontainerProduk";
            Size = new Size(196, 234);
            Load += UCcontainerProduk_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHarga;
        private Label labelNama;
        private Label labelStok;
        private Button buttonPlus;
        private Button buttonMin;
        private Label labelid;
    }
}
