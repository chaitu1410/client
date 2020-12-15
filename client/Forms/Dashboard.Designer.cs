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
            this.PbxSaleReturn = new System.Windows.Forms.PictureBox();
            this.btnSaleReturn = new System.Windows.Forms.Button();
            this.pbxHome = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxCredentials = new System.Windows.Forms.PictureBox();
            this.btnCredentials = new System.Windows.Forms.Button();
            this.pbxDailySale = new System.Windows.Forms.PictureBox();
            this.btnViewTotalSale = new System.Windows.Forms.Button();
            this.pbxRecords = new System.Windows.Forms.PictureBox();
            this.btnViewBorrows = new System.Windows.Forms.Button();
            this.pnlTopDashboard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtVersion = new System.Windows.Forms.Label();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxSaleReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDailySale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecords)).BeginInit();
            this.pnlTopDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.pnlDashboard.Controls.Add(this.PbxSaleReturn);
            this.pnlDashboard.Controls.Add(this.btnSaleReturn);
            this.pnlDashboard.Controls.Add(this.pbxHome);
            this.pnlDashboard.Controls.Add(this.btnHome);
            this.pnlDashboard.Controls.Add(this.pictureBox1);
            this.pnlDashboard.Controls.Add(this.pbxCredentials);
            this.pnlDashboard.Controls.Add(this.btnCredentials);
            this.pnlDashboard.Controls.Add(this.pbxDailySale);
            this.pnlDashboard.Controls.Add(this.btnViewTotalSale);
            this.pnlDashboard.Controls.Add(this.pbxRecords);
            this.pnlDashboard.Controls.Add(this.btnViewBorrows);
            this.pnlDashboard.Controls.Add(this.pnlTopDashboard);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(323, 964);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDashboard_MouseDown);
            this.pnlDashboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDashboard_MouseMove);
            this.pnlDashboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDashboard_MouseUp);
            // 
            // PbxSaleReturn
            // 
            this.PbxSaleReturn.Image = ((System.Drawing.Image)(resources.GetObject("PbxSaleReturn.Image")));
            this.PbxSaleReturn.Location = new System.Drawing.Point(15, 480);
            this.PbxSaleReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PbxSaleReturn.Name = "PbxSaleReturn";
            this.PbxSaleReturn.Size = new System.Drawing.Size(55, 41);
            this.PbxSaleReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxSaleReturn.TabIndex = 11;
            this.PbxSaleReturn.TabStop = false;
            // 
            // btnSaleReturn
            // 
            this.btnSaleReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaleReturn.FlatAppearance.BorderSize = 0;
            this.btnSaleReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleReturn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaleReturn.ForeColor = System.Drawing.Color.White;
            this.btnSaleReturn.Location = new System.Drawing.Point(-2, 465);
            this.btnSaleReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaleReturn.Name = "btnSaleReturn";
            this.btnSaleReturn.Size = new System.Drawing.Size(323, 77);
            this.btnSaleReturn.TabIndex = 10;
            this.btnSaleReturn.Text = "SALE RETURN";
            this.btnSaleReturn.UseVisualStyleBackColor = true;
            this.btnSaleReturn.Click += new System.EventHandler(this.btnSaleReturn_Click);
            this.btnSaleReturn.MouseEnter += new System.EventHandler(this.btnSaleReturn_MouseEnter);
            this.btnSaleReturn.MouseLeave += new System.EventHandler(this.btnSaleReturn_MouseLeave);
            // 
            // pbxHome
            // 
            this.pbxHome.Image = ((System.Drawing.Image)(resources.GetObject("pbxHome.Image")));
            this.pbxHome.Location = new System.Drawing.Point(15, 227);
            this.pbxHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(55, 41);
            this.pbxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHome.TabIndex = 9;
            this.pbxHome.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(-2, 209);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(323, 77);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 357);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbxCredentials
            // 
            this.pbxCredentials.Image = ((System.Drawing.Image)(resources.GetObject("pbxCredentials.Image")));
            this.pbxCredentials.Location = new System.Drawing.Point(15, 740);
            this.pbxCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxCredentials.Name = "pbxCredentials";
            this.pbxCredentials.Size = new System.Drawing.Size(55, 41);
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
            this.btnCredentials.Location = new System.Drawing.Point(0, 725);
            this.btnCredentials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCredentials.Name = "btnCredentials";
            this.btnCredentials.Size = new System.Drawing.Size(321, 77);
            this.btnCredentials.TabIndex = 5;
            this.btnCredentials.Text = "CREDENTIALS";
            this.btnCredentials.UseVisualStyleBackColor = true;
            this.btnCredentials.Click += new System.EventHandler(this.btnCredentials_Click);
            this.btnCredentials.MouseEnter += new System.EventHandler(this.btnCredentials_MouseEnter);
            this.btnCredentials.MouseLeave += new System.EventHandler(this.btnCredentials_MouseLeave);
            // 
            // pbxDailySale
            // 
            this.pbxDailySale.Image = ((System.Drawing.Image)(resources.GetObject("pbxDailySale.Image")));
            this.pbxDailySale.Location = new System.Drawing.Point(15, 609);
            this.pbxDailySale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxDailySale.Name = "pbxDailySale";
            this.pbxDailySale.Size = new System.Drawing.Size(55, 41);
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
            this.btnViewTotalSale.Location = new System.Drawing.Point(0, 595);
            this.btnViewTotalSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewTotalSale.Name = "btnViewTotalSale";
            this.btnViewTotalSale.Size = new System.Drawing.Size(323, 77);
            this.btnViewTotalSale.TabIndex = 3;
            this.btnViewTotalSale.Text = "TOTAL SALE";
            this.btnViewTotalSale.UseVisualStyleBackColor = true;
            this.btnViewTotalSale.Click += new System.EventHandler(this.btnViewTotalSale_Click);
            this.btnViewTotalSale.MouseEnter += new System.EventHandler(this.btnDailySale_MouseEnter);
            this.btnViewTotalSale.MouseLeave += new System.EventHandler(this.btnDailySale_MouseLeave);
            // 
            // pbxRecords
            // 
            this.pbxRecords.Image = ((System.Drawing.Image)(resources.GetObject("pbxRecords.Image")));
            this.pbxRecords.Location = new System.Drawing.Point(719, 612);
            this.pbxRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxRecords.Name = "pbxRecords";
            this.pbxRecords.Size = new System.Drawing.Size(55, 41);
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
            this.btnViewBorrows.Location = new System.Drawing.Point(-2, 340);
            this.btnViewBorrows.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewBorrows.Name = "btnViewBorrows";
            this.btnViewBorrows.Size = new System.Drawing.Size(323, 77);
            this.btnViewBorrows.TabIndex = 1;
            this.btnViewBorrows.Text = "BORROW";
            this.btnViewBorrows.UseVisualStyleBackColor = true;
            this.btnViewBorrows.Click += new System.EventHandler(this.btnViewBorrows_Click);
            this.btnViewBorrows.MouseEnter += new System.EventHandler(this.btnRecords_MouseEnter);
            this.btnViewBorrows.MouseLeave += new System.EventHandler(this.btnRecords_MouseLeave);
            // 
            // pnlTopDashboard
            // 
            this.pnlTopDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.pnlTopDashboard.Controls.Add(this.txtVersion);
            this.pnlTopDashboard.Controls.Add(this.label1);
            this.pnlTopDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTopDashboard.Name = "pnlTopDashboard";
            this.pnlTopDashboard.Size = new System.Drawing.Size(323, 136);
            this.pnlTopDashboard.TabIndex = 0;
            this.pnlTopDashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopDashboard_MouseDown);
            this.pnlTopDashboard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopDashboard_MouseMove);
            this.pnlTopDashboard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopDashboard_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aditya Medical";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1499, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(333, 43);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1191, 908);
            this.pnlBody.TabIndex = 8;
            this.pnlBody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBody_MouseDown);
            this.pnlBody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBody_MouseMove);
            this.pnlBody.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBody_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1464, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1302, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Check For Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVersion
            // 
            this.txtVersion.AutoSize = true;
            this.txtVersion.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtVersion.ForeColor = System.Drawing.Color.White;
            this.txtVersion.Location = new System.Drawing.Point(111, 88);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(0, 17);
            this.txtVersion.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 964);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseUp);
            this.pnlDashboard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxSaleReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCredentials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDailySale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRecords)).EndInit();
            this.pnlTopDashboard.ResumeLayout(false);
            this.pnlTopDashboard.PerformLayout();
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
        private PictureBox pbxHome;
        private Button btnHome;
        private PictureBox pictureBox1;
        private Button btnMinimize;
        private PictureBox PbxSaleReturn;
        private Button btnSaleReturn;
        private Label label1;
        private Button btnUpdate;
        private Label txtVersion;
    }
}