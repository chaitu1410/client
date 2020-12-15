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
        public Admin_login()
        {
            InitializeComponent();
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            try
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
                String email = txtEmailAddress.Text;
                String password = txtPassword.Text;
                bool result = await AuthRepository.Authenticate(email, password);
                if (result == true)
                {
                    Program.author = email;
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invaild Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
/*        public int ValidateEmailId(string emailId)
        {
            // Regular Expressions for email id
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
*/
        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (this.txtPassword.TextLength < 5)
            {
                this.errorProvider1.SetError(this.txtPassword, "Password must be at least 5 character");
                e.Cancel = true;
            }
            else
            {
                this.errorProvider1.SetError(this.txtPassword, "");
            }
        }

        private void cbVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVisibility.Checked)
            {
                txtPassword.PasswordChar = '\0';
                lblForgotPwd.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '●';
                lblForgotPwd.Text = "Show Password";
            }
        }
    }
}

