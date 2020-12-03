using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.Data;

namespace client.Forms
{
    public partial class home : Form
    {
        TransactionRepository _transactionRepository;
        public home()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
            Load_Datagridview_Data();
            AddNewRecordsForm.OnLoadData += Load_Datagridview_Data;
            EditRecordsForm.OnLoadData += Load_Datagridview_Data;
        }

        private void dtpRecords_ValueChanged(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }

        

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                AddBorrowForm frm = new AddBorrowForm();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvRecords.CurrentRow != null)
                {
                    var row = dgvRecords.CurrentRow.Cells;
                    int id = Convert.ToInt32(row["TransactionId"].Value);
                    //Console.WriteLine(id);
                    Transaction transaction = await _transactionRepository.Find(id);
                    EditRecordsForm f1 = new EditRecordsForm(transaction);
                    f1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async void Load_Datagridview_Data()
        {
            try
            {
                pbxHome.Visible = true;
                DateTime dt = Convert.ToDateTime(dtpRecords.Value);
                String s1 = dt.ToString("yyyy-MM-dd");
                DateTime dtnew = Convert.ToDateTime(s1);

                var source = new BindingSource();
                source.DataSource = await _transactionRepository.GetAllByDate(dtnew);
                dgvRecords.AutoGenerateColumns = true;
                dgvRecords.DataSource = source;
                dgvRecords.Columns["TransactionId"].Visible = false;
                pbxHome.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            try
            {
                AddSaleReturn addSaleReturn = new AddSaleReturn();
                addSaleReturn.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRecords_Click_1(object sender, EventArgs e)
        {
            try
            {
                AddNewRecordsForm frm = new AddNewRecordsForm();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
