using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace client.Forms
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
              components.Dispose();
            }
           base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pbxCredentials = new System.Windows.Forms.PictureBox();
            this.btnCredentials = new System.Windows.Forms.Button();
            this.pbxDailySale = new System.Windows.Forms.PictureBox();
            this.btnViewTotalSale = new System.Windows.Forms.Button();
            this.pbxRecords = new System.Windows.Forms.PictureBox();
            this.btnViewBorrows = new System.Windows.Forms.Button();
            this.pnlTopDashboard = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dtpRecords = new System.Windows.Forms.DateTimePicker();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.btnAddRecords = new System.Windows.Forms.Button();
            this.btnSaleReturn = new System.Windows.Forms.Button();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDailySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecords)).BeginInit();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.pnlDashboard.Controls.Add(this.pbxCredentials);
            this.pnlDashboard.Controls.Add(this.btnCredentials);
            this.pnlDashboard.Controls.Add(this.pbxDailySale);
            this.pnlDashboard.Controls.Add(this.btnViewTotalSale);
            this.pnlDashboard.Controls.Add(this.pbxRecords);
            this.pnlDashboard.Controls.Add(this.btnViewBorrows);
            this.pnlDashboard.Controls.Add(this.pnlTopDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(1, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(283, 710);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboard_Paint);
            // 
            // pbxCredentials
            // 
            this.pbxCredentials.Image = ((System.Drawing.Image)(resources.GetObject("pbxCredentials.Image")));
            this.pbxCredentials.Location = new System.Drawing.Point(11, 404);
            this.pbxCredentials.Name = "pbxCredentials";
            this.pbxCredentials.Size = new System.Drawing.Size(48, 31);
            this.pbxCredentials.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCredentials.TabIndex = 6;
            this.pbxCredentials.TabStop = false;
            // 
            // btnCredentials
            // 
            this.btnCredentials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredentials.FlatAppearance.BorderSize = 0;
            this.btnCredentials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCredentials.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCredentials.ForeColor = System.Drawing.Color.White;
            this.btnCredentials.Location = new System.Drawing.Point(3, 392);
            this.btnCredentials.Name = "btnCredentials";
            this.btnCredentials.Size = new System.Drawing.Size(281, 58);
            this.btnCredentials.TabIndex = 5;
            this.btnCredentials.Text = "CREDENTIALS";
            this.btnCredentials.UseVisualStyleBackColor = true;
            this.btnCredentials.MouseEnter += new System.EventHandler(this.btnCredentials_MouseEnter);
            this.btnCredentials.MouseLeave += new System.EventHandler(this.btnCredentials_MouseLeave);
            // 
            // pbxDailySale
            // 
            this.pbxDailySale.Image = ((System.Drawing.Image)(resources.GetObject("pbxDailySale.Image")));
            this.pbxDailySale.Location = new System.Drawing.Point(11, 285);
            this.pbxDailySale.Name = "pbxDailySale";
            this.pbxDailySale.Size = new System.Drawing.Size(48, 31);
            this.pbxDailySale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDailySale.TabIndex = 4;
            this.pbxDailySale.TabStop = false;
            // 
            // btnViewTotalSale
            // 
            this.btnViewTotalSale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewTotalSale.FlatAppearance.BorderSize = 0;
            this.btnViewTotalSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTotalSale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewTotalSale.ForeColor = System.Drawing.Color.White;
            this.btnViewTotalSale.Location = new System.Drawing.Point(0, 273);
            this.btnViewTotalSale.Name = "btnViewTotalSale";
            this.btnViewTotalSale.Size = new System.Drawing.Size(283, 58);
            this.btnViewTotalSale.TabIndex = 3;
            this.btnViewTotalSale.Text = "VIEW TOTAL SALE";
            this.btnViewTotalSale.UseVisualStyleBackColor = true;
            this.btnViewTotalSale.MouseEnter += new System.EventHandler(this.btnDailySale_MouseEnter);
            this.btnViewTotalSale.MouseLeave += new System.EventHandler(this.btnDailySale_MouseLeave);
            // 
            // pbxRecords
            // 
            this.pbxRecords.Image = ((System.Drawing.Image)(resources.GetObject("pbxRecords.Image")));
            this.pbxRecords.Location = new System.Drawing.Point(11, 167);
            this.pbxRecords.Name = "pbxRecords";
            this.pbxRecords.Size = new System.Drawing.Size(48, 31);
            this.pbxRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRecords.TabIndex = 2;
            this.pbxRecords.TabStop = false;
            // 
            // btnViewBorrows
            // 
            this.btnViewBorrows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBorrows.FlatAppearance.BorderSize = 0;
            this.btnViewBorrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBorrows.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewBorrows.ForeColor = System.Drawing.Color.White;
            this.btnViewBorrows.Location = new System.Drawing.Point(0, 153);
            this.btnViewBorrows.Name = "btnViewBorrows";
            this.btnViewBorrows.Size = new System.Drawing.Size(283, 58);
            this.btnViewBorrows.TabIndex = 1;
            this.btnViewBorrows.Text = "VIEW BORROWS";
            this.btnViewBorrows.UseVisualStyleBackColor = true;
            this.btnViewBorrows.Click += new System.EventHandler(this.btnViewBorrows_Click);
            this.btnViewBorrows.MouseEnter += new System.EventHandler(this.btnRecords_MouseEnter);
            this.btnViewBorrows.MouseLeave += new System.EventHandler(this.btnRecords_MouseLeave);
            // 
            // pnlTopDashboard
            // 
            this.pnlTopDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.pnlTopDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDashboard.Name = "pnlTopDashboard";
            this.pnlTopDashboard.Size = new System.Drawing.Size(283, 102);
            this.pnlTopDashboard.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1149, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dtpRecords);
            this.pnlBody.Controls.Add(this.lblFilterBy);
            this.pnlBody.Controls.Add(this.btnAddRecords);
            this.pnlBody.Controls.Add(this.btnSaleReturn);
            this.pnlBody.Controls.Add(this.btnAddBorrow);
            this.pnlBody.Controls.Add(this.btnAddPayment);
            this.pnlBody.Controls.Add(this.dgvRecords);
            this.pnlBody.Controls.Add(this.lblAllRecords);
            this.pnlBody.Location = new System.Drawing.Point(290, 32);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(886, 669);
            this.pnlBody.TabIndex = 8;
            // 
            // dtpRecords
            // 
            this.dtpRecords.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpRecords.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpRecords.Location = new System.Drawing.Point(86, 68);
            this.dtpRecords.Name = "dtpRecords";
            this.dtpRecords.Size = new System.Drawing.Size(200, 25);
            this.dtpRecords.TabIndex = 7;
            this.dtpRecords.ValueChanged += new System.EventHandler(this.dtpRecords_ValueChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(13, 74);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(67, 17);
            this.lblFilterBy.TabIndex = 6;
            this.lblFilterBy.Text = "Filter By";
            // 
            // btnAddRecords
            // 
            this.btnAddRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddRecords.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRecords.ForeColor = System.Drawing.Color.White;
            this.btnAddRecords.Location = new System.Drawing.Point(654, 41);
            this.btnAddRecords.Name = "btnAddRecords";
            this.btnAddRecords.Size = new System.Drawing.Size(197, 52);
            this.btnAddRecords.TabIndex = 5;
            this.btnAddRecords.Text = "+Add New Records";
            this.btnAddRecords.UseVisualStyleBackColor = false;
            this.btnAddRecords.Click += new System.EventHandler(this.btnAddRecords_Click);
            // 
            // btnSaleReturn
            // 
            this.btnSaleReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSaleReturn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaleReturn.ForeColor = System.Drawing.Color.White;
            this.btnSaleReturn.Location = new System.Drawing.Point(654, 564);
            this.btnSaleReturn.Name = "btnSaleReturn";
            this.btnSaleReturn.Size = new System.Drawing.Size(197, 52);
            this.btnSaleReturn.TabIndex = 4;
            this.btnSaleReturn.Text = "Sale Return";
            this.btnSaleReturn.UseVisualStyleBackColor = false;
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddBorrow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBorrow.ForeColor = System.Drawing.Color.White;
            this.btnAddBorrow.Location = new System.Drawing.Point(337, 564);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(197, 52);
            this.btnAddBorrow.TabIndex = 3;
            this.btnAddBorrow.Text = "+Add Borrow Cash";
            this.btnAddBorrow.UseVisualStyleBackColor = false;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddPayment.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.Location = new System.Drawing.Point(32, 564);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(197, 52);
            this.btnAddPayment.TabIndex = 2;
            this.btnAddPayment.Text = "+Add Payment Method";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            // 
            // dgvRecords
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecords.ColumnHeadersHeight = 50;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecords.GridColor = System.Drawing.Color.White;
            this.dgvRecords.Location = new System.Drawing.Point(0, 110);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowTemplate.Height = 30;
            this.dgvRecords.Size = new System.Drawing.Size(886, 426);
            this.dgvRecords.TabIndex = 1;
            this.dgvRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellDoubleClick);
            // 
            // lblAllRecords
            // 
            this.lblAllRecords.AutoSize = true;
            this.lblAllRecords.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblAllRecords.Location = new System.Drawing.Point(23, 13);
            this.lblAllRecords.Name = "lblAllRecords";
            this.lblAllRecords.Size = new System.Drawing.Size(123, 25);
            this.lblAllRecords.TabIndex = 0;
            this.lblAllRecords.Text = "All Records";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 713);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredentials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDailySale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecords)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.PictureBox pbxDailySale;
        private System.Windows.Forms.Button btnViewTotalSale;
        private System.Windows.Forms.PictureBox pbxRecords;
        private System.Windows.Forms.Button btnViewBorrows;
        private System.Windows.Forms.Panel pnlTopDashboard;
        private System.Windows.Forms.PictureBox pbxCredentials;
        private System.Windows.Forms.Button btnCredentials;
        private Button btnClose;
        private Panel pnlBody;
        private DataGridView dgvRecords;
        private Label lblAllRecords;
        private Button btnAddRecords;
        private Button btnSaleReturn;
        private Button btnAddBorrow;
        private Button btnAddPayment;
        private DateTimePicker dtpRecords;
        private Label lblFilterBy;
    }
}