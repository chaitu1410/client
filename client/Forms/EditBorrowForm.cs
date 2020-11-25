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
    public partial class EditBorrowForm : Form
    {
        
        BorrowRepository _borrowRepository;
        Borrow _borrow;
        bool flag = false;
        public EditBorrowForm(Borrow borrow)
        {
            InitializeComponent();
            _borrowRepository = new BorrowRepository();
            _borrow =borrow;
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
             _borrow.Amount = (decimal)Convert.ToDouble(txtAmount.Text);
             _borrow.CustomerName = Convert.ToString(txtName.Text);
            _borrow.IsReturned = cbxIsDeposited.Checked;

            

            _borrowRepository.Update(_borrow);

            this.Dispose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _borrowRepository.Remove(_borrow);
            this.Dispose();
        }

        private void EditBorrowForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void EditBorrowForm_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void EditBorrowForm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void EditBorrowForm_Load(object sender, EventArgs e)
        {
            txtAmount.Text = _borrow.Amount.ToString();
            txtName.Text = _borrow.CustomerName.ToString();
            cbxIsDeposited.Checked = _borrow.IsReturned;
            if (_borrow.IsReturned)
            {
                cbxIsDeposited.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
