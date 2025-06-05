namespace Agro_Projek.View
{
    partial class UClogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UClogin));
            textUsername = new TextBox();
            textPassword = new TextBox();
            buttonLogin = new Button();
            linkRegister = new LinkLabel();
            checkPw = new CheckBox();
            linkAdmin = new LinkLabel();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(1008, 391);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(307, 32);
            textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(1008, 544);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(307, 32);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.Black;
            buttonLogin.Location = new Point(968, 671);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(347, 57);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.BackColor = Color.Transparent;
            linkRegister.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkRegister.LinkColor = Color.MediumBlue;
            linkRegister.Location = new Point(1206, 773);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(67, 21);
            linkRegister.TabIndex = 4;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // checkPw
            // 
            checkPw.AutoSize = true;
            checkPw.BackColor = Color.Transparent;
            checkPw.FlatStyle = FlatStyle.Flat;
            checkPw.Location = new Point(956, 613);
            checkPw.Name = "checkPw";
            checkPw.Size = new Size(77, 29);
            checkPw.TabIndex = 5;
            checkPw.Text = "Show";
            checkPw.UseVisualStyleBackColor = false;
            checkPw.CheckedChanged += checkPw_CheckedChanged;
            // 
            // linkAdmin
            // 
            linkAdmin.AutoSize = true;
            linkAdmin.BackColor = Color.Transparent;
            linkAdmin.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkAdmin.Location = new Point(1102, 798);
            linkAdmin.Name = "linkAdmin";
            linkAdmin.Size = new Size(99, 21);
            linkAdmin.TabIndex = 6;
            linkAdmin.TabStop = true;
            linkAdmin.Text = "Login Admin";
            linkAdmin.LinkClicked += linkAdmin_LinkClicked;
            // 
            // UClogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(linkAdmin);
            Controls.Add(checkPw);
            Controls.Add(linkRegister);
            Controls.Add(buttonLogin);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Name = "UClogin";
            Size = new Size(1440, 1024);
            Load += UClogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textPassword;
        private Button buttonLogin;
        private LinkLabel linkRegister;
        private CheckBox checkPw;
        private LinkLabel linkAdmin;
    }
}
