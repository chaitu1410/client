using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;
using System.Text.RegularExpressions;
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
       
        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pnlBody.ClientRectangle, Color.DarkSlateBlue, ButtonBorderStyle.None);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == string.Empty || txtAmount.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("All fields required.....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Borrow _borrow = new Borrow()
                {
                    Amount = (decimal)Convert.ToDouble(txtAmount.Text),
                    CustomerName = Convert.ToString(txtName.Text),
                    Date = DateTime.Now
                };
                await _borrowRepository.Add(_borrow);
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
    }
};
