
namespace client.Forms
{
    partial class EditTotalSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTotalSale));
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGeneratePdf = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTotalSale = new System.Windows.Forms.TextBox();
            this.txtExtraAmount = new System.Windows.Forms.TextBox();
            this.txtUpiAmount = new System.Windows.Forms.TextBox();
            this.txtCardAmount = new System.Windows.Forms.TextBox();
            this.txtSaleReturnAmount = new System.Windows.Forms.TextBox();
            this.txtCashAmount = new System.Windows.Forms.TextBox();
            this.lblTotalSaleAmount = new System.Windows.Forms.Label();
            this.lblExtraAmount = new System.Windows.Forms.Label();
            this.lblUpiAmount = new System.Windows.Forms.Label();
            this.lblCardAmount = new System.Windows.Forms.Label();
            this.lblSaleReturnAmount = new System.Windows.Forms.Label();
            this.lblCashAmount = new System.Windows.Forms.Label();
            this.lblEditTotalSale = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBody.Controls.Add(this.pictureBox1);
            this.pnlBody.Controls.Add(this.btnGeneratePdf);
            this.pnlBody.Controls.Add(this.btnDelete);
            this.pnlBody.Controls.Add(this.btnUpdate);
            this.pnlBody.Controls.Add(this.txtTotalSale);
            this.pnlBody.Controls.Add(this.txtExtraAmount);
            this.pnlBody.Controls.Add(this.txtUpiAmount);
            this.pnlBody.Controls.Add(this.txtCardAmount);
            this.pnlBody.Controls.Add(this.txtSaleReturnAmount);
            this.pnlBody.Controls.Add(this.txtCashAmount);
            this.pnlBody.Controls.Add(this.lblTotalSaleAmount);
            this.pnlBody.Controls.Add(this.lblExtraAmount);
            this.pnlBody.Controls.Add(this.lblUpiAmount);
            this.pnlBody.Controls.Add(this.lblCardAmount);
            this.pnlBody.Controls.Add(this.lblSaleReturnAmount);
            this.pnlBody.Controls.Add(this.lblCashAmount);
            this.pnlBody.Controls.Add(this.lblEditTotalSale);
            this.pnlBody.Location = new System.Drawing.Point(2, 4);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(595, 870);
            this.pnlBody.TabIndex = 0;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            this.pnlBody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBody_MouseDown);
            this.pnlBody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBody_MouseMove);
            this.pnlBody.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBody_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnGeneratePdf
            // 
            this.btnGeneratePdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnGeneratePdf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeneratePdf.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneratePdf.Location = new System.Drawing.Point(323, 141);
            this.btnGeneratePdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGeneratePdf.Name = "btnGeneratePdf";
            this.btnGeneratePdf.Size = new System.Drawing.Size(201, 61);
            this.btnGeneratePdf.TabIndex = 15;
            this.btnGeneratePdf.Text = "Generate PDF";
            this.btnGeneratePdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneratePdf.UseVisualStyleBackColor = false;
            this.btnGeneratePdf.Click += new System.EventHandler(this.btnGeneratePdf_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(256, 787);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 59);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(152)))), ((int)(((byte)(207)))));
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(402, 787);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 59);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Cancel";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTotalSale
            // 
            this.txtTotalSale.BackColor = System.Drawing.Color.White;
            this.txtTotalSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalSale.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalSale.Location = new System.Drawing.Point(238, 713);
            this.txtTotalSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotalSale.Name = "txtTotalSale";
            this.txtTotalSale.ReadOnly = true;
            this.txtTotalSale.Size = new System.Drawing.Size(287, 31);
            this.txtTotalSale.TabIndex = 12;
            // 
            // txtExtraAmount
            // 
            this.txtExtraAmount.BackColor = System.Drawing.Color.White;
            this.txtExtraAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtraAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtExtraAmount.Location = new System.Drawing.Point(238, 617);
            this.txtExtraAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtExtraAmount.Name = "txtExtraAmount";
            this.txtExtraAmount.ReadOnly = true;
            this.txtExtraAmount.Size = new System.Drawing.Size(287, 31);
            this.txtExtraAmount.TabIndex = 11;
            // 
            // txtUpiAmount
            // 
            this.txtUpiAmount.BackColor = System.Drawing.Color.White;
            this.txtUpiAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUpiAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUpiAmount.Location = new System.Drawing.Point(238, 520);
            this.txtUpiAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpiAmount.Name = "txtUpiAmount";
            this.txtUpiAmount.ReadOnly = true;
            this.txtUpiAmount.Size = new System.Drawing.Size(287, 31);
            this.txtUpiAmount.TabIndex = 10;
            // 
            // txtCardAmount
            // 
            this.txtCardAmount.BackColor = System.Drawing.Color.White;
            this.txtCardAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCardAmount.Location = new System.Drawing.Point(238, 423);
            this.txtCardAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardAmount.Name = "txtCardAmount";
            this.txtCardAmount.ReadOnly = true;
            this.txtCardAmount.Size = new System.Drawing.Size(287, 31);
            this.txtCardAmount.TabIndex = 9;
            // 
            // txtSaleReturnAmount
            // 
            this.txtSaleReturnAmount.BackColor = System.Drawing.Color.White;
            this.txtSaleReturnAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaleReturnAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSaleReturnAmount.Location = new System.Drawing.Point(238, 323);
            this.txtSaleReturnAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaleReturnAmount.Name = "txtSaleReturnAmount";
            this.txtSaleReturnAmount.ReadOnly = true;
            this.txtSaleReturnAmount.Size = new System.Drawing.Size(287, 31);
            this.txtSaleReturnAmount.TabIndex = 8;
            // 
            // txtCashAmount
            // 
            this.txtCashAmount.BackColor = System.Drawing.Color.White;
            this.txtCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCashAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCashAmount.Location = new System.Drawing.Point(238, 231);
            this.txtCashAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCashAmount.Name = "txtCashAmount";
            this.txtCashAmount.ReadOnly = true;
            this.txtCashAmount.Size = new System.Drawing.Size(287, 31);
            this.txtCashAmount.TabIndex = 7;
            // 
            // lblTotalSaleAmount
            // 
            this.lblTotalSaleAmount.AutoSize = true;
            this.lblTotalSaleAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSaleAmount.ForeColor = System.Drawing.Color.Black;
            this.lblTotalSaleAmount.Location = new System.Drawing.Point(118, 723);
            this.lblTotalSaleAmount.Name = "lblTotalSaleAmount";
            this.lblTotalSaleAmount.Size = new System.Drawing.Size(98, 23);
            this.lblTotalSaleAmount.TabIndex = 6;
            this.lblTotalSaleAmount.Text = "Total Sale";
            // 
            // lblExtraAmount
            // 
            this.lblExtraAmount.AutoSize = true;
            this.lblExtraAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExtraAmount.ForeColor = System.Drawing.Color.Black;
            this.lblExtraAmount.Location = new System.Drawing.Point(83, 620);
            this.lblExtraAmount.Name = "lblExtraAmount";
            this.lblExtraAmount.Size = new System.Drawing.Size(137, 23);
            this.lblExtraAmount.TabIndex = 5;
            this.lblExtraAmount.Text = "Extra Amount";
            // 
            // lblUpiAmount
            // 
            this.lblUpiAmount.AutoSize = true;
            this.lblUpiAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUpiAmount.ForeColor = System.Drawing.Color.Black;
            this.lblUpiAmount.Location = new System.Drawing.Point(97, 520);
            this.lblUpiAmount.Name = "lblUpiAmount";
            this.lblUpiAmount.Size = new System.Drawing.Size(120, 23);
            this.lblUpiAmount.TabIndex = 4;
            this.lblUpiAmount.Text = "UPI Amount";
            // 
            // lblCardAmount
            // 
            this.lblCardAmount.AutoSize = true;
            this.lblCardAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCardAmount.ForeColor = System.Drawing.Color.Black;
            this.lblCardAmount.Location = new System.Drawing.Point(93, 425);
            this.lblCardAmount.Name = "lblCardAmount";
            this.lblCardAmount.Size = new System.Drawing.Size(130, 23);
            this.lblCardAmount.TabIndex = 3;
            this.lblCardAmount.Text = "Card Amount";
            // 
            // lblSaleReturnAmount
            // 
            this.lblSaleReturnAmount.AutoSize = true;
            this.lblSaleReturnAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaleReturnAmount.ForeColor = System.Drawing.Color.Black;
            this.lblSaleReturnAmount.Location = new System.Drawing.Point(30, 332);
            this.lblSaleReturnAmount.Name = "lblSaleReturnAmount";
            this.lblSaleReturnAmount.Size = new System.Drawing.Size(193, 23);
            this.lblSaleReturnAmount.TabIndex = 2;
            this.lblSaleReturnAmount.Text = "Sale Return Amount";
            // 
            // lblCashAmount
            // 
            this.lblCashAmount.AutoSize = true;
            this.lblCashAmount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCashAmount.ForeColor = System.Drawing.Color.Black;
            this.lblCashAmount.Location = new System.Drawing.Point(88, 240);
            this.lblCashAmount.Name = "lblCashAmount";
            this.lblCashAmount.Size = new System.Drawing.Size(130, 23);
            this.lblCashAmount.TabIndex = 1;
            this.lblCashAmount.Text = "Cash Amount";
            // 
            // lblEditTotalSale
            // 
            this.lblEditTotalSale.AutoSize = true;
            this.lblEditTotalSale.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditTotalSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.lblEditTotalSale.Location = new System.Drawing.Point(205, 60);
            this.lblEditTotalSale.Name = "lblEditTotalSale";
            this.lblEditTotalSale.Size = new System.Drawing.Size(188, 32);
            this.lblEditTotalSale.TabIndex = 0;
            this.lblEditTotalSale.Text = "Edit Total Sale";
            // 
            // EditTotalSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(600, 879);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditTotalSale";
            this.Text = "EditTotalSale";
            this.Load += new System.EventHandler(this.EditTotalSale_Load);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblEditTotalSale;
        private System.Windows.Forms.Label lblCashAmount;
        private System.Windows.Forms.Label lblSaleReturnAmount;
        private System.Windows.Forms.Label lblCardAmount;
        private System.Windows.Forms.Label lblUpiAmount;
        private System.Windows.Forms.Label lblExtraAmount;
        private System.Windows.Forms.TextBox txtTotalSale;
        private System.Windows.Forms.TextBox txtExtraAmount;
        private System.Windows.Forms.TextBox txtUpiAmount;
        private System.Windows.Forms.TextBox txtCardAmount;
        private System.Windows.Forms.TextBox txtSaleReturnAmount;
        private System.Windows.Forms.TextBox txtCashAmount;
        private System.Windows.Forms.Label lblTotalSaleAmount;
        private System.Windows.Forms.Button btnGeneratePdf;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}