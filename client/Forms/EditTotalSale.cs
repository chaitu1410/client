﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using client.Data;

namespace client.Forms
{
    public partial class EditTotalSale : Form
    {
        TotalSaleRepository _totalsalerepository;
        TotalSale _totalsale;
        bool flag = false;
        public EditTotalSale(TotalSale totalSale)
        {
            InitializeComponent();
            _totalsalerepository = new TotalSaleRepository();
            _totalsale = totalSale;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await _totalsalerepository.Remove(_totalsale);
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGeneratePdf_Click(object sender, EventArgs e)
        {

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

        private void EditTotalSale_Load(object sender, EventArgs e)
        {
            txtCashAmount.Text = _totalsale.CashAmount.ToString();
            txtCardAmount.Text = _totalsale.CardAmount.ToString();
            txtUpiAmount.Text = _totalsale.OnlineAmount.ToString();
            txtSaleReturnAmount.Text = _totalsale.SaleReturnAmount.ToString();
            txtTotalSale.Text = _totalsale.TotalSaleAmount.ToString();
            txtExtraAmount.Text = _totalsale.ExtraAmount.ToString();

        }
    }
}
