namespace Agro_Projek.View
{
    partial class UCloginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCloginAdmin));
            textUsername = new TextBox();
            textPassword = new TextBox();
            checkPw = new CheckBox();
            buttonLogin = new Button();
            linkUser = new LinkLabel();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(1029, 381);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(275, 32);
            textUsername.TabIndex = 1;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(1029, 522);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(275, 32);
            textPassword.TabIndex = 2;
            textPassword.UseSystemPasswordChar = true;
            // 
            // checkPw
            // 
            checkPw.AutoSize = true;
            checkPw.BackColor = Color.Transparent;
            checkPw.FlatStyle = FlatStyle.Flat;
            checkPw.Location = new Point(1001, 574);
            checkPw.Name = "checkPw";
            checkPw.Size = new Size(77, 29);
            checkPw.TabIndex = 6;
            checkPw.Text = "Show";
            checkPw.UseVisualStyleBackColor = false;
            checkPw.CheckedChanged += checkPw_CheckedChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(1001, 653);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(300, 37);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkUser
            // 
            linkUser.AutoSize = true;
            linkUser.BackColor = Color.Transparent;
            linkUser.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkUser.Location = new Point(1113, 716);
            linkUser.Name = "linkUser";
            linkUser.Size = new Size(79, 21);
            linkUser.TabIndex = 8;
            linkUser.TabStop = true;
            linkUser.Text = "login user";
            linkUser.LinkClicked += linkUser_LinkClicked;
            // 
            // UCloginAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(linkUser);
            Controls.Add(buttonLogin);
            Controls.Add(checkPw);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Name = "UCloginAdmin";
            Size = new Size(1440, 1024);
            Load += UCloginAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textPassword;
        private CheckBox checkPw;
        private Button buttonLogin;
        private LinkLabel linkUser;
    }
}
