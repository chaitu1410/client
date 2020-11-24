using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using client.Data;
namespace client.Forms
{
    public partial class Dashboard : Form
    {
        TransactionRepository  _transactionRepository;

        public Dashboard()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
        }

        private void btnRecords_MouseEnter(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnRecords_MouseLeave(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnDailySale_MouseEnter(object sender, EventArgs e)
        {
            btnDailySale.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnDailySale_MouseLeave(object sender, EventArgs e)
        {
            btnDailySale.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnCredentials_MouseEnter(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnCredentials_MouseLeave(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 0, 53, 92);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Load_Datagridview_Data();



        }
        private void Load_Datagridview_Data()
        {
            DateTime dt = Convert.ToDateTime(dateTimePicker1.Value);
            String s1 = dt.ToString("yyyy-MM-dd");
            DateTime dtnew = Convert.ToDateTime(s1);

                var source = new BindingSource();
                source.DataSource = _transactionRepository.GetAllByDate(dtnew).ToList();
                dgvRecords.AutoGenerateColumns = true;
                dgvRecords.DataSource = source;

           

        }

        private void btnAddRecords_Click(object sender, EventArgs e)
        {
            AddNewRecordsForm frm = new AddNewRecordsForm();
            frm.Show();

        }

        private void dgvRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvRecords.CurrentRow!=null)
            {
                var row = dgvRecords.CurrentRow.Cells;
                int id = Convert.ToInt32(row["TransactionId"].Value);
                //Console.WriteLine(id);
                Transaction transaction = _transactionRepository.Find(id);
                EditRecordsForm f1 = new EditRecordsForm(transaction);
                f1.Show();

            }
            
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Load_Datagridview_Data();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            AddBorrowForm frm=new AddBorrowForm();
            frm.Show();
        }
    }
}
