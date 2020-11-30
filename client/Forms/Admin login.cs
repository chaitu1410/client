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
            _user = new User();
            
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmailAddress.Text;
            string password = txtPassword.Text;
           bool result=_authRepository.Authenticate(email, password);
            if(result==true)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invaild username and password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
