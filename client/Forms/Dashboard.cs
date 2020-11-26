using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using client.Data;
namespace client.Forms
{
    public partial class Dashboard : Form
    {
        TransactionRepository _transactionRepository;
        bool flag = false;

        public Dashboard()
        {
            InitializeComponent();
            _transactionRepository = new TransactionRepository();
            
        }

        private void btnRecords_MouseEnter(object sender, EventArgs e)
        {
            btnViewBorrows.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnRecords_MouseLeave(object sender, EventArgs e)
        {
            btnViewBorrows.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnDailySale_MouseEnter(object sender, EventArgs e)
        {
            btnViewTotalSale.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnDailySale_MouseLeave(object sender, EventArgs e)
        {
            btnViewTotalSale.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnCredentials_MouseEnter(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 13, 72, 114);
        }

        private void btnCredentials_MouseLeave(object sender, EventArgs e)
        {
            btnCredentials.BackColor = Color.FromArgb(0, 0, 53, 92);

        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            Application.Exit();
        }

        private void btnViewBorrows_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            BorrowsDashboard bd = new BorrowsDashboard();
            bd.TopLevel = false;
            pnlBody.Controls.Add(bd);
            bd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            bd.Dock = DockStyle.Fill;
            bd.Show();
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(0, 13, 72, 114);

        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(0, 0, 53, 92);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            home home = new home();
            home.TopLevel = false;
            pnlBody.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            home home = new home();
            home.TopLevel = false;
            pnlBody.Controls.Add(home);
            home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.Black;
           
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
            btnClose.ForeColor = Color.Black;

        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void Dashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void Dashboard_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
