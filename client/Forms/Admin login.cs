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
            String email = txtEmailAddress.Text;
            String password = txtPassword.Text;
            _authRepository.Authenticate(email, password);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
