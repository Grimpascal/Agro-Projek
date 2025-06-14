namespace Agro_Projek.View
{
    partial class Pembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pembayaran));
            comboBoxMetode = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxBayar = new ComboBox();
            button1 = new Button();
            buttonPesan = new Button();
            SuspendLayout();
            // 
            // comboBoxMetode
            // 
            comboBoxMetode.FormattingEnabled = true;
            comboBoxMetode.Location = new Point(119, 166);
            comboBoxMetode.Name = "comboBoxMetode";
            comboBoxMetode.Size = new Size(544, 33);
            comboBoxMetode.TabIndex = 0;
            comboBoxMetode.SelectedIndexChanged += comboBoxMetode_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(119, 138);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 1;
            label1.Text = "Metode Pembayaran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(117, 214);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 3;
            label2.Text = "Pembayaran";
            // 
            // comboBoxBayar
            // 
            comboBoxBayar.FormattingEnabled = true;
            comboBoxBayar.Location = new Point(117, 242);
            comboBoxBayar.Name = "comboBoxBayar";
            comboBoxBayar.Size = new Size(544, 33);
            comboBoxBayar.TabIndex = 2;
            comboBoxBayar.SelectedIndexChanged += comboBoxBayar_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(652, 111);
            button1.Name = "button1";
            button1.Size = new Size(33, 34);
            button1.TabIndex = 6;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonPesan
            // 
            buttonPesan.BackColor = Color.Transparent;
            buttonPesan.FlatAppearance.BorderSize = 0;
            buttonPesan.FlatStyle = FlatStyle.Flat;
            buttonPesan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPesan.ForeColor = SystemColors.ControlLightLight;
            buttonPesan.Location = new Point(130, 299);
            buttonPesan.Name = "buttonPesan";
            buttonPesan.Size = new Size(519, 34);
            buttonPesan.TabIndex = 7;
            buttonPesan.Text = "Pesan";
            buttonPesan.UseVisualStyleBackColor = false;
            buttonPesan.Click += buttonPesan_Click;
            // 
            // Pembayaran
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(778, 489);
            Controls.Add(buttonPesan);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBoxBayar);
            Controls.Add(label1);
            Controls.Add(comboBoxMetode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pembayaran";
            Text = "Pembayaran";
            Load += Pembayaran_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMetode;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxBayar;
        private Button button1;
        private Button buttonPesan;
    }
}