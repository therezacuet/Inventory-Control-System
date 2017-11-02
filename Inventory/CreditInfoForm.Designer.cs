namespace Inventory
{
    partial class CreditInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditInfoForm));
            this.creditInfodataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseIDtextBox = new System.Windows.Forms.TextBox();
            this.pNametextBox = new System.Windows.Forms.TextBox();
            this.suppliertextBox = new System.Windows.Forms.TextBox();
            this.dueAmounttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.payDuetextBox = new System.Windows.Forms.TextBox();
            this.payNowBtn = new System.Windows.Forms.Button();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.dueInvoicetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditInfodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // creditInfodataGridView
            // 
            this.creditInfodataGridView.AllowUserToAddRows = false;
            this.creditInfodataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.creditInfodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditInfodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column5});
            this.creditInfodataGridView.Location = new System.Drawing.Point(22, 68);
            this.creditInfodataGridView.Name = "creditInfodataGridView";
            this.creditInfodataGridView.Size = new System.Drawing.Size(622, 414);
            this.creditInfodataGridView.TabIndex = 0;
            this.creditInfodataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.creditInfodataGridView_RowHeaderMouseClick);
            this.creditInfodataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.creditInfodataGridView_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PrID";
            this.Column1.HeaderText = "PurchaseID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "stock_name";
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "category";
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "product_model";
            this.Column4.HeaderText = "Product Model";
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Name";
            this.Column7.HeaderText = "Supplier Name";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "dueAmount";
            this.Column6.HeaderText = "Due Amount";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "payment";
            this.Column8.HeaderText = "Payment";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "grossTotal";
            this.Column5.HeaderText = "Gross Total";
            this.Column5.Name = "Column5";
            // 
            // purchaseIDtextBox
            // 
            this.purchaseIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseIDtextBox.Location = new System.Drawing.Point(804, 163);
            this.purchaseIDtextBox.Name = "purchaseIDtextBox";
            this.purchaseIDtextBox.ReadOnly = true;
            this.purchaseIDtextBox.Size = new System.Drawing.Size(133, 26);
            this.purchaseIDtextBox.TabIndex = 1;
            // 
            // pNametextBox
            // 
            this.pNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNametextBox.Location = new System.Drawing.Point(804, 214);
            this.pNametextBox.Name = "pNametextBox";
            this.pNametextBox.ReadOnly = true;
            this.pNametextBox.Size = new System.Drawing.Size(133, 26);
            this.pNametextBox.TabIndex = 2;
            // 
            // suppliertextBox
            // 
            this.suppliertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliertextBox.Location = new System.Drawing.Point(804, 265);
            this.suppliertextBox.Name = "suppliertextBox";
            this.suppliertextBox.ReadOnly = true;
            this.suppliertextBox.Size = new System.Drawing.Size(133, 26);
            this.suppliertextBox.TabIndex = 3;
            // 
            // dueAmounttextBox
            // 
            this.dueAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueAmounttextBox.Location = new System.Drawing.Point(804, 321);
            this.dueAmounttextBox.Name = "dueAmounttextBox";
            this.dueAmounttextBox.ReadOnly = true;
            this.dueAmounttextBox.Size = new System.Drawing.Size(133, 26);
            this.dueAmounttextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(697, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Due Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(682, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "PurchaseID";
            // 
            // payDuetextBox
            // 
            this.payDuetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payDuetextBox.Location = new System.Drawing.Point(804, 417);
            this.payDuetextBox.Name = "payDuetextBox";
            this.payDuetextBox.Size = new System.Drawing.Size(133, 26);
            this.payDuetextBox.TabIndex = 9;
            this.payDuetextBox.Visible = false;
            // 
            // payNowBtn
            // 
            this.payNowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payNowBtn.Location = new System.Drawing.Point(804, 367);
            this.payNowBtn.Name = "payNowBtn";
            this.payNowBtn.Size = new System.Drawing.Size(91, 30);
            this.payNowBtn.TabIndex = 11;
            this.payNowBtn.Text = "Pay Now";
            this.payNowBtn.UseVisualStyleBackColor = true;
            this.payNowBtn.Click += new System.EventHandler(this.payNowBtn_Click);
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.ForeColor = System.Drawing.Color.White;
            this.resultTextLabel.Location = new System.Drawing.Point(188, 250);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(244, 25);
            this.resultTextLabel.TabIndex = 16;
            this.resultTextLabel.Text = "No Credit Info Found!!";
            this.resultTextLabel.Visible = false;
            // 
            // dueInvoicetextBox
            // 
            this.dueInvoicetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueInvoicetextBox.Location = new System.Drawing.Point(804, 115);
            this.dueInvoicetextBox.Name = "dueInvoicetextBox";
            this.dueInvoicetextBox.Size = new System.Drawing.Size(133, 26);
            this.dueInvoicetextBox.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(702, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Invoice No";
            // 
            // CreditInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dueInvoicetextBox);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.payNowBtn);
            this.Controls.Add(this.payDuetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueAmounttextBox);
            this.Controls.Add(this.suppliertextBox);
            this.Controls.Add(this.pNametextBox);
            this.Controls.Add(this.purchaseIDtextBox);
            this.Controls.Add(this.creditInfodataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreditInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Info";
            this.Load += new System.EventHandler(this.CreditInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditInfodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView creditInfodataGridView;
        private System.Windows.Forms.TextBox purchaseIDtextBox;
        private System.Windows.Forms.TextBox pNametextBox;
        private System.Windows.Forms.TextBox suppliertextBox;
        private System.Windows.Forms.TextBox dueAmounttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox payDuetextBox;
        private System.Windows.Forms.Button payNowBtn;
        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox dueInvoicetextBox;
        private System.Windows.Forms.Label label5;
    }
}