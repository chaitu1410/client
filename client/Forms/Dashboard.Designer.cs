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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pbxCredentials = new System.Windows.Forms.PictureBox();
            this.btnCredentials = new System.Windows.Forms.Button();
            this.pbxDailySale = new System.Windows.Forms.PictureBox();
            this.btnViewTotalSale = new System.Windows.Forms.Button();
            this.pbxRecords = new System.Windows.Forms.PictureBox();
            this.btnViewBorrows = new System.Windows.Forms.Button();
            this.pnlTopDashboard = new System.Windows.Forms.Panel();
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.btnAddRecords = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.btnSaleReturn = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDailySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecords)).BeginInit();
            this.pnlRecords.SuspendLayout();
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
            this.pnlDashboard.Size = new System.Drawing.Size(283, 701);
            this.pnlDashboard.TabIndex = 0;
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
            this.pbxRecords.MouseEnter += new System.EventHandler(this.pbxRecords_MouseEnter);
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
            // lblAllRecords
            // 
            this.lblAllRecords.AutoSize = true;
            this.lblAllRecords.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAllRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblAllRecords.Location = new System.Drawing.Point(313, 52);
            this.lblAllRecords.Name = "lblAllRecords";
            this.lblAllRecords.Size = new System.Drawing.Size(123, 25);
            this.lblAllRecords.TabIndex = 1;
            this.lblAllRecords.Text = "All Records";
            // 
            // pnlRecords
            // 
            this.pnlRecords.Controls.Add(this.dgvRecords);
            this.pnlRecords.Location = new System.Drawing.Point(283, 139);
            this.pnlRecords.Name = "pnlRecords";
            this.pnlRecords.Size = new System.Drawing.Size(893, 420);
            this.pnlRecords.TabIndex = 2;
            // 
            // dgvRecords
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecords.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvRecords.Name = "dgvRecords";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecords.RowTemplate.Height = 25;
            this.dgvRecords.Size = new System.Drawing.Size(893, 420);
            this.dgvRecords.TabIndex = 0;
            this.dgvRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellDoubleClick);
            // 
            // btnAddRecords
            // 
            this.btnAddRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddRecords.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRecords.ForeColor = System.Drawing.Color.White;
            this.btnAddRecords.Location = new System.Drawing.Point(976, 86);
            this.btnAddRecords.Name = "btnAddRecords";
            this.btnAddRecords.Size = new System.Drawing.Size(170, 47);
            this.btnAddRecords.TabIndex = 0;
            this.btnAddRecords.Text = "+Add New Records";
            this.btnAddRecords.UseVisualStyleBackColor = false;
            this.btnAddRecords.Click += new System.EventHandler(this.btnAddRecords_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddPayment.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddPayment.ForeColor = System.Drawing.Color.White;
            this.btnAddPayment.Location = new System.Drawing.Point(313, 579);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(197, 52);
            this.btnAddPayment.TabIndex = 3;
            this.btnAddPayment.Text = "+Add Payment Method";
            this.btnAddPayment.UseVisualStyleBackColor = false;
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddBorrow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBorrow.ForeColor = System.Drawing.Color.White;
            this.btnAddBorrow.Location = new System.Drawing.Point(630, 579);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(197, 52);
            this.btnAddBorrow.TabIndex = 4;
            this.btnAddBorrow.Text = "+Add Borrow Cash";
            this.btnAddBorrow.UseVisualStyleBackColor = false;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // btnSaleReturn
            // 
            this.btnSaleReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSaleReturn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaleReturn.ForeColor = System.Drawing.Color.White;
            this.btnSaleReturn.Location = new System.Drawing.Point(949, 579);
            this.btnSaleReturn.Name = "btnSaleReturn";
            this.btnSaleReturn.Size = new System.Drawing.Size(197, 52);
            this.btnSaleReturn.TabIndex = 5;
            this.btnSaleReturn.Text = "Sale Return";
            this.btnSaleReturn.UseVisualStyleBackColor = false;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.ForeColor = System.Drawing.Color.Black;
            this.lblFilterBy.Location = new System.Drawing.Point(290, 110);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(61, 17);
            this.lblFilterBy.TabIndex = 1;
            this.lblFilterBy.Text = "Filter by";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 704);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.btnSaleReturn);
            this.Controls.Add(this.btnAddBorrow);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnAddRecords);
            this.Controls.Add(this.pnlRecords);
            this.Controls.Add(this.lblAllRecords);
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
            this.pnlRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblAllRecords;
        private System.Windows.Forms.Panel pnlRecords;
        private System.Windows.Forms.Button btnAddRecords;
        private Button btnAddPayment;
        private Button btnAddBorrow;
        private Button btnSaleReturn;
        public DataGridView dgvRecords;
        private Label lblFilterBy;
        private DateTimePicker dateTimePicker1;
        private Button btnClose;
    }
}