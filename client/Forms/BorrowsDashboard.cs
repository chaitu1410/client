using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;
using System.Linq;
using System.Threading.Tasks;

namespace client.Forms
{
    public partial class BorrowsDashboard : Form
    {
        BorrowRepository _borrowRepository;
        Borrow borrow;
        bool flag = false;
        public BorrowsDashboard()
        {
            InitializeComponent();
            _borrowRepository=new BorrowRepository();
            borrow = new Borrow();
            Load_Datagridview_Data();
            EditBorrowForm.OnLoadData += Load_Datagridview_Data;
            EditBorrowForm.OnLoadData += SetupTextboxes;

        }

        private async void Load_Datagridview_Data()
        {
            await Load_Datagridview1_Data();
            await Load_Datagridview2_Data();
        }

        private async Task Load_Datagridview1_Data_By_Date()
        {
            try
            {
                pbxBorrowingBalance.Visible = true;
                DateTime dt = Convert.ToDateTime(dtpBorrowingBalance.Value);
                String s1 = dt.ToString("yyyy-MM-dd");
                DateTime dtnew = Convert.ToDateTime(s1);

                var source = new BindingSource();
                source.DataSource = await _borrowRepository.GetAllUndepositedByDate(dtnew);
                dgvBorrowingBalance.AutoGenerateColumns = true;
                dgvBorrowingBalance.DataSource = source;
                dgvBorrowingBalance.Columns["Id"].Visible = false;
                dgvBorrowingBalance.Columns["IsReturned"].Visible = false;
                dgvBorrowingBalance.Columns["ReturnDate"].Visible = false;
                pbxBorrowingBalance.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task Load_Datagridview2_Data_By_Date()
        {
            try
            {
                pbxCreditDeposit.Visible = true;
                DateTime dt = Convert.ToDateTime(dtpCreditDeposit.Value);
                String s1 = dt.ToString("yyyy-MM-dd");
                DateTime dtnew = Convert.ToDateTime(s1);

                var source = new BindingSource();
                source.DataSource = await _borrowRepository.GetAllDepositedByDate(dtnew);
                dgvBorrowingBalance.AutoGenerateColumns = true;
                dgvCreditDeposit.DataSource = source;
                dgvCreditDeposit.Columns["Id"].Visible = false;
                dgvCreditDeposit.Columns["IsReturned"].Visible = false;
                pbxCreditDeposit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dgvBorrowingBalance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBorrowingBalance.CurrentRow != null)
                {
                    var row = dgvBorrowingBalance.CurrentRow.Cells;
                    int id = Convert.ToInt32(row["Id"].Value);
                    //Console.WriteLine(id);
                    Borrow borrow = await _borrowRepository.Find(id);
                    EditBorrowForm edf = new EditBorrowForm(borrow);
                    edf.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Load_Datagridview1_Data()
        {
            try
            {
                pbxBorrowingBalance.Visible = true;
                var source = new BindingSource();
                source.DataSource = await _borrowRepository.GetAllUndeposited();
                dgvBorrowingBalance.AutoGenerateColumns = true;
                dgvBorrowingBalance.DataSource = source;
                dgvBorrowingBalance.Columns["Id"].Visible = false;
                dgvBorrowingBalance.Columns["IsReturned"].Visible = false;
                dgvBorrowingBalance.Columns["ReturnDate"].Visible = false;
                pbxBorrowingBalance.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Load_Datagridview2_Data()
        {
            try
            {
                pbxCreditDeposit.Visible = true;
                var source = new BindingSource();
                source.DataSource = await _borrowRepository.GetAllDeposited();
                dgvCreditDeposit.AutoGenerateColumns = true;
                dgvCreditDeposit.DataSource = source;
                dgvCreditDeposit.Columns["Id"].Visible = false;
                dgvCreditDeposit.Columns["IsReturned"].Visible = false;
                /// dgvBorrowingBalance.Columns["ReturnDate"].Visible = false;
                pbxCreditDeposit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BorrowsDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void BorrowsDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void BorrowsDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private async void dtpBorrowingBalance_ValueChanged(object sender, EventArgs e)
        {
            await Load_Datagridview1_Data_By_Date();
        }

        private async void dtpCreditDeposit_ValueChanged(object sender, EventArgs e)
        {
            await Load_Datagridview2_Data_By_Date();
        }

        private async void btnClrFilter_Click(object sender, EventArgs e)
        {
            //first
            //dtpBorrowingBalance.Value = DateTime.Now;
            await Load_Datagridview1_Data();
            txtFilterByName.Clear();
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            //dtpCreditDeposit.Value = DateTime.Now;
            await Load_Datagridview2_Data();
            txtFilterName.Clear();
        }

        private void BorrowsDashboard_Load(object sender, EventArgs e)
        {
            SetupTextboxes();
        }

        private async Task SetupUndepositedTextbox()
        {
            AutoCompleteStringCollection depositedCollection = new AutoCompleteStringCollection();
            depositedCollection.AddRange(await _borrowRepository.GetAllUndepositedName());
            txtFilterByName.AutoCompleteCustomSource = depositedCollection;
            txtFilterByName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFilterByName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async Task SetupDepositedTextbox()
        {
            AutoCompleteStringCollection depositedCollection = new AutoCompleteStringCollection();
            depositedCollection.AddRange(await _borrowRepository.GetAllDepositedName());
            txtFilterName.AutoCompleteCustomSource = depositedCollection;
            txtFilterName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtFilterName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private async void SetupTextboxes()
        {
            await SetupUndepositedTextbox();
            await SetupDepositedTextbox();
        }

        private async Task Load_Datagridview1_Data_By_Name()
        {
            try
            {
                pbxBorrowingBalance.Visible = true;
                var source = new BindingSource();
                source.DataSource = await _borrowRepository.GetAllUndepositedByName(txtFilterByName.Text);
                dgvBorrowingBalance.AutoGenerateColumns = true;
                dgvBorrowingBalance.DataSource = source;
                dgvBorrowingBalance.Columns["Id"].Visible = false;
                dgvBorrowingBalance.Columns["IsReturned"].Visible = false;
                dgvBorrowingBalance.Columns["ReturnDate"].Visible = false;
                pbxBorrowingBalance.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task Load_Datagridview2_Data_By_Name()
        {
            try
            {
                pbxCreditDeposit.Visible = true;
                var source = new BindingSource();
                source.DataSource = await _borrowRepository.GetAllDepositedByName(txtFilterName.Text);
                dgvBorrowingBalance.AutoGenerateColumns = true;
                dgvCreditDeposit.DataSource = source;
                dgvCreditDeposit.Columns["Id"].Visible = false;
                dgvCreditDeposit.Columns["IsReturned"].Visible = false;
                pbxCreditDeposit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtFilterByName.Text.Trim() != "")
                await Load_Datagridview1_Data_By_Name();
        }

        private async void btnSearchName_Click(object sender, EventArgs e)
        {
            if (txtFilterName.Text.Trim() != "")
                await Load_Datagridview2_Data_By_Name();
        }

        private async void dgvCreditDeposit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvCreditDeposit.CurrentRow != null)
                {
                    var row = dgvCreditDeposit.CurrentRow.Cells;
                    int id = Convert.ToInt32(row["Id"].Value);
                    //Console.WriteLine(id);
                    Borrow borrow = await _borrowRepository.Find(id);
                    EditBorrowForm edf = new EditBorrowForm(borrow);
                    edf.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
