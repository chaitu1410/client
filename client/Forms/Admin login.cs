using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;

namespace client.Forms
{
    public partial class Admin_login : Form
    {
        User _user;
        AuthRepository _authRepository;
        public Admin_login()
        {
            InitializeComponent();
            _authRepository = new AuthRepository();
            
            
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmailAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Email Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmailAddress.Text, @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Invaild Email...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
                return;
            }
            String email = txtEmailAddress.Text;
            String password = txtPassword.Text;
           bool result= _authRepository.Authenticate(email, password);
            if(result==true)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public int ValidateEmailId(string emailId)
        {
            /*Regular Expressions for email id*/
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (emailId.Length > 0)
            {
                if (!rEMail.IsMatch(emailId))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            return 2;
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPassword.TextLength < 8)
            {
                this.errorProvider1.SetError(this.txtPassword, "Password must be at least 8 character");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtPassword, "");
            }
        }
    }
}

