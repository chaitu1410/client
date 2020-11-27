
namespace client.Forms
{
    partial class BorrowsDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBorrows = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dtpCreditDeposit = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBorrowingBalance = new System.Windows.Forms.DateTimePicker();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dgvCreditDeposit = new System.Windows.Forms.DataGridView();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnClrFilter = new System.Windows.Forms.Button();
            this.lblCreditDeposit = new System.Windows.Forms.Label();
            this.lblBorrowingBalance = new System.Windows.Forms.Label();
            this.dgvBorrowingBalance = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBorrows
            // 
            this.lblBorrows.AutoSize = true;
            this.lblBorrows.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblBorrows.Location = new System.Drawing.Point(12, 20);
            this.lblBorrows.Name = "lblBorrows";
            this.lblBorrows.Size = new System.Drawing.Size(97, 25);
            this.lblBorrows.TabIndex = 1;
            this.lblBorrows.Text = "Borrows";
            this.lblBorrows.Click += new System.EventHandler(this.lblBorrows_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.White;
            this.pnlBody.Controls.Add(this.dtpCreditDeposit);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.dtpBorrowingBalance);
            this.pnlBody.Controls.Add(this.lblFilterBy);
            this.pnlBody.Controls.Add(this.dgvCreditDeposit);
            this.pnlBody.Controls.Add(this.btnClearFilter);
            this.pnlBody.Controls.Add(this.btnClrFilter);
            this.pnlBody.Controls.Add(this.lblCreditDeposit);
            this.pnlBody.Controls.Add(this.lblBorrowingBalance);
            this.pnlBody.Controls.Add(this.dgvBorrowingBalance);
            this.pnlBody.Location = new System.Drawing.Point(7, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(964, 670);
            this.pnlBody.TabIndex = 2;
            // 
            // dtpCreditDeposit
            // 
            this.dtpCreditDeposit.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpCreditDeposit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpCreditDeposit.Location = new System.Drawing.Point(569, 82);
            this.dtpCreditDeposit.Name = "dtpCreditDeposit";
            this.dtpCreditDeposit.Size = new System.Drawing.Size(230, 25);
            this.dtpCreditDeposit.TabIndex = 11;
            this.dtpCreditDeposit.ValueChanged += new System.EventHandler(this.dtpCreditDeposit_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(497, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Filter by";
            // 
            // dtpBorrowingBalance
            // 
            this.dtpBorrowingBalance.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpBorrowingBalance.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpBorrowingBalance.Location = new System.Drawing.Point(90, 82);
            this.dtpBorrowingBalance.Name = "dtpBorrowingBalance";
            this.dtpBorrowingBalance.Size = new System.Drawing.Size(230, 25);
            this.dtpBorrowingBalance.TabIndex = 9;
            this.dtpBorrowingBalance.ValueChanged += new System.EventHandler(this.dtpBorrowingBalance_ValueChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(18, 86);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(66, 17);
            this.lblFilterBy.TabIndex = 8;
            this.lblFilterBy.Text = "Filter by";
            // 
            // dgvCreditDeposit
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCreditDeposit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCreditDeposit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCreditDeposit.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCreditDeposit.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditDeposit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCreditDeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCreditDeposit.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCreditDeposit.Location = new System.Drawing.Point(497, 118);
            this.dgvCreditDeposit.Name = "dgvCreditDeposit";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCreditDeposit.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCreditDeposit.RowTemplate.Height = 25;
            this.dgvCreditDeposit.Size = new System.Drawing.Size(457, 488);
            this.dgvCreditDeposit.TabIndex = 7;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnClearFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(844, 612);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(110, 36);
            this.btnClearFilter.TabIndex = 5;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnClrFilter
            // 
            this.btnClrFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnClrFilter.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClrFilter.ForeColor = System.Drawing.Color.White;
            this.btnClrFilter.Location = new System.Drawing.Point(346, 612);
            this.btnClrFilter.Name = "btnClrFilter";
            this.btnClrFilter.Size = new System.Drawing.Size(110, 36);
            this.btnClrFilter.TabIndex = 4;
            this.btnClrFilter.Text = "Clear Filter";
            this.btnClrFilter.UseVisualStyleBackColor = false;
            this.btnClrFilter.Click += new System.EventHandler(this.btnClrFilter_Click);
            // 
            // lblCreditDeposit
            // 
            this.lblCreditDeposit.AutoSize = true;
            this.lblCreditDeposit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCreditDeposit.ForeColor = System.Drawing.Color.Black;
            this.lblCreditDeposit.Location = new System.Drawing.Point(660, 25);
            this.lblCreditDeposit.Name = "lblCreditDeposit";
            this.lblCreditDeposit.Size = new System.Drawing.Size(149, 22);
            this.lblCreditDeposit.TabIndex = 3;
            this.lblCreditDeposit.Text = "Credit Deposit\'s";
            // 
            // lblBorrowingBalance
            // 
            this.lblBorrowingBalance.AutoSize = true;
            this.lblBorrowingBalance.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBorrowingBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowingBalance.Location = new System.Drawing.Point(131, 25);
            this.lblBorrowingBalance.Name = "lblBorrowingBalance";
            this.lblBorrowingBalance.Size = new System.Drawing.Size(189, 22);
            this.lblBorrowingBalance.TabIndex = 2;
            this.lblBorrowingBalance.Text = "Borrowing Balance\'s";
            // 
            // dgvBorrowingBalance
            // 
            this.dgvBorrowingBalance.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvBorrowingBalance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBorrowingBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowingBalance.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBorrowingBalance.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowingBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBorrowingBalance.ColumnHeadersHeight = 50;
            this.dgvBorrowingBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowingBalance.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBorrowingBalance.Location = new System.Drawing.Point(13, 118);
            this.dgvBorrowingBalance.Name = "dgvBorrowingBalance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowingBalance.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBorrowingBalance.RowTemplate.Height = 25;
            this.dgvBorrowingBalance.Size = new System.Drawing.Size(443, 488);
            this.dgvBorrowingBalance.TabIndex = 0;
            this.dgvBorrowingBalance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowingBalance_CellDoubleClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(749, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear Filter";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(13, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear Filter";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(592, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Credit Deposit\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(116, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrowing Balance\'s";
            // 
            // dataGridView5
            // 
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(240, 150);
            this.dataGridView5.TabIndex = 0;
            // 
            // BorrowsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 742);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.lblBorrows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowsDashboard";
            this.Text = "BorrowsDashboard";
            this.Activated += new System.EventHandler(this.BorrowsDashboard_Activated);
            this.Load += new System.EventHandler(this.BorrowsDashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BorrowsDashboard_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BorrowsDashboard_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BorrowsDashboard_MouseUp);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreditDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowingBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBorrows;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnClrFilter;
        private System.Windows.Forms.Label lblCreditDeposit;
        private System.Windows.Forms.Label lblBorrowingBalance;
        private System.Windows.Forms.DataGridView dgvBorrowingBalance;
        private System.Windows.Forms.DataGridView dgvCreditDeposit;
        //////private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DateTimePicker dtpCreditDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBorrowingBalance;
        private System.Windows.Forms.Label lblFilterBy;
    }
}