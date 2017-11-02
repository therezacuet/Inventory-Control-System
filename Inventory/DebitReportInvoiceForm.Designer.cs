namespace Inventory
{
    partial class DebitReportInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitReportInvoiceForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalPurLabel = new System.Windows.Forms.Label();
            this.reportLabel = new System.Windows.Forms.Label();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.fromdateLabel = new System.Windows.Forms.Label();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.sublabel = new System.Windows.Forms.Label();
            this.shopname = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "To Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "From Date : ";
            // 
            // totalPurLabel
            // 
            this.totalPurLabel.AutoSize = true;
            this.totalPurLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPurLabel.Location = new System.Drawing.Point(348, 165);
            this.totalPurLabel.Name = "totalPurLabel";
            this.totalPurLabel.Size = new System.Drawing.Size(96, 18);
            this.totalPurLabel.TabIndex = 31;
            this.totalPurLabel.Text = "Total Due : ";
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(346, 127);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(144, 25);
            this.reportLabel.TabIndex = 30;
            this.reportLabel.Text = "Debit Report";
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.Location = new System.Drawing.Point(746, 205);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(0, 13);
            this.toDateLabel.TabIndex = 29;
            // 
            // fromdateLabel
            // 
            this.fromdateLabel.AutoSize = true;
            this.fromdateLabel.Location = new System.Drawing.Point(92, 205);
            this.fromdateLabel.Name = "fromdateLabel";
            this.fromdateLabel.Size = new System.Drawing.Size(0, 13);
            this.fromdateLabel.TabIndex = 28;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.Location = new System.Drawing.Point(348, 68);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(165, 16);
            this.mobileLabel.TabIndex = 27;
            this.mobileLabel.Text = "Contact : 01930-822942";
            // 
            // sublabel
            // 
            this.sublabel.AutoSize = true;
            this.sublabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublabel.Location = new System.Drawing.Point(336, 48);
            this.sublabel.Name = "sublabel";
            this.sublabel.Size = new System.Drawing.Size(196, 20);
            this.sublabel.TabIndex = 26;
            this.sublabel.Text = "New Market,Chittagong";
            // 
            // shopname
            // 
            this.shopname.AutoSize = true;
            this.shopname.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopname.Location = new System.Drawing.Point(292, 16);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(309, 32);
            this.shopname.TabIndex = 25;
            this.shopname.Text = "Azmir Electric Shop";
            // 
            // printBtn
            // 
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(370, 528);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 40);
            this.printBtn.TabIndex = 24;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // reportGridView
            // 
            this.reportGridView.AllowUserToAddRows = false;
            this.reportGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column1});
            this.reportGridView.Location = new System.Drawing.Point(26, 248);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.Size = new System.Drawing.Size(821, 268);
            this.reportGridView.TabIndex = 23;
            this.reportGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.reportGridView_RowPostPaint);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "Address";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Contact";
            this.Column4.HeaderText = "Contact";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dueAmount";
            this.Column6.HeaderText = "Total Due Amount";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "date";
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // DebitReportInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 585);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalPurLabel);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.toDateLabel);
            this.Controls.Add(this.fromdateLabel);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.sublabel);
            this.Controls.Add(this.shopname);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.reportGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DebitReportInvoiceForm";
            this.Text = "DebitReportInvoiceForm";
            this.Load += new System.EventHandler(this.DebitReportInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalPurLabel;
        private System.Windows.Forms.Label reportLabel;
        public System.Windows.Forms.Label toDateLabel;
        public System.Windows.Forms.Label fromdateLabel;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label sublabel;
        private System.Windows.Forms.Label shopname;
        public System.Windows.Forms.Button printBtn;
        public System.Windows.Forms.DataGridView reportGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}