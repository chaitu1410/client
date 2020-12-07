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
    public partial class SaleReturnDashboard : Form
    {
        SaleReturnRepository _saleReturnRepository;
        SaleReturn _saleReturn;
        public SaleReturnDashboard()
        {
            InitializeComponent();
            _saleReturnRepository = new SaleReturnRepository();
            _saleReturn = new SaleReturn();
            EditSaleReturn.OnLoadData += Setup;
        }

        private async void dtpSaleReturn_ValueChanged(object sender, EventArgs e)
        {
            await Load_Datagridview_Data_By_Date();
        }

        private async void Setup() {
            await Load_Datagridview_Data();
            await SetupSearchBox();
        }

        private async void dgvSaleReturn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvSaleReturn.CurrentRow != null)
                {
                    var row = dgvSaleReturn.CurrentRow.Cells;
                    int id = Convert.ToInt32(row["Id"].Value);
                    //Console.WriteLine(id);
                    SaleReturn _saleReturn = await _saleReturnRepository.Find(id);
                    EditSaleReturn editSaleReturn = new EditSaleReturn(_saleReturn);
                    editSaleReturn.Show();
                }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            await Load_Datagridview_Data();
            txtFilterByName.Text = "";
        }

        private async void SaleReturnDashboard_Activated(object sender, EventArgs e)
        {
            await Load_Datagridview_Data();
        }
        private async Task Load_Datagridview_Data()
        {
            try
            {
                pbxSaleReturn.Visible = true;
                var source = new BindingSource();
                source.DataSource = await _saleReturnRepository.GetAll();
                dgvSaleReturn.AutoGenerateColumns = true;
                dgvSaleReturn.DataSource = source;
                dgvSaleReturn.Columns["Id"].Visible = false;
                pbxSaleReturn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Load_Datagridview_Data_By_Date()
        {
            try
            {
                pbxSaleReturn.Visible = true;
                DateTime dt = Convert.ToDateTime(dtpSaleReturn.Value);
                String s1 = dt.ToString("yyyy-MM-dd");
                DateTime dtnew = Convert.ToDateTime(s1);

                var source = new BindingSource();
                source.DataSource = await _saleReturnRepository.GetAllByDate(dtnew);
                dgvSaleReturn.AutoGenerateColumns = true;
                dgvSaleReturn.DataSource = source;
                dgvSaleReturn.Columns["Id"].Visible = false;
                pbxSaleReturn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Load_Datagridview_Data_By_Name()
        {
            try
            {
                pbxSaleReturn.Visible = true;
                var source = new BindingSource();
                source.DataSource = await _saleReturnRepository.GetAllByName(txtFilterByName.Text);
                dgvSaleReturn.AutoGenerateColumns = true;
                dgvSaleReturn.DataSource = source;
                dgvSaleReturn.Columns["Id"].Visible = false;
                pbxSaleReturn.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void SaleReturnDashboard_Load(object sender, EventArgs e)
        {
            await Load_Datagridview_Data();
            await SetupSearchBox();
        }

        private async Task SetupSearchBox()
        {
            try
            {
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                collection.AddRange(await _saleReturnRepository.GetAllName());
                txtFilterByName.AutoCompleteCustomSource = collection;
                txtFilterByName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtFilterByName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtFilterByName.Text.Trim() != "")
            {
                await Load_Datagridview_Data_By_Name();
            }
        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
