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
        bool flag = false;

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
                PaymentMethod = GetSelectedPaymentMethod(),
                Date = DateTime.Now
            };
             _transactionRepository.Add(transaction);
            this.Dispose();
        }

        private PaymentMethods GetSelectedPaymentMethod()
        {
            PaymentMethods paymentMethod;
            Enum.TryParse<PaymentMethods>(cbxPaymentMethod.SelectedValue.ToString(), out paymentMethod);
            return paymentMethod;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddNewRecordsForm_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void AddNewRecordsForm_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void AddNewRecordsForm_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void AddNewRecordsForm_Load(object sender, EventArgs e)
        {
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            cbxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethods));
            AutoCompleteStringCollection cbPaymentMethodsAutoCompleteStrings = new AutoCompleteStringCollection();
            cbPaymentMethodsAutoCompleteStrings.AddRange(Enum.GetNames(typeof(PaymentMethods)));
            cbxPaymentMethod.AutoCompleteCustomSource = cbPaymentMethodsAutoCompleteStrings;
            cbxPaymentMethod.SelectedIndex = 0;
        }
    }
}
