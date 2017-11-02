namespace Inventory
{
    partial class DebitInvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebitInvoiceForm));
            this.printBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.salesDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cusName = new System.Windows.Forms.Label();
            this.invoiceNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.paidAmountLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchaseIDLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dueLabel = new System.Windows.Forms.Label();
            this.catLabel = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.total6 = new System.Windows.Forms.Label();
            this.price6 = new System.Windows.Forms.Label();
            this.quty6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.sublabel = new System.Windows.Forms.Label();
            this.shopname = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.SlateBlue;
            this.printBtn.Location = new System.Drawing.Point(252, 541);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 33);
            this.printBtn.TabIndex = 32;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.salesDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cusName);
            this.groupBox3.Controls.Add(this.invoiceNo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(25, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(565, 109);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            // 
            // salesDate
            // 
            this.salesDate.AutoSize = true;
            this.salesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesDate.Location = new System.Drawing.Point(145, 70);
            this.salesDate.Name = "salesDate";
            this.salesDate.Size = new System.Drawing.Size(54, 18);
            this.salesDate.TabIndex = 9;
            this.salesDate.Text = "label56";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Teal;
            this.label14.Location = new System.Drawing.Point(77, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Date:";
            // 
            // cusName
            // 
            this.cusName.AutoSize = true;
            this.cusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusName.Location = new System.Drawing.Point(145, 44);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(52, 16);
            this.cusName.TabIndex = 6;
            this.cusName.Text = "label51";
            // 
            // invoiceNo
            // 
            this.invoiceNo.AutoSize = true;
            this.invoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNo.Location = new System.Drawing.Point(145, 16);
            this.invoiceNo.Name = "invoiceNo";
            this.invoiceNo.Size = new System.Drawing.Size(52, 16);
            this.invoiceNo.TabIndex = 5;
            this.invoiceNo.Text = "label50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(34, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Invoice No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.paidAmountLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(25, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 146);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // paidAmountLabel
            // 
            this.paidAmountLabel.AutoSize = true;
            this.paidAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidAmountLabel.Location = new System.Drawing.Point(137, 66);
            this.paidAmountLabel.Name = "paidAmountLabel";
            this.paidAmountLabel.Size = new System.Drawing.Size(52, 16);
            this.paidAmountLabel.TabIndex = 14;
            this.paidAmountLabel.Text = "label55";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(443, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Signature";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(23, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Paid Amount:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.purchaseIDLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dueLabel);
            this.groupBox1.Controls.Add(this.catLabel);
            this.groupBox1.Controls.Add(this.itemLabel);
            this.groupBox1.Controls.Add(this.modelLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.total6);
            this.groupBox1.Controls.Add(this.price6);
            this.groupBox1.Controls.Add(this.quty6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(25, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 151);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // purchaseIDLabel
            // 
            this.purchaseIDLabel.AutoSize = true;
            this.purchaseIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseIDLabel.Location = new System.Drawing.Point(7, 68);
            this.purchaseIDLabel.Name = "purchaseIDLabel";
            this.purchaseIDLabel.Size = new System.Drawing.Size(30, 16);
            this.purchaseIDLabel.TabIndex = 47;
            this.purchaseIDLabel.Text = "PID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Sales ID";
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueLabel.Location = new System.Drawing.Point(452, 68);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(81, 16);
            this.dueLabel.TabIndex = 45;
            this.dueLabel.Text = "Due Amount";
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catLabel.Location = new System.Drawing.Point(229, 68);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(26, 16);
            this.catLabel.TabIndex = 44;
            this.catLabel.Text = "cat";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(116, 68);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(73, 16);
            this.itemLabel.TabIndex = 43;
            this.itemLabel.Text = "Item Name";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(323, 68);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(46, 16);
            this.modelLabel.TabIndex = 42;
            this.modelLabel.Text = "model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(323, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Product Model";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Teal;
            this.label43.Location = new System.Drawing.Point(229, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(71, 16);
            this.label43.TabIndex = 40;
            this.label43.Text = "Category";
            // 
            // total6
            // 
            this.total6.AutoSize = true;
            this.total6.Location = new System.Drawing.Point(452, 176);
            this.total6.Name = "total6";
            this.total6.Size = new System.Drawing.Size(0, 13);
            this.total6.TabIndex = 39;
            // 
            // price6
            // 
            this.price6.AutoSize = true;
            this.price6.Location = new System.Drawing.Point(374, 176);
            this.price6.Name = "price6";
            this.price6.Size = new System.Drawing.Size(0, 13);
            this.price6.TabIndex = 38;
            // 
            // quty6
            // 
            this.quty6.AutoSize = true;
            this.quty6.Location = new System.Drawing.Point(302, 176);
            this.quty6.Name = "quty6";
            this.quty6.Size = new System.Drawing.Size(0, 13);
            this.quty6.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(452, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Due Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(114, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Item Name";
            // 
            // printDocument1
            // 
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
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileLabel.Location = new System.Drawing.Point(216, 77);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(165, 16);
            this.mobileLabel.TabIndex = 35;
            this.mobileLabel.Text = "Contact : 01930-822942";
            // 
            // sublabel
            // 
            this.sublabel.AutoSize = true;
            this.sublabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublabel.Location = new System.Drawing.Point(204, 57);
            this.sublabel.Name = "sublabel";
            this.sublabel.Size = new System.Drawing.Size(196, 20);
            this.sublabel.TabIndex = 34;
            this.sublabel.Text = "New Market,Chittagong";
            // 
            // shopname
            // 
            this.shopname.AutoSize = true;
            this.shopname.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopname.Location = new System.Drawing.Point(168, 25);
            this.shopname.Name = "shopname";
            this.shopname.Size = new System.Drawing.Size(309, 32);
            this.shopname.TabIndex = 33;
            this.shopname.Text = "Azmir Electric Shop";
            // 
            // DebitInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 589);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.sublabel);
            this.Controls.Add(this.shopname);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DebitInvoiceForm";
            this.Text = "Debit Invoice";
            this.Load += new System.EventHandler(this.DebitInvoiceForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label salesDate;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label cusName;
        public System.Windows.Forms.Label invoiceNo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label paidAmountLabel;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label purchaseIDLabel;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label dueLabel;
        public System.Windows.Forms.Label catLabel;
        public System.Windows.Forms.Label itemLabel;
        public System.Windows.Forms.Label modelLabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label43;
        public System.Windows.Forms.Label total6;
        public System.Windows.Forms.Label price6;
        public System.Windows.Forms.Label quty6;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label sublabel;
        private System.Windows.Forms.Label shopname;
    }
}