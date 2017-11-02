namespace Inventory
{
    partial class DebitInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitInfoForm));
            this.debitInfodataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payNowBtn = new System.Windows.Forms.Button();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dueAmounttextBox = new System.Windows.Forms.TextBox();
            this.suppliertextBox = new System.Windows.Forms.TextBox();
            this.pNametextBox = new System.Windows.Forms.TextBox();
            this.purchaseIDtextBox = new System.Windows.Forms.TextBox();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dueInvoicetextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.debitInfodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // debitInfodataGridView
            // 
            this.debitInfodataGridView.AllowUserToAddRows = false;
            this.debitInfodataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.debitInfodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debitInfodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column6,
            this.Column8,
            this.Column5});
            this.debitInfodataGridView.Location = new System.Drawing.Point(26, 65);
            this.debitInfodataGridView.Name = "debitInfodataGridView";
            this.debitInfodataGridView.Size = new System.Drawing.Size(622, 414);
            this.debitInfodataGridView.TabIndex = 1;
            this.debitInfodataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.debitInfodataGridView_RowHeaderMouseClick);
            this.debitInfodataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.debitInfodataGridView_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SalesID";
            this.Column1.HeaderText = "SalesID";
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
            this.Column7.HeaderText = "Customer Name";
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
            // payNowBtn
            // 
            this.payNowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payNowBtn.Location = new System.Drawing.Point(808, 384);
            this.payNowBtn.Name = "payNowBtn";
            this.payNowBtn.Size = new System.Drawing.Size(91, 30);
            this.payNowBtn.TabIndex = 22;
            this.payNowBtn.Text = "Pay Now";
            this.payNowBtn.UseVisualStyleBackColor = true;
            this.payNowBtn.Click += new System.EventHandler(this.payNowBtn_Click);
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentTextBox.Location = new System.Drawing.Point(808, 438);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(133, 26);
            this.paymentTextBox.TabIndex = 20;
            this.paymentTextBox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(732, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "SalesID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(701, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Due Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Name";
            // 
            // dueAmounttextBox
            // 
            this.dueAmounttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueAmounttextBox.Location = new System.Drawing.Point(808, 332);
            this.dueAmounttextBox.Name = "dueAmounttextBox";
            this.dueAmounttextBox.ReadOnly = true;
            this.dueAmounttextBox.Size = new System.Drawing.Size(133, 26);
            this.dueAmounttextBox.TabIndex = 15;
            // 
            // suppliertextBox
            // 
            this.suppliertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliertextBox.Location = new System.Drawing.Point(808, 276);
            this.suppliertextBox.Name = "suppliertextBox";
            this.suppliertextBox.ReadOnly = true;
            this.suppliertextBox.Size = new System.Drawing.Size(133, 26);
            this.suppliertextBox.TabIndex = 14;
            // 
            // pNametextBox
            // 
            this.pNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNametextBox.Location = new System.Drawing.Point(808, 225);
            this.pNametextBox.Name = "pNametextBox";
            this.pNametextBox.ReadOnly = true;
            this.pNametextBox.Size = new System.Drawing.Size(133, 26);
            this.pNametextBox.TabIndex = 13;
            // 
            // purchaseIDtextBox
            // 
            this.purchaseIDtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseIDtextBox.Location = new System.Drawing.Point(808, 170);
            this.purchaseIDtextBox.Name = "purchaseIDtextBox";
            this.purchaseIDtextBox.ReadOnly = true;
            this.purchaseIDtextBox.Size = new System.Drawing.Size(133, 26);
            this.purchaseIDtextBox.TabIndex = 12;
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.ForeColor = System.Drawing.Color.White;
            this.resultTextLabel.Location = new System.Drawing.Point(207, 258);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(210, 24);
            this.resultTextLabel.TabIndex = 23;
            this.resultTextLabel.Text = "No Debit Info Found!!";
            this.resultTextLabel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Invoice No";
            // 
            // dueInvoicetextBox
            // 
            this.dueInvoicetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueInvoicetextBox.Location = new System.Drawing.Point(808, 128);
            this.dueInvoicetextBox.Name = "dueInvoicetextBox";
            this.dueInvoicetextBox.Size = new System.Drawing.Size(133, 26);
            this.dueInvoicetextBox.TabIndex = 24;
            // 
            // DebitInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 532);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dueInvoicetextBox);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.payNowBtn);
            this.Controls.Add(this.paymentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dueAmounttextBox);
            this.Controls.Add(this.suppliertextBox);
            this.Controls.Add(this.pNametextBox);
            this.Controls.Add(this.purchaseIDtextBox);
            this.Controls.Add(this.debitInfodataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DebitInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debit Info";
            this.Load += new System.EventHandler(this.DebitInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debitInfodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView debitInfodataGridView;
        private System.Windows.Forms.Button payNowBtn;
        private System.Windows.Forms.TextBox paymentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dueAmounttextBox;
        private System.Windows.Forms.TextBox suppliertextBox;
        private System.Windows.Forms.TextBox pNametextBox;
        private System.Windows.Forms.TextBox purchaseIDtextBox;
        private System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dueInvoicetextBox;
    }
}