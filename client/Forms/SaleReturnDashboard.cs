using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using client.Data;

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
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource =  _saleReturnRepository.GetAll();
            dgvSaleReturn.AutoGenerateColumns = true;
            dgvSaleReturn.DataSource = source;
            dgvSaleReturn.Columns["Id"].Visible = false;
        }

        private void dgvSaleReturn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSaleReturn.CurrentRow != null)
            {
                var row = dgvSaleReturn.CurrentRow.Cells;
                int id = Convert.ToInt32(row["Id"].Value);
                //Console.WriteLine(id);
                SaleReturn _saleReturn = _saleReturnRepository.Find(id);
                EditSaleReturn editSaleReturn = new EditSaleReturn(_saleReturn);
                editSaleReturn.Show();
               
            }
        }

        private void dtpSaleReturn_ValueChanged(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }

        private void SaleReturnDashboard_Load(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }
        private async void Load_Datagridview_Data()
        {

            DateTime dt = Convert.ToDateTime(dtpSaleReturn.Value);
            String s1 = dt.ToString("yyyy-MM-dd");
            DateTime dtnew = Convert.ToDateTime(s1);

            var source = new BindingSource();
            source.DataSource =  _saleReturnRepository.GetAllByDate(dtnew).ToList();
            dgvSaleReturn.AutoGenerateColumns = true;
            dgvSaleReturn.DataSource = source;
            dgvSaleReturn.Columns["Id"].Visible = false;
        }

        private void SaleReturnDashboard_Activated(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
                
        }
    }
}
