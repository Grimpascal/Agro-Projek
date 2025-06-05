namespace Agro_Projek.View
{
    partial class UCregister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCregister));
            textUsername = new TextBox();
            textPw = new TextBox();
            textTelepon = new TextBox();
            buttonLogin = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.White;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Location = new Point(993, 306);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(307, 24);
            textUsername.TabIndex = 0;
            // 
            // textPw
            // 
            textPw.BackColor = Color.White;
            textPw.BorderStyle = BorderStyle.None;
            textPw.Location = new Point(993, 464);
            textPw.Name = "textPw";
            textPw.Size = new Size(307, 24);
            textPw.TabIndex = 1;
            // 
            // textTelepon
            // 
            textTelepon.BackColor = Color.White;
            textTelepon.BorderStyle = BorderStyle.None;
            textTelepon.Location = new Point(993, 612);
            textTelepon.Name = "textTelepon";
            textTelepon.Size = new Size(307, 24);
            textTelepon.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Transparent;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(939, 733);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(351, 60);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Register";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.MediumBlue;
            linkLabel1.Location = new Point(1151, 830);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 21);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UCregister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(linkLabel1);
            Controls.Add(buttonLogin);
            Controls.Add(textTelepon);
            Controls.Add(textPw);
            Controls.Add(textUsername);
            Name = "UCregister";
            Size = new Size(1440, 1024);
            Load += UCregister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textPw;
        private TextBox textTelepon;
        private Button buttonLogin;
        private LinkLabel linkLabel1;
    }
}
