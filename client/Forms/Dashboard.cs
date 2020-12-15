﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using client.Data;
using Squirrel;

namespace client.Forms
{
    public delegate void LoadData();
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
            try
            {
                pnlBody.Controls.Clear();
                BorrowsDashboard bd = new BorrowsDashboard();
                bd.TopLevel = false;
                pnlBody.Controls.Add(bd);
                bd.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                bd.Dock = DockStyle.Fill;
                bd.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                pnlBody.Controls.Clear();
                home home = new home();
                home.TopLevel = false;
                pnlBody.Controls.Add(home);
                home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnViewTotalSale_Click(object sender, EventArgs e)
        {
            try
            {
                pnlBody.Controls.Clear();
                TotalsaleDashboard totalsale = new TotalsaleDashboard();
                totalsale.TopLevel = false;
                pnlBody.Controls.Add(totalsale);
                totalsale.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                totalsale.Dock = DockStyle.Fill;
                totalsale.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                home home = new home();
                home.TopLevel = false;
                pnlBody.Controls.Add(home);
                home.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                home.Dock = DockStyle.Fill;
                home.Show();

                txtVersion.Text = "1.0.2";

                string path1 = @"c:\AdityaMedical\Update";
                string path2 = @"c:\AdityaMedical\Backup";

                if (!Directory.Exists(path1))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path1);
                }

                if (!Directory.Exists(path2))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path2);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSaleReturn_Click(object sender, EventArgs e)
        {
            try
            {
                pnlBody.Controls.Clear();
                SaleReturnDashboard saleReturnDashboard = new SaleReturnDashboard();
                saleReturnDashboard.TopLevel = false;
                pnlBody.Controls.Add(saleReturnDashboard);
                saleReturnDashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                saleReturnDashboard.Dock = DockStyle.Fill;
                saleReturnDashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaleReturn_MouseEnter(object sender, EventArgs e)
        {
            btnSaleReturn.BackColor = Color.FromArgb(0, 13, 72, 114);

        }

        private void btnSaleReturn_MouseLeave(object sender, EventArgs e)
        {
            btnSaleReturn.BackColor = Color.FromArgb(0, 0, 53, 92);
        }

        private void btnCredentials_Click(object sender, EventArgs e)
        {
            try
            {
                pnlBody.Controls.Clear();
                EditCredentialsDashboard editCredentialsDashboard = new EditCredentialsDashboard();
                editCredentialsDashboard.TopLevel = false;
                pnlBody.Controls.Add(editCredentialsDashboard);
                editCredentialsDashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                editCredentialsDashboard.Dock = DockStyle.Fill;
                editCredentialsDashboard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void pnlDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void pnlTopDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }

        private void pnlTopDashboard_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pnlTopDashboard_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string path = @"c:\AdityaMedical\Update";
            try
            {
                using(UpdateManager manager = new UpdateManager(path))
                {
                    await manager.UpdateApp();
                    var res = MessageBox.Show("Press Yes to restart Suit","Updated Successfully!!!",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if(res == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed To Update");
            }
        }
    }
}
