using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Inventory
{
    public partial class PInvoiceForm : Form
    {
        string invoiceNo = "";
        string name = "";
        string address = "";
        string contact = "";

        string gT = "";
        string dis = "";
        string payT = "";
        string dT = "";



        StringFormat strFormat; //Used to format the grid rows.
        ArrayList arrColumnLefts = new ArrayList();//Used to save left coordinates of columns
        ArrayList arrColumnWidths = new ArrayList();//Used to save column widths
        int iCellHeight = 0; //Used to get/set the datagridview cell height
        int iTotalWidth = 0; //
        int iRow = 0;//Used as counter
        bool bFirstPage = false; //Used to check whether we are printing first page
        bool bNewPage = false;// Used to check whether we are printing a new page
        int iHeaderHeight = 0; //Used for the header height
       
        public PInvoiceForm()
        {
            InitializeComponent();
        }
 
        private void PInvoiceForm_Load(object sender, EventArgs e)
        {
            //for (int i = 60; i >0; i--)
            //{
            //    this.testdataGridView1.Rows.Insert(0, "" + i);
            //}
            this.testdataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.testdataGridView1_RowPostPaint);
            invoiceNo = invoiceNoLabel.Text;
            name = nameLabel.Text;
            address = addressLabel.Text;
            contact = contactlabel.Text;

            gT = gTotalLabel.Text;
            dis = dLabel.Text;
            payT = paymentLabel.Text;
            dT = dueLabel.Text;

         
        }
 

        private void printBtn_Click_1(object sender, EventArgs e)
        {

            //Open the print dialog
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDocument1;
            //printDialog.UseEXDialog = true;
            printPreviewDialog1.ShowDialog();
            ////Get the document
            //if (DialogResult.OK == printDialog.ShowDialog())
            //{
            //    printDocument1.DocumentName = "Purchase Invoice Print";
            //    printDocument1.Print();
            //}

            //Open the print preview dialog
            //PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            //objPPdialog.Document = printDocument1;
            //objPPdialog.ShowDialog();
        }
        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iRow = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in testdataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            

            try
            {
                //Set the left margin
                int iLeftMargin = e.MarginBounds.Left;
                //Set the top margin
                int iTopMargin = e.MarginBounds.Top;
                //Whether more pages have to print or not
                bool bMorePagesToPrint = false;
                int iTmpWidth = 0;             
                
                //For the first page to print set the cell width and header height
                if (bFirstPage)
                {
                    foreach (DataGridViewColumn GridCol in testdataGridView1.Columns)
                    {
                        iTmpWidth = (int)(Math.Floor((double)((double)GridCol.Width /
                                       (double)iTotalWidth * (double)iTotalWidth *
                                       ((double)e.MarginBounds.Width / (double)iTotalWidth))));

                        iHeaderHeight = (int)(e.Graphics.MeasureString(GridCol.HeaderText,
                                    GridCol.InheritedStyle.Font, iTmpWidth).Height) + 11;

                        // Save width and height of headres
                        arrColumnLefts.Add(iLeftMargin);
                        arrColumnWidths.Add(iTmpWidth);
                        iLeftMargin += iTmpWidth;
                    }
                }
                //Loop till all the grid rows not get printed
                while (iRow <= testdataGridView1.Rows.Count - 1)
                {
                    DataGridViewRow GridRow = testdataGridView1.Rows[iRow];
                    //Set the cell height
                    iCellHeight = GridRow.Height + 5;
                    int iCount = 0;
                    //Check whether the current page settings allo more rows to print
                    if (iTopMargin + iCellHeight >= e.MarginBounds.Height + e.MarginBounds.Top)
                    {
                        bNewPage = true;
                        bFirstPage = false;
                        bMorePagesToPrint = true;
                        break;
                    }
                    else
                    {
                        if (bNewPage)
                        {
                            e.Graphics.DrawString("Azmir Electric Shop", new Font(shopname.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left+180, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height -13);

                            e.Graphics.DrawString("New Market,Chittagong", new Font(sublabel.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + 220, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height + 20);

                            e.Graphics.DrawString("Contact : 01930822942", new Font(mobileLabel.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + 240, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height + 50);
                            





                            //supplier info
                            e.Graphics.DrawString(invoiceNo, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height+100);

                            e.Graphics.DrawString(name, new Font(testdataGridView1.Font, FontStyle.Bold),
                                   Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                   e.Graphics.MeasureString(name, new Font(testdataGridView1.Font,
                                   FontStyle.Bold), e.MarginBounds.Width).Height +120);

                            e.Graphics.DrawString(address, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(address, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height +140);

                            e.Graphics.DrawString(contact, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(contact, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height +160);


                            //Payment info
                            e.Graphics.DrawString(gT, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left+465, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height + 100);

                            e.Graphics.DrawString(dis, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + 465, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height + 120);

                            e.Graphics.DrawString(payT, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + 465, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height + 140);

                            e.Graphics.DrawString(dT, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + 465, e.MarginBounds.Top -
                                    e.Graphics.MeasureString(invoiceNo, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height + 160);

                            
                            //Draw Header
                            e.Graphics.DrawString("Item Details", new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Item Details", new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Height +190);

                            String strDate = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
                            //Draw Date
                            e.Graphics.DrawString(strDate, new Font(testdataGridView1.Font, FontStyle.Bold),
                                    Brushes.Black, e.MarginBounds.Left + (e.MarginBounds.Width -
                                    e.Graphics.MeasureString(strDate, new Font(testdataGridView1.Font,
                                    FontStyle.Bold), e.MarginBounds.Width).Width), e.MarginBounds.Top -
                                    e.Graphics.MeasureString("Item Details", new Font(new Font(testdataGridView1.Font,
                                    FontStyle.Bold), FontStyle.Bold), e.MarginBounds.Width).Height +190);

                            //Draw Columns                 
                            iTopMargin = e.MarginBounds.Top+200;
                            foreach (DataGridViewColumn GridCol in testdataGridView1.Columns)
                            {
                                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray),
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawRectangle(Pens.Black,
                                    new Rectangle((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight));

                                e.Graphics.DrawString(GridCol.HeaderText, GridCol.InheritedStyle.Font,
                                    new SolidBrush(GridCol.InheritedStyle.ForeColor),
                                    new RectangleF((int)arrColumnLefts[iCount], iTopMargin,
                                    (int)arrColumnWidths[iCount], iHeaderHeight), strFormat);
                                iCount++;
                            }
                            bNewPage = false;
                            iTopMargin += iHeaderHeight;
                        }
                        iCount = 0;
                        //Draw Columns Contents                
                        foreach (DataGridViewCell Cel in GridRow.Cells)
                        {
                            if (Cel.Value != null)
                            {                               
                                e.Graphics.DrawString(Cel.Value.ToString(), Cel.InheritedStyle.Font,
                                            new SolidBrush(Cel.InheritedStyle.ForeColor),
                                            new RectangleF((int)arrColumnLefts[iCount], (float)iTopMargin,
                                            (int)arrColumnWidths[iCount], (float)iCellHeight), strFormat);
                            }
                            //Drawing Cells Borders 
                            e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)arrColumnLefts[iCount],
                                    iTopMargin, (int)arrColumnWidths[iCount], iCellHeight));

                            iCount++;
                        }
                    }
                    iRow++;
                    iTopMargin += iCellHeight;                    
                }                

                //If more lines exist, print another page.
                if (bMorePagesToPrint)
                    e.HasMorePages = true;
                else
                    e.HasMorePages = false;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void testdataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(testdataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void contactlabel_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void gTotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void dLabel_Click(object sender, EventArgs e)
        {

        }

        private void invoiceNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void dueLabel_Click(object sender, EventArgs e)
        {

        }

        private void paymentLabel_Click(object sender, EventArgs e)
        {

        }

       
    }
}
