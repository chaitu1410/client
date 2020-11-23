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
    public partial class EditRecordsForm : Form
    {
        TransactionRepository _transactionRepository;
        
        public EditRecordsForm()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
             
        }
        bool flag = false;
        private void EditRecordsForm_Load(object sender, EventArgs e)
        {
            
          ///  _transactionRepository.Find(id);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditRecordsForm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void EditRecordsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true) 
            {
                this.Location = Cursor.Position;
            }
        }

        private void EditRecordsForm_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction()
            {
                Amount = (decimal)Convert.ToDouble(txtAmount.Text),
                Extras = (double)Convert.ToDouble(txtExtra.Text),
                PaymentMethod = PaymentMethods.Cash,
                Date = DateTime.Now


            };
            _transactionRepository.Update(transaction);
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            _transactionRepository.Remove(transaction);
        }
    }
}
