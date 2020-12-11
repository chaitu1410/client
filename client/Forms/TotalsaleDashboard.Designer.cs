﻿
namespace client.Forms
{
    partial class TotalsaleDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTotalSale = new System.Windows.Forms.Label();
            this.dgvTotalSale = new System.Windows.Forms.DataGridView();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dtpTotalSale = new System.Windows.Forms.DateTimePicker();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.pbxTotalSale = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.AutoSize = true;
            this.lblTotalSale.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblTotalSale.Location = new System.Drawing.Point(12, 25);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(104, 25);
            this.lblTotalSale.TabIndex = 0;
            this.lblTotalSale.Text = "Total Sale";
            // 
            // dgvTotalSale
            // 
            this.dgvTotalSale.AllowUserToAddRows = false;
            this.dgvTotalSale.AllowUserToResizeColumns = false;
            this.dgvTotalSale.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvTotalSale.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotalSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotalSale.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotalSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotalSale.ColumnHeadersHeight = 60;
            this.dgvTotalSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotalSale.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotalSale.GridColor = System.Drawing.Color.LightGray;
            this.dgvTotalSale.Location = new System.Drawing.Point(3, 144);
            this.dgvTotalSale.Name = "dgvTotalSale";
            this.dgvTotalSale.RowHeadersVisible = false;
            this.dgvTotalSale.RowHeadersWidth = 50;
            this.dgvTotalSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTotalSale.RowTemplate.Height = 50;
            this.dgvTotalSale.Size = new System.Drawing.Size(1036, 486);
            this.dgvTotalSale.TabIndex = 1;
            this.dgvTotalSale.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTotalSale_CellDoubleClick);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(12, 107);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(67, 17);
            this.lblFilterBy.TabIndex = 2;
            this.lblFilterBy.Text = "Filter By";
            // 
            // dtpTotalSale
            // 
            this.dtpTotalSale.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpTotalSale.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpTotalSale.Location = new System.Drawing.Point(85, 104);
            this.dtpTotalSale.Name = "dtpTotalSale";
            this.dtpTotalSale.Size = new System.Drawing.Size(234, 25);
            this.dtpTotalSale.TabIndex = 3;
            this.dtpTotalSale.ValueChanged += new System.EventHandler(this.dtpTotalSale_ValueChanged);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(886, 645);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(153, 48);
            this.btnClearFilter.TabIndex = 4;
            this.btnClearFilter.Text = "View All";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // pbxTotalSale
            // 
            this.pbxTotalSale.Location = new System.Drawing.Point(415, 348);
            this.pbxTotalSale.Name = "pbxTotalSale";
            this.pbxTotalSale.Size = new System.Drawing.Size(212, 23);
            this.pbxTotalSale.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbxTotalSale.TabIndex = 5;
            // 
            // TotalsaleDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 742);
            this.Controls.Add(this.pbxTotalSale);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.dtpTotalSale);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.dgvTotalSale);
            this.Controls.Add(this.lblTotalSale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TotalsaleDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totalsale";
            this.Load += new System.EventHandler(this.Totalsale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSale;
        private System.Windows.Forms.DataGridView dgvTotalSale;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.DateTimePicker dtpTotalSale;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ProgressBar pbxTotalSale;
    }
}