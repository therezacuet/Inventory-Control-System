namespace Inventory
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.purdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.purdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salesdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.debitdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.debitdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.resultReportdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purReportBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker9 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker10 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printReport = new System.Windows.Forms.Button();
            this.resultTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultReportdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purdateTimePicker2
            // 
            this.purdateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purdateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purdateTimePicker2.Location = new System.Drawing.Point(708, 144);
            this.purdateTimePicker2.Name = "purdateTimePicker2";
            this.purdateTimePicker2.Size = new System.Drawing.Size(107, 26);
            this.purdateTimePicker2.TabIndex = 0;
            this.purdateTimePicker2.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // purdateTimePicker1
            // 
            this.purdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purdateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purdateTimePicker1.Location = new System.Drawing.Point(577, 144);
            this.purdateTimePicker1.Name = "purdateTimePicker1";
            this.purdateTimePicker1.Size = new System.Drawing.Size(107, 26);
            this.purdateTimePicker1.TabIndex = 1;
            this.purdateTimePicker1.Value = new System.DateTime(2017, 5, 11, 0, 0, 0, 0);
            // 
            // salesdateTimePicker1
            // 
            this.salesdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesdateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salesdateTimePicker1.Location = new System.Drawing.Point(577, 193);
            this.salesdateTimePicker1.Name = "salesdateTimePicker1";
            this.salesdateTimePicker1.Size = new System.Drawing.Size(107, 26);
            this.salesdateTimePicker1.TabIndex = 2;
            this.salesdateTimePicker1.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // salesdateTimePicker2
            // 
            this.salesdateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesdateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.salesdateTimePicker2.Location = new System.Drawing.Point(708, 193);
            this.salesdateTimePicker2.Name = "salesdateTimePicker2";
            this.salesdateTimePicker2.Size = new System.Drawing.Size(107, 26);
            this.salesdateTimePicker2.TabIndex = 3;
            this.salesdateTimePicker2.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // debitdateTimePicker1
            // 
            this.debitdateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitdateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitdateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.debitdateTimePicker1.Location = new System.Drawing.Point(577, 243);
            this.debitdateTimePicker1.Name = "debitdateTimePicker1";
            this.debitdateTimePicker1.Size = new System.Drawing.Size(107, 26);
            this.debitdateTimePicker1.TabIndex = 4;
            this.debitdateTimePicker1.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // debitdateTimePicker2
            // 
            this.debitdateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitdateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debitdateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.debitdateTimePicker2.Location = new System.Drawing.Point(708, 243);
            this.debitdateTimePicker2.Name = "debitdateTimePicker2";
            this.debitdateTimePicker2.Size = new System.Drawing.Size(107, 26);
            this.debitdateTimePicker2.TabIndex = 5;
            this.debitdateTimePicker2.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // resultReportdataGridView
            // 
            this.resultReportdataGridView.AllowUserToAddRows = false;
            this.resultReportdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultReportdataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.resultReportdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultReportdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.resultReportdataGridView.Location = new System.Drawing.Point(12, 89);
            this.resultReportdataGridView.Name = "resultReportdataGridView";
            this.resultReportdataGridView.Size = new System.Drawing.Size(542, 325);
            this.resultReportdataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "stock_name";
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "category";
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "product_model";
            this.Column3.HeaderText = "Product Model";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Name";
            this.Column8.HeaderText = "Supplier Name";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "quantity";
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "price";
            this.Column6.HeaderText = "Unit Price";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "total";
            this.Column5.HeaderText = "Gross Total";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "date";
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            // 
            // purReportBtn
            // 
            this.purReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.purReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purReportBtn.Location = new System.Drawing.Point(837, 141);
            this.purReportBtn.Name = "purReportBtn";
            this.purReportBtn.Size = new System.Drawing.Size(130, 36);
            this.purReportBtn.TabIndex = 7;
            this.purReportBtn.Text = "Purchase Report";
            this.purReportBtn.UseVisualStyleBackColor = true;
            this.purReportBtn.Click += new System.EventHandler(this.purReportBtn_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(837, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 36);
            this.button2.TabIndex = 8;
            this.button2.Text = "Sales Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(837, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "Debit Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(837, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 36);
            this.button4.TabIndex = 12;
            this.button4.Text = "Credit Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(708, 298);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(107, 26);
            this.dateTimePicker7.TabIndex = 11;
            this.dateTimePicker7.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker8.Location = new System.Drawing.Point(577, 298);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(107, 26);
            this.dateTimePicker8.TabIndex = 10;
            this.dateTimePicker8.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(837, 345);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 36);
            this.button5.TabIndex = 15;
            this.button5.Text = "Profit Report";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker9
            // 
            this.dateTimePicker9.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker9.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker9.Location = new System.Drawing.Point(708, 348);
            this.dateTimePicker9.Name = "dateTimePicker9";
            this.dateTimePicker9.Size = new System.Drawing.Size(107, 26);
            this.dateTimePicker9.TabIndex = 14;
            this.dateTimePicker9.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // dateTimePicker10
            // 
            this.dateTimePicker10.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker10.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker10.Location = new System.Drawing.Point(577, 348);
            this.dateTimePicker10.Name = "dateTimePicker10";
            this.dateTimePicker10.Size = new System.Drawing.Size(107, 26);
            this.dateTimePicker10.TabIndex = 13;
            this.dateTimePicker10.Value = new System.DateTime(2017, 5, 3, 14, 44, 37, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(833, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Report Types";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(573, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(704, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "To";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDataGridView);
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
            // printReport
            // 
            this.printReport.Location = new System.Drawing.Point(220, 420);
            this.printReport.Name = "printReport";
            this.printReport.Size = new System.Drawing.Size(75, 33);
            this.printReport.TabIndex = 19;
            this.printReport.Text = "Print";
            this.printReport.UseVisualStyleBackColor = true;
            this.printReport.Click += new System.EventHandler(this.printReport_Click);
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.ForeColor = System.Drawing.Color.White;
            this.resultTextLabel.Location = new System.Drawing.Point(176, 242);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(180, 24);
            this.resultTextLabel.TabIndex = 20;
            this.resultTextLabel.Text = "No Result Found!!";
            this.resultTextLabel.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 532);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.printReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dateTimePicker9);
            this.Controls.Add(this.dateTimePicker10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker7);
            this.Controls.Add(this.dateTimePicker8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.purReportBtn);
            this.Controls.Add(this.resultReportdataGridView);
            this.Controls.Add(this.debitdateTimePicker2);
            this.Controls.Add(this.debitdateTimePicker1);
            this.Controls.Add(this.salesdateTimePicker2);
            this.Controls.Add(this.salesdateTimePicker1);
            this.Controls.Add(this.purdateTimePicker1);
            this.Controls.Add(this.purdateTimePicker2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultReportdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker purdateTimePicker2;
        private System.Windows.Forms.DateTimePicker purdateTimePicker1;
        private System.Windows.Forms.DateTimePicker salesdateTimePicker1;
        private System.Windows.Forms.DateTimePicker salesdateTimePicker2;
        private System.Windows.Forms.DateTimePicker debitdateTimePicker1;
        private System.Windows.Forms.DateTimePicker debitdateTimePicker2;
        private System.Windows.Forms.DataGridView resultReportdataGridView;
        private System.Windows.Forms.Button purReportBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker9;
        private System.Windows.Forms.DateTimePicker dateTimePicker10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button printReport;
        public System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}