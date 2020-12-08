
namespace client.Forms
{
    partial class home
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
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.dtpRecords = new System.Windows.Forms.DateTimePicker();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.btnAddBorrow = new System.Windows.Forms.Button();
            this.btnSaleReturn = new System.Windows.Forms.Button();
            this.pbxHome = new System.Windows.Forms.ProgressBar();
            this.btnAddRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblRecords.Location = new System.Drawing.Point(12, 25);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(92, 25);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Records";
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(12, 81);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(66, 17);
            this.lblFilterBy.TabIndex = 2;
            this.lblFilterBy.Text = "Filter by";
            // 
            // dtpRecords
            // 
            this.dtpRecords.CalendarFont = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpRecords.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpRecords.Location = new System.Drawing.Point(84, 77);
            this.dtpRecords.Name = "dtpRecords";
            this.dtpRecords.Size = new System.Drawing.Size(242, 25);
            this.dtpRecords.TabIndex = 3;
            this.dtpRecords.ValueChanged += new System.EventHandler(this.dtpRecords_ValueChanged);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToResizeRows = false;
            this.dgvRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecords.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecords.ColumnHeadersHeight = 50;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecords.GridColor = System.Drawing.Color.LightGray;
            this.dgvRecords.Location = new System.Drawing.Point(3, 108);
            this.dgvRecords.Name = "dgvRecords";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecords.RowHeadersVisible = false;
            this.dgvRecords.RowHeadersWidth = 50;
            this.dgvRecords.RowTemplate.Height = 40;
            this.dgvRecords.Size = new System.Drawing.Size(1036, 486);
            this.dgvRecords.TabIndex = 5;
            this.dgvRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecords_CellDoubleClick);
            // 
            // btnAddBorrow
            // 
            this.btnAddBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddBorrow.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBorrow.ForeColor = System.Drawing.Color.White;
            this.btnAddBorrow.Location = new System.Drawing.Point(12, 600);
            this.btnAddBorrow.Name = "btnAddBorrow";
            this.btnAddBorrow.Size = new System.Drawing.Size(245, 52);
            this.btnAddBorrow.TabIndex = 7;
            this.btnAddBorrow.Text = "+Add Borrow Cash(ctrl+b)";
            this.btnAddBorrow.UseVisualStyleBackColor = false;
            this.btnAddBorrow.Click += new System.EventHandler(this.btnAddBorrow_Click);
            // 
            // btnSaleReturn
            // 
            this.btnSaleReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnSaleReturn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaleReturn.ForeColor = System.Drawing.Color.White;
            this.btnSaleReturn.Location = new System.Drawing.Point(406, 600);
            this.btnSaleReturn.Name = "btnSaleReturn";
            this.btnSaleReturn.Size = new System.Drawing.Size(245, 52);
            this.btnSaleReturn.TabIndex = 8;
            this.btnSaleReturn.Text = "+ Add Sale Return(ctrl+s)";
            this.btnSaleReturn.UseVisualStyleBackColor = false;
            this.btnSaleReturn.Click += new System.EventHandler(this.btnSaleReturn_Click);
            // 
            // pbxHome
            // 
            this.pbxHome.Location = new System.Drawing.Point(406, 351);
            this.pbxHome.MarqueeAnimationSpeed = 50;
            this.pbxHome.Name = "pbxHome";
            this.pbxHome.Size = new System.Drawing.Size(202, 19);
            this.pbxHome.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbxHome.TabIndex = 9;
            // 
            // btnAddRecords
            // 
            this.btnAddRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnAddRecords.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRecords.ForeColor = System.Drawing.Color.White;
            this.btnAddRecords.Location = new System.Drawing.Point(785, 600);
            this.btnAddRecords.Name = "btnAddRecords";
            this.btnAddRecords.Size = new System.Drawing.Size(245, 52);
            this.btnAddRecords.TabIndex = 10;
            this.btnAddRecords.Text = "+Add New Record(ctrl+n)";
            this.btnAddRecords.UseVisualStyleBackColor = false;
            this.btnAddRecords.Click += new System.EventHandler(this.btnAddRecords_Click_1);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 681);
            this.Controls.Add(this.btnAddRecords);
            this.Controls.Add(this.pbxHome);
            this.Controls.Add(this.btnSaleReturn);
            this.Controls.Add(this.btnAddBorrow);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.dtpRecords);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.lblRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.home_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.DateTimePicker dtpRecords;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnAddBorrow;
        private System.Windows.Forms.Button btnSaleReturn;
        private System.Windows.Forms.ProgressBar pbxHome;
        private System.Windows.Forms.Button btnAddRecords;
    }
}