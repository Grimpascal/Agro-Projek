namespace Agro_Projek.View
{
    partial class hapusUser
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
            buttonHapus = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.Red;
            buttonHapus.Location = new Point(177, 92);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(124, 64);
            buttonHapus.TabIndex = 0;
            buttonHapus.Text = "Hapus";
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(47, 92);
            button1.Name = "button1";
            button1.Size = new Size(124, 64);
            button1.TabIndex = 1;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 37);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 2;
            label1.Text = "Yakin ingin menghapus?";
            // 
            // hapusUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 212);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonHapus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "hapusUser";
            Text = "hapusUser";
            Load += hapusUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHapus;
        private Button button1;
        private Label label1;
    }
}