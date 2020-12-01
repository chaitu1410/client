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
            
            
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtEmailAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Email Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmailAddress.Text, @"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Invaild Email...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String email = txtEmailAddress.Text;
            String password = txtPassword.Text;
            _authRepository.Authenticate(email, password);

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
    }
}

