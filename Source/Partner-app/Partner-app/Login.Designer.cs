
namespace Partner_app
{
    partial class Login
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
            this.loginTittle = new System.Windows.Forms.Label();
            this.sigin = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginTittle
            // 
            this.loginTittle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginTittle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.loginTittle.Location = new System.Drawing.Point(157, 29);
            this.loginTittle.Name = "loginTittle";
            this.loginTittle.Size = new System.Drawing.Size(164, 45);
            this.loginTittle.TabIndex = 0;
            this.loginTittle.Text = "Đăng nhập";
            // 
            // sigin
            // 
            this.sigin.BackColor = System.Drawing.SystemColors.Highlight;
            this.sigin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sigin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sigin.Location = new System.Drawing.Point(157, 351);
            this.sigin.Name = "sigin";
            this.sigin.Size = new System.Drawing.Size(120, 45);
            this.sigin.TabIndex = 1;
            this.sigin.Text = "Đăng nhập";
            this.sigin.UseVisualStyleBackColor = false;
            this.sigin.Click += new System.EventHandler(this.sigin_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userLabel.Location = new System.Drawing.Point(182, 140);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(94, 25);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Tài khoản";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(46, 168);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(376, 34);
            this.username.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass.Location = new System.Drawing.Point(46, 259);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(376, 34);
            this.pass.TabIndex = 5;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passLabel.Location = new System.Drawing.Point(182, 231);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(93, 25);
            this.passLabel.TabIndex = 4;
            this.passLabel.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(116, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ứng dụng dành cho đối tác";
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.SystemColors.MenuBar;
            this.notice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notice.ForeColor = System.Drawing.Color.Red;
            this.notice.Location = new System.Drawing.Point(56, 309);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(357, 20);
            this.notice.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 468);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.username);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.sigin);
            this.Controls.Add(this.loginTittle);
            this.Name = "Login";
            this.Text = "Partner - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTittle;
        private System.Windows.Forms.Button sigin;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox notice;
    }
}