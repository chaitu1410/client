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
    public partial class AddNewRecordsForm : Form
    {
        TransactionRepository _transactionRepository;
        public AddNewRecordsForm()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction()
            {
                Amount = (decimal)Convert.ToDouble(txtAmount.Text),
                Extras = (double)Convert.ToDouble(txtExtra.Text),
                PaymentMethod = PaymentMethods.Cash,
                Date = DateTime.Now


        };
             _transactionRepository.Add(transaction);
            

        }
    }
}
