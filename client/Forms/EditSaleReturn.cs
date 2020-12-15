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
        public static event LoadData OnLoadData;

        public EditSaleReturn(SaleReturn saleReturn)
        {
            InitializeComponent();
            _saleReturnRepository = new SaleReturnRepository();
            _saleReturn = saleReturn;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete??", "Confirm Delete!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _saleReturnRepository.Remove(_saleReturn);
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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
                await _saleReturnRepository.Update(_saleReturn);
                OnLoadData();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditSaleReturn_Load(object sender, EventArgs e)
        {
            try
            {
                txtAmount.Text = _saleReturn.Amount.ToString();
                txtName.Text = _saleReturn.CustomerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
