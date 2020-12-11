﻿
namespace client.Forms
{
    partial class Admin_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_login));
            this.lblAdminLogin = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.pbxUsername = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbxPassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblForgotPwd = new System.Windows.Forms.Label();
            this.cbVisibility = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminLogin
            // 
            this.lblAdminLogin.AutoSize = true;
            this.lblAdminLogin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblAdminLogin.Location = new System.Drawing.Point(293, 47);
            this.lblAdminLogin.Name = "lblAdminLogin";
            this.lblAdminLogin.Size = new System.Drawing.Size(170, 32);
            this.lblAdminLogin.TabIndex = 0;
            this.lblAdminLogin.Text = "Admin Login";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.lblEmailAddress.Location = new System.Drawing.Point(98, 129);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(142, 23);
            this.lblEmailAddress.TabIndex = 1;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmailAddress.Location = new System.Drawing.Point(125, 172);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(551, 31);
            this.txtEmailAddress.TabIndex = 3;
            // 
            // pbxUsername
            // 
            this.pbxUsername.Image = ((System.Drawing.Image)(resources.GetObject("pbxUsername.Image")));
            this.pbxUsername.Location = new System.Drawing.Point(98, 172);
            this.pbxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxUsername.Name = "pbxUsername";
            this.pbxUsername.Size = new System.Drawing.Size(19, 35);
            this.pbxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUsername.TabIndex = 4;
            this.pbxUsername.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(98, 263);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 23);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // pbxPassword
            // 
            this.pbxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbxPassword.Image")));
            this.pbxPassword.Location = new System.Drawing.Point(98, 305);
            this.pbxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxPassword.Name = "pbxPassword";
            this.pbxPassword.Size = new System.Drawing.Size(19, 35);
            this.pbxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPassword.TabIndex = 6;
            this.pbxPassword.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(125, 305);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(551, 31);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(98, 431);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 55);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnCancel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(233, 431);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 55);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblForgotPwd
            // 
            this.lblForgotPwd.AutoSize = true;
            this.lblForgotPwd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblForgotPwd.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblForgotPwd.Location = new System.Drawing.Point(505, 358);
            this.lblForgotPwd.Name = "lblForgotPwd";
            this.lblForgotPwd.Size = new System.Drawing.Size(147, 22);
            this.lblForgotPwd.TabIndex = 8;
            this.lblForgotPwd.Text = "Show Password";
            // 
            // cbVisibility
            // 
            this.cbVisibility.AutoSize = true;
            this.cbVisibility.Location = new System.Drawing.Point(658, 363);
            this.cbVisibility.Name = "cbVisibility";
            this.cbVisibility.Size = new System.Drawing.Size(18, 17);
            this.cbVisibility.TabIndex = 11;
            this.cbVisibility.UseVisualStyleBackColor = true;
            this.cbVisibility.CheckedChanged += new System.EventHandler(this.cbVisibility_CheckedChanged);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 540);
            this.Controls.Add(this.cbVisibility);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblForgotPwd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.pbxUsername);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblAdminLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_login";
            this.Load += new System.EventHandler(this.Admin_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminLogin;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.PictureBox pbxUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pbxPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox cbVisibility;
        private System.Windows.Forms.Label lblForgotPwd;
    }
}