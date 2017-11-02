using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class CreditInfoForm : Form
    {

        string cat="";
        string model = "";
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public CreditInfoForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void CreditInfoForm_Load(object sender, EventArgs e)
        {
            this.creditInfodataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.creditInfodataGridView_RowPostPaint);
        }

        private void DisplayData()
        {

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT StockEntries.PrID,StockEntries.stock_name,StockEntries.category,StockEntries.product_model,StockEntries.grossTotal,StockEntries.dueAmount,Supplier_Details.Name,StockEntries.payment FROM StockEntries INNER JOIN Supplier_Details ON StockEntries.supplier_id=Supplier_Details.Contact AND StockEntries.dueAmount!='0'";
            string fetchQuery2 = "SELECT MAX(ID) FROM DuePaid";
            System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand(fetchQuery2, connection);

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            var id = command2.ExecuteScalar();
            if (!(id is DBNull))
            {
                int maxId = Convert.ToInt32(id);
                int pID = maxId + 1;
                var pid = "DUE" + pID;
                dueInvoicetextBox.Text = pid.ToString();
            }
            else
            {
                var pid = "DUE1";
                dueInvoicetextBox.Text = pid.ToString();
            }

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                creditInfodataGridView.DataSource = dt;
            }
            else
            {
                resultTextLabel.Visible = true;
            }
            connection.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            purchaseIDtextBox.Text = "";
            pNametextBox.Text = "";
            suppliertextBox.Text = "";
            dueAmounttextBox.Text = "";
           
        }

        private void creditInfodataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            purchaseIDtextBox.Text = creditInfodataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            pNametextBox.Text = creditInfodataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            suppliertextBox.Text = creditInfodataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            dueAmounttextBox.Text = creditInfodataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();

            cat = creditInfodataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            model = creditInfodataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            payDuetextBox.Text=creditInfodataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void payNowBtn_Click(object sender, EventArgs e)
        {
            if (purchaseIDtextBox.Text == "" || pNametextBox.Text == "" || suppliertextBox.Text=="" || dueAmounttextBox.Text=="")
            {
                MessageBox.Show("Please Select Row and Enter Due Amount!!");
            }
            else
            {
                DateTime dateTime = DateTime.UtcNow.Date;
                var date = dateTime.ToString("dd-MM-yyyy");

                var pid = purchaseIDtextBox.Text;
                var pname = pNametextBox.Text;
                var sname = suppliertextBox.Text;

                float paidDue = float.Parse(payDuetextBox.Text);
                float payAmount = float.Parse(dueAmounttextBox.Text);

                float d = paidDue + payAmount;

                var updatePaypent=d.ToString();
                
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string updaetQuery1 = "UPDATE StockEntries SET dueAmount='0',payment='" + updatePaypent + "'  WHERE PrID='" + purchaseIDtextBox.Text + "'";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(updaetQuery1, connection);

                string insertQuery = "INSERT INTO DuePaid VALUES('" + dueInvoicetextBox.Text + "','" + purchaseIDtextBox.Text + "','"+date+"','Credit')";
                System.Data.SqlClient.SqlCommand insertcommand = new System.Data.SqlClient.SqlCommand(insertQuery, connection);

                connection.Open();
                command1.ExecuteNonQuery();
                insertcommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Due Paid Successfully!");
                DisplayData();
                ClearData();

                CreditInvoiceForm salesReport = new CreditInvoiceForm();
                this.Hide();
                salesReport.invoiceNo.Text = dueInvoicetextBox.Text;

                salesReport.cusName.Text = sname.ToString();
                
                salesReport.salesDate.Text = date.ToString();


                salesReport.purchaseIDLabel.Text =pid.ToString();
                salesReport.itemLabel.Text = pname.ToString();

                salesReport.catLabel.Text = cat.ToString();

                salesReport.modelLabel.Text = model.ToString();

                salesReport.dueLabel.Text = payAmount.ToString() + "TK";

                salesReport.paidAmountLabel.Text = payAmount.ToString() + "TK";
               

                salesReport.Show();


            }
        }

        private void creditInfodataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(creditInfodataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

    }
}
