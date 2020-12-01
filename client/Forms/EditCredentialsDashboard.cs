using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;
using System.Linq;

namespace client.Forms
{
    public partial class EditCredentialsDashboard : Form
    {
        UserRepository _userRepository;
        
        public EditCredentialsDashboard()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private void EditCredentialsDashboard_Load(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }
        private void Load_Datagridview_Data()
        {
            var source = new BindingSource();
            source.DataSource = _userRepository.GetUser();
            dgvEditCredentials.AutoGenerateColumns = true;
            dgvEditCredentials.DataSource = source;
            //dgvEditCredentials.Columns["Id"].Visible = false;
        }

        private void dgvEditCredentials_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEditCredentials.CurrentRow != null)
            {
                var row = dgvEditCredentials.CurrentRow.Cells;
                // int id = Convert.ToInt32(row["TransactionId"].Value);
                //Console.WriteLine(id);

                //Transaction transaction = await _transactionRepository.Find(id);
                EditCredential editCredential = new EditCredential();
                editCredential.Show();

            }
        }
    }
}
