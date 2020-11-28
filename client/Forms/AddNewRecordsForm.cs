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

        public static event LoadData OnLoadData;

        public AddNewRecordsForm()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
        }

        private PaymentMethods GetSelectedPaymentMethod()
        {
            PaymentMethods paymentMethod;
            Enum.TryParse<PaymentMethods>(cbxPaymentMethod.SelectedValue.ToString(), out paymentMethod);
            return paymentMethod;
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

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlBody.ClientRectangle, Color.DarkSlateBlue,ButtonBorderStyle.None);
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


       

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if(txtAmount.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Please Enter Amount....", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Transaction transaction = new Transaction()
            {
                Amount = (decimal)Convert.ToDouble(txtAmount.Text),
                Extras = (double)Convert.ToDouble(txtExtra.Text),
                PaymentMethod = GetSelectedPaymentMethod(),
                Date = DateTime.Now
            };
            await _transactionRepository.Add(transaction);
            OnLoadData();
            this.Dispose();
        }

        private void pnlBody_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void pnlBody_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void pnlBody_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') 
            {
                e.Handled = false; 
            }
            else
            {
                e.Handled = true; 
            }
        }

        private void txtExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

       
    }
}
