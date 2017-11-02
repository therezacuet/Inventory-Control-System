namespace Inventory
{
    partial class ViewStockAvail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStockAvail));
            this.stockAvaildataGridView = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockAvail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockAvaildataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stockAvaildataGridView
            // 
            this.stockAvaildataGridView.AllowUserToAddRows = false;
            this.stockAvaildataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockAvaildataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.stockAvaildataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.stockAvaildataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockAvaildataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.ProductName,
            this.Category,
            this.ProductModel,
            this.StockAvail});
            this.stockAvaildataGridView.Location = new System.Drawing.Point(35, 88);
            this.stockAvaildataGridView.Name = "stockAvaildataGridView";
            this.stockAvaildataGridView.Size = new System.Drawing.Size(541, 287);
            this.stockAvaildataGridView.TabIndex = 0;
            this.stockAvaildataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stockAvaildataGridView_RowPostPaint);
            // 
            // No
            // 
            this.No.DataPropertyName = "ID";
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "stock_name";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // ProductModel
            // 
            this.ProductModel.DataPropertyName = "product_model";
            this.ProductModel.HeaderText = "Product Model";
            this.ProductModel.Name = "ProductModel";
            // 
            // StockAvail
            // 
            this.StockAvail.DataPropertyName = "quantity";
            this.StockAvail.HeaderText = "Available Stock";
            this.StockAvail.Name = "StockAvail";
            // 
            // resultTextLabel
            // 
            this.resultTextLabel.AutoSize = true;
            this.resultTextLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.resultTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextLabel.ForeColor = System.Drawing.Color.White;
            this.resultTextLabel.Location = new System.Drawing.Point(213, 215);
            this.resultTextLabel.Name = "resultTextLabel";
            this.resultTextLabel.Size = new System.Drawing.Size(180, 24);
            this.resultTextLabel.TabIndex = 4;
            this.resultTextLabel.Text = "No Result Found!!";
            this.resultTextLabel.Visible = false;
            // 
            // ViewStockAvail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 427);
            this.Controls.Add(this.resultTextLabel);
            this.Controls.Add(this.stockAvaildataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewStockAvail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Available Stock";
            this.Load += new System.EventHandler(this.ViewStockAvail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockAvaildataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView stockAvaildataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockAvail;
        private System.Windows.Forms.Label resultTextLabel;
    }
}