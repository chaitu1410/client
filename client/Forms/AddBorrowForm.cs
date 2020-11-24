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
    public partial class AddBorrowForm : Form
    {
        BorrowRepository _borrowRepository;
        bool flag = false;
        public AddBorrowForm()
        {
            InitializeComponent();
            _borrowRepository = new BorrowRepository();       
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Borrow _borrow = new Borrow()
            {
                Amount = (decimal)Convert.ToDouble(txtAmount.Text),
                CustomerName = Convert.ToString(txtName.Text),
                Date = DateTime.Now


            };
            _borrowRepository.Add(_borrow);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddBorrowForm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void AddBorrowForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void AddBorrowForm_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }
    }
}
