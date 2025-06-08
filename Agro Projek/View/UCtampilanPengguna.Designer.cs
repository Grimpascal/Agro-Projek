namespace Agro_Projek.View
{
    partial class UCtampilanPengguna
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
            labelHp = new Label();
            buttonHapus = new Button();
            buttonEdit = new Button();
            labelId = new Label();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNama.Location = new Point(60, 11);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(65, 28);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            // 
            // labelHp
            // 
            labelHp.AutoSize = true;
            labelHp.BackColor = Color.Transparent;
            labelHp.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHp.Location = new Point(60, 39);
            labelHp.Name = "labelHp";
            labelHp.Size = new Size(39, 28);
            labelHp.TabIndex = 1;
            labelHp.Text = "HP";
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.Red;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.Location = new Point(905, 24);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(106, 34);
            buttonHapus.TabIndex = 2;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(0, 192, 0);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Location = new Point(771, 24);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(109, 34);
            buttonEdit.TabIndex = 3;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.BackColor = Color.Transparent;
            labelId.Location = new Point(13, 29);
            labelId.Name = "labelId";
            labelId.Size = new Size(28, 25);
            labelId.TabIndex = 4;
            labelId.Text = "Id";
            labelId.Click += labelId_Click;
            // 
            // UCtampilanPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(labelId);
            Controls.Add(buttonEdit);
            Controls.Add(buttonHapus);
            Controls.Add(labelHp);
            Controls.Add(labelNama);
            Name = "UCtampilanPengguna";
            Size = new Size(1028, 80);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelHp;
        private Button buttonHapus;
        private Button buttonEdit;
        private Label labelId;
    }
}
