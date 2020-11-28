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
    public partial class TotalsaleDashboard : Form
    {
        TotalSaleRepository _totalsalerepository;
        TotalSale _totalsale;

        public TotalsaleDashboard()
        {
            InitializeComponent();
            _totalsalerepository = new TotalSaleRepository();
            _totalsale = new TotalSale();

        }

        private void dgvTotalSale_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTotalSale.CurrentRow != null)
            {
                var row = dgvTotalSale.CurrentRow.Cells;
                int id = Convert.ToInt32(row["Id"].Value);
                //Console.WriteLine(id);
                TotalSale _totalsale = _totalsalerepository.Find(id);
                EditTotalSale ets = new EditTotalSale(_totalsale);
                ets.Show();



            }


          
        }

        private void Totalsale_Load(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }

        private void dtpTotalSale_ValueChanged(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }

        private void Load_Datagridview_Data()
        {
           
            DateTime dt = Convert.ToDateTime(dtpTotalSale.Value);
            String s1 = dt.ToString("yyyy-MM-dd");
            DateTime dtnew = Convert.ToDateTime(s1);

            var source = new BindingSource();
            source.DataSource =  _totalsalerepository.GetByDate(dtnew).ToList();
            dgvTotalSale.AutoGenerateColumns = true;
            dgvTotalSale.DataSource = source;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            var source = new BindingSource();
            source.DataSource = _totalsalerepository.GetAll().ToList() ;
            dgvTotalSale.AutoGenerateColumns = true;
            dgvTotalSale.DataSource = source;
            
        }
    }
}
