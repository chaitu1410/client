using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnRecords_MouseEnter(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnRecords_MouseLeave(object sender, EventArgs e)
        {
            btnRecords.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnDailySale_MouseEnter(object sender, EventArgs e)
        {
            btnDailySale.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnDailySale_MouseLeave(object sender, EventArgs e)
        {
            btnDailySale.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnCredentials_MouseEnter(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnCredentials_MouseLeave(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 0, 53, 92);

        }
    }
}
