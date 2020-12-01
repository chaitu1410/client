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
    public partial class EditSaleReturn : Form
    {
        SaleReturnRepository _saleReturnRepository;
        SaleReturn _saleReturn;
        bool flag = false;
        public EditSaleReturn(SaleReturn saleReturn)
        {
            InitializeComponent();
            _saleReturnRepository = new SaleReturnRepository();
            _saleReturn = saleReturn;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _saleReturnRepository.Remove(_saleReturn);
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == string.Empty || txtAmount.Text.Trim() == string.Empty)
            {
                MessageBox.Show("All fields required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtName.Text, "^[a-zA-Z]"))
            {
                MessageBox.Show("Invaild Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                txtName.Text.Remove(txtName.Text.Length - 1);
                return;
            }
            _saleReturn.Amount = (decimal)Convert.ToDouble(txtAmount.Text);
            _saleReturn.CustomerName = Convert.ToString(txtName.Text);




            _saleReturnRepository.Update(_saleReturn);

            this.Dispose();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditSaleReturn_Load(object sender, EventArgs e)
        {
            txtAmount.Text = _saleReturn.Amount.ToString();
            txtName.Text = _saleReturn.CustomerName.ToString();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlBody.ClientRectangle, Color.DarkSlateBlue, ButtonBorderStyle.None);

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
    }
}
