namespace Agro_Projek.View
{
    partial class editUser
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
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxHp = new TextBox();
            label4 = new Label();
            buttonEdit = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(232, 45);
            label1.TabIndex = 0;
            label1.Text = "Edit Pengguna";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 106);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(25, 130);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(368, 31);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(25, 197);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(368, 31);
            textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 173);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textBoxHp
            // 
            textBoxHp.Location = new Point(25, 263);
            textBoxHp.Name = "textBoxHp";
            textBoxHp.Size = new Size(368, 31);
            textBoxHp.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 239);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 5;
            label4.Text = "Nomor Hp";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(0, 192, 0);
            buttonEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(157, 343);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(112, 34);
            buttonEdit.TabIndex = 7;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(390, 20);
            button1.Name = "button1";
            button1.Size = new Size(34, 34);
            button1.TabIndex = 8;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // editUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 416);
            Controls.Add(button1);
            Controls.Add(buttonEdit);
            Controls.Add(textBoxHp);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editUser";
            Text = "editUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxHp;
        private Label label4;
        private Button buttonEdit;
        private Button button1;
    }
}