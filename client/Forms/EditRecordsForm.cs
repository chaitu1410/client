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
        Transaction _transaction;

        public static event LoadData OnLoadData;

        public EditRecordsForm(Transaction transaction)
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
            _transaction = transaction;
        }
        bool flag = false;
        private void EditRecordsForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetupComboBox();
                txtAmount.Text = _transaction.Amount.ToString();
                txtExtra.Text = _transaction.Extras.ToString();
                cbxPaymentMethod.SelectedItem = _transaction.PaymentMethod;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private PaymentMethods GetSelectedPaymentMethod()
        {
            PaymentMethods paymentMethod;
            Enum.TryParse<PaymentMethods>(cbxPaymentMethod.SelectedValue.ToString(), out paymentMethod);
            return paymentMethod;
        }

       

        private void SetupComboBox()
        {
            try
            {
                cbxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethods));
                AutoCompleteStringCollection cbPaymentMethodsAutoCompleteStrings = new AutoCompleteStringCollection();
                cbPaymentMethodsAutoCompleteStrings.AddRange(Enum.GetNames(typeof(PaymentMethods)));
                cbxPaymentMethod.AutoCompleteCustomSource = cbPaymentMethodsAutoCompleteStrings;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete??", "Confirm Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _transactionRepository.Remove(_transaction);
                    OnLoadData();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                
            }
        }

        private  async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                _transaction.Amount = (decimal)Convert.ToDouble(txtAmount.Text);
                _transaction.Extras = (double)Convert.ToDouble(txtExtra.Text);
                _transaction.PaymentMethod = GetSelectedPaymentMethod();

                await _transactionRepository.Update(_transaction);
                OnLoadData();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlBody.ClientRectangle, Color.DarkSlateBlue, ButtonBorderStyle.None);
        }

        private void pnlBody_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void pnlBody_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlBody_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
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
