namespace Inventory
{
    partial class ViewPurchaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPurchaseForm));
            this.viewPurchaseDatagrid = new System.Windows.Forms.DataGridView();
            this.PrID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayableAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultTextLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.PictureBox();
            this.addpurchasePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewPurchaseDatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.addpurchasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPurchaseDatagrid
            // 
            this.viewPurchaseDatagrid.AllowUserToAddRows = false;
            this.viewPurchaseDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.viewPurchaseDatagrid.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.viewPurchaseDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewPurchaseDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PrID,
            this.ProductName,
            this.Category,
            this.ProductModel,
            this.SupplierName,
            this.Quantity,
            this.UnitPrice,
            this.GrossTotal,
            this.Discount,
            this.DiscountAmount,
            this.PayableAmount,
            this.Payment,
            this.DueAmount,
            this.Mode,
            this.Date});
            this.viewPurchaseDatagrid.Location = new System.Drawing.Point(25, 125);
            this.viewPurchaseDatagrid.Name = "viewPurchaseDatagrid";
            this.viewPurchaseDatagrid.Size = new System.Drawing.Size(949, 354);
            this.viewPurchaseDatagrid.TabIndex = 0;
            this.viewPurchaseDatagrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.viewPurchaseDatagrid_RowPostPaint);
            // 
            // PrID
            // 
            this.PrID.DataPropertyName = "PrID";
            this.PrID.FillWeight = 139.0728F;
            this.PrID.HeaderText = "Purchase ID";
            this.PrID.Name = "PrID";
            this.PrID.Width = 84;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "stock_name";
            this.ProductName.FillWeight = 143.6851F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 92;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "category";
            this.Category.FillWeight = 108.2523F;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 74;
            // 
            // ProductModel
            // 
            this.ProductModel.DataPropertyName = "product_model";
            this.ProductModel.FillWeight = 130.484F;
            this.ProductModel.HeaderText = "Product Model";
            this.ProductModel.Name = "ProductModel";
            this.ProductModel.Width = 93;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "Name";
            this.SupplierName.FillWeight = 122.639F;
            this.SupplierName.HeaderText = "Supplier Name";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Width = 93;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "quantity";
            this.Quantity.FillWeight = 88.25326F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 71;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "price";
            this.UnitPrice.FillWeight = 86.77882F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 72;
            // 
            // GrossTotal
            // 
            this.GrossTotal.DataPropertyName = "total";
            this.GrossTotal.FillWeight = 92.36259F;
            this.GrossTotal.HeaderText = "Gross Total";
            this.GrossTotal.Name = "GrossTotal";
            this.GrossTotal.Width = 79;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "discount";
            this.Discount.FillWeight = 83.38831F;
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Width = 74;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "discountAmount";
            this.DiscountAmount.FillWeight = 113.8277F;
            this.DiscountAmount.HeaderText = "Discount Amount";
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Width = 104;
            // 
            // PayableAmount
            // 
            this.PayableAmount.DataPropertyName = "payableAmount";
            this.PayableAmount.FillWeight = 102.8527F;
            this.PayableAmount.HeaderText = "Payable Amount";
            this.PayableAmount.Name = "PayableAmount";
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "payment";
            this.Payment.FillWeight = 71.15096F;
            this.Payment.HeaderText = "Payment";
            this.Payment.Name = "Payment";
            this.Payment.Width = 73;
            // 
            // DueAmount
            // 
            this.DueAmount.DataPropertyName = "dueAmount";
            this.DueAmount.FillWeight = 80.28764F;
            this.DueAmount.HeaderText = "Due Amount";
            this.DueAmount.Name = "DueAmount";
            this.DueAmount.Width = 84;
            // 
            // Mode
            // 
            this.Mode.DataPropertyName = "mode";
            this.Mode.FillWeight = 88.05125F;
            this.Mode.HeaderText = "Payment Mode";
            this.Mode.Name = "Mode";
            this.Mode.Width = 95;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.FillWeight = 48.91348F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 55;
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.ForeColor = System.Drawing.Color.White;
            this.resultTextLabel.Location = new System.Drawing.Point(354, 292);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(202, 25);
            this.resultTextLabel.TabIndex = 6;
            this.resultTextLabel.Text = "No Result Found!!";
            this.resultTextLabel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(223, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = " Refresh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = global::Inventory.Properties.Resources.Refresh;
            this.refreshBtn.Location = new System.Drawing.Point(226, 33);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(62, 72);
            this.refreshBtn.TabIndex = 20;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addpurchasePanel
            // 
            this.addpurchasePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.addpurchasePanel.Controls.Add(this.label3);
            this.addpurchasePanel.Controls.Add(this.label1);
            this.addpurchasePanel.Controls.Add(this.pictureBox1);
            this.addpurchasePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpurchasePanel.Location = new System.Drawing.Point(25, 33);
            this.addpurchasePanel.Name = "addpurchasePanel";
            this.addpurchasePanel.Size = new System.Drawing.Size(178, 72);
            this.addpurchasePanel.TabIndex = 25;
            this.addpurchasePanel.Click += new System.EventHandler(this.addpurchasePanel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(72, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Purchase";
            this.label3.Click += new System.EventHandler(this.addpurchasePanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(72, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add";
            this.label1.Click += new System.EventHandler(this.addpurchasePanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Inventory.Properties.Resources.addsales;
            this.pictureBox1.Location = new System.Drawing.Point(13, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.addpurchasePanel_Click);
            // 
            // ViewPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 532);
            this.Controls.Add(this.addpurchasePanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.viewPurchaseDatagrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewPurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.ViewPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewPurchaseDatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            this.addpurchasePanel.ResumeLayout(false);
            this.addpurchasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn PrID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayableAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        public System.Windows.Forms.DataGridView viewPurchaseDatagrid;
        public System.Windows.Forms.Label resultTextLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox refreshBtn;
        private System.Windows.Forms.Panel addpurchasePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}