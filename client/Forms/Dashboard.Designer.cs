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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pbxCredentials = new System.Windows.Forms.PictureBox();
            this.btnCredentials = new System.Windows.Forms.Button();
            this.pbxDailySale = new System.Windows.Forms.PictureBox();
            this.btnDailySale = new System.Windows.Forms.Button();
            this.pbxRecords = new System.Windows.Forms.PictureBox();
            this.btnRecords = new System.Windows.Forms.Button();
            this.pnlTopDashboard = new System.Windows.Forms.Panel();
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.pnlRecords = new System.Windows.Forms.Panel();
            this.btnAddRecords = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.btnSaleReturn = new System.Windows.Forms.Button();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
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
            this.pnlDashboard.Controls.Add(this.btnDailySale);
            this.pnlDashboard.Controls.Add(this.pbxRecords);
            this.pnlDashboard.Controls.Add(this.btnRecords);
            this.pnlDashboard.Controls.Add(this.pnlTopDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(1, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(283, 720);
            this.pnlDashboard.TabIndex = 0;
            // 
            // pbxCredentials
            // 
            this.pbxCredentials.Image = ((System.Drawing.Image)(resources.GetObject("pbxCredentials.Image")));
            this.pbxCredentials.Location = new System.Drawing.Point(39, 403);
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
            this.pbxDailySale.Location = new System.Drawing.Point(39, 285);
            this.pbxDailySale.Name = "pbxDailySale";
            this.pbxDailySale.Size = new System.Drawing.Size(48, 31);
            this.pbxDailySale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDailySale.TabIndex = 4;
            this.pbxDailySale.TabStop = false;
            // 
            // btnDailySale
            // 
            this.btnDailySale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDailySale.FlatAppearance.BorderSize = 0;
            this.btnDailySale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDailySale.ForeColor = System.Drawing.Color.White;
            this.btnDailySale.Location = new System.Drawing.Point(0, 273);
            this.btnDailySale.Name = "btnDailySale";
            this.btnDailySale.Size = new System.Drawing.Size(283, 58);
            this.btnDailySale.TabIndex = 3;
            this.btnDailySale.Text = "DAILY SALE";
            this.btnDailySale.UseVisualStyleBackColor = true;
            this.btnDailySale.MouseEnter += new System.EventHandler(this.btnDailySale_MouseEnter);
            this.btnDailySale.MouseLeave += new System.EventHandler(this.btnDailySale_MouseLeave);
            // 
            // pbxRecords
            // 
            this.pbxRecords.Image = ((System.Drawing.Image)(resources.GetObject("pbxRecords.Image")));
            this.pbxRecords.Location = new System.Drawing.Point(39, 168);
            this.pbxRecords.Name = "pbxRecords";
            this.pbxRecords.Size = new System.Drawing.Size(48, 31);
            this.pbxRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRecords.TabIndex = 2;
            this.pbxRecords.TabStop = false;
            // 
            // btnRecords
            // 
            this.btnRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRecords.ForeColor = System.Drawing.Color.White;
            this.btnRecords.Location = new System.Drawing.Point(0, 153);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(283, 58);
            this.btnRecords.TabIndex = 1;
            this.btnRecords.Text = "RECORDS";
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.MouseEnter += new System.EventHandler(this.btnRecords_MouseEnter);
            this.btnRecords.MouseLeave += new System.EventHandler(this.btnRecords_MouseLeave);
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
            // dgvRecords
            // 
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.RowTemplate.Height = 25;
            this.dgvRecords.Size = new System.Drawing.Size(893, 420);
            this.dgvRecords.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 723);
            this.Controls.Add(this.btnSaleReturn);
            this.Controls.Add(this.btnAddBorrow);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnAddRecords);
            this.Controls.Add(this.pnlRecords);
            this.Controls.Add(this.lblAllRecords);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
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
        private System.Windows.Forms.Button btnDailySale;
        private System.Windows.Forms.PictureBox pbxRecords;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Panel pnlTopDashboard;
        private System.Windows.Forms.PictureBox pbxCredentials;
        private System.Windows.Forms.Button btnCredentials;
        private System.Windows.Forms.Label lblAllRecords;
        private System.Windows.Forms.Panel pnlRecords;
        private System.Windows.Forms.Button btnAddRecords;
        private Button btnAddPayment;
        private Button btnAddBorrow;
        private Button btnSaleReturn;
        private DataGridView dgvRecords;
    }
}