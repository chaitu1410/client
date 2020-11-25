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
        }

        private void Load_Datagridview1_Data()
        {
             DateTime dt = Convert.ToDateTime(dtpBorrowingBalance.Value);
              String s1 = dt.ToString("yyyy-MM-dd");
              DateTime dtnew = Convert.ToDateTime(s1);

            var source = new BindingSource();
            source.DataSource = _borrowRepository.GetAllUndepositedByDate(dtnew).ToList();
            dgvBorrowingBalance.AutoGenerateColumns = true;             
            dgvBorrowingBalance.DataSource = source;
            dgvBorrowingBalance.Columns["IsReturned"].Visible = false;
            dgvBorrowingBalance.Columns["ReturnDate"].Visible = false;


        }
        private void Load_Datagridview2_Data()
        {
            // DateTime dt = Convert.ToDateTime(.Value);
             //String s1 = dt.ToString("yyyy-MM-dd");
            // DateTime dtnew = Convert.ToDateTime(s1);

            var source = new BindingSource();
            source.DataSource = _borrowRepository.GetAllDeposited().ToList();
            dgvCreditDeposit.AutoGenerateColumns = true;
            dgvCreditDeposit.DataSource = source;



        }

        private void BorrowsDashboard_Load(object sender, EventArgs e)
        {
            Load_Datagridview1_Data();
            Load_Datagridview2_Data();
        }

        private void dgvBorrowingBalance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBorrowingBalance.CurrentRow != null)
            {
                var row = dgvBorrowingBalance.CurrentRow.Cells;
                int id = Convert.ToInt32(row["Id"].Value);
                //Console.WriteLine(id);
                Borrow  borrow= _borrowRepository.Find(id);
                EditBorrowForm edf = new EditBorrowForm(borrow);
                edf.Show();


            }
           

        }

        private void btnViewBorrows_MouseEnter(object sender, EventArgs e)
        {
            btnViewBorrows.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnViewBorrows_MouseLeave(object sender, EventArgs e)
        {
            btnViewBorrows.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnViewTotalSale_MouseEnter(object sender, EventArgs e)
        {
            btnViewTotalSale.BackColor = Color.FromArgb(0, 13, 72, 114);

        }

        private void btnViewTotalSale_MouseLeave(object sender, EventArgs e)
        {
            btnViewTotalSale.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnCredentials_MouseEnter(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 13, 72, 114);

        }

        private void btnCredentials_MouseLeave(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 0, 53, 92);
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

        private void dtpBorrowingBalance_ValueChanged(object sender, EventArgs e)
        {
            Load_Datagridview1_Data();
        }
    }
}
