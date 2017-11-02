namespace Inventory
{
    partial class ViewSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewSupplierForm));
            this.noResult = new System.Windows.Forms.Label();
            this.supplierdataGridView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // noResult
            // 
            this.noResult.AutoSize = true;
            this.noResult.BackColor = System.Drawing.Color.DodgerBlue;
            this.noResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResult.ForeColor = System.Drawing.Color.White;
            this.noResult.Location = new System.Drawing.Point(301, 200);
            this.noResult.Name = "noResult";
            this.noResult.Size = new System.Drawing.Size(222, 25);
            this.noResult.TabIndex = 18;
            this.noResult.Text = "No Supplier Found!!";
            this.noResult.Visible = false;
            // 
            // supplierdataGridView
            // 
            this.supplierdataGridView.AllowUserToAddRows = false;
            this.supplierdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierdataGridView.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.supplierdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.supplierdataGridView.Location = new System.Drawing.Point(41, 39);
            this.supplierdataGridView.Name = "supplierdataGridView";
            this.supplierdataGridView.Size = new System.Drawing.Size(705, 353);
            this.supplierdataGridView.TabIndex = 17;
            this.supplierdataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.supplierdataGridView_RowPostPaint);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Supplier Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Address";
            this.Column7.HeaderText = "Supplier Address";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Contact";
            this.Column8.HeaderText = "Contact No";
            this.Column8.Name = "Column8";
            // 
            // ViewSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.noResult);
            this.Controls.Add(this.supplierdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewSupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier Details";
            this.Load += new System.EventHandler(this.ViewSupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noResult;
        private System.Windows.Forms.DataGridView supplierdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}