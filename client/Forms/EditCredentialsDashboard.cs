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
            EditCredential.OnLoadData += Load_Datagridview_Data;
        }

        private void EditCredentialsDashboard_Load(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }
        private async void Load_Datagridview_Data()
        {
            try
            {
                var source = new BindingSource();
                source.DataSource = await _userRepository.GetUser();
                dgvEditCredentials.AutoGenerateColumns = true;
                dgvEditCredentials.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEditCredentials_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvEditCredentials.CurrentRow != null)
                {
                    var row = dgvEditCredentials.CurrentRow.Cells;
                    EditCredential editCredential = new EditCredential();
                    editCredential.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
