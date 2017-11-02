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
    public partial class DebitInfoForm : Form
    {
        string cat = "";
        string model = "";
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public DebitInfoForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DebitInfoForm_Load(object sender, EventArgs e)
        {
            this.debitInfodataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.debitInfodataGridView_RowPostPaint);
        }

        private void DisplayData()
        {

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT SalesDetails.SalesID,SalesDetails.stock_name,SalesDetails.category,SalesDetails.product_model,SalesDetails.grossTotal,SalesDetails.dueAmount,CustomerDetails.Name,SalesDetails.payment FROM SalesDetails INNER JOIN CustomerDetails ON SalesDetails.customerId=CustomerDetails.Contact AND SalesDetails.dueAmount!='0'";
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
                debitInfodataGridView.DataSource = dt;
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
            paymentTextBox.Text = "";
        }

        private void debitInfodataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            purchaseIDtextBox.Text = debitInfodataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            pNametextBox.Text = debitInfodataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            suppliertextBox.Text = debitInfodataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            dueAmounttextBox.Text = debitInfodataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            paymentTextBox.Text = debitInfodataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

            cat = debitInfodataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            model = debitInfodataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
        }

        private void payNowBtn_Click(object sender, EventArgs e)
        {
            if (purchaseIDtextBox.Text == "" || pNametextBox.Text == "" || suppliertextBox.Text == "" || dueAmounttextBox.Text == "")
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

                float p = float.Parse(paymentTextBox.Text);
                float due = float.Parse(dueAmounttextBox.Text);

                float d = due + p;

                var updatePaypent = d.ToString();

                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string updaetQuery1 = "UPDATE SalesDetails SET dueAmount='0',payment='" + updatePaypent + "'  WHERE SalesID='" + purchaseIDtextBox.Text + "'";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(updaetQuery1, connection);

                string insertQuery = "INSERT INTO DuePaid VALUES('" + dueInvoicetextBox.Text + "','" + purchaseIDtextBox.Text + "','" + date + "','Debit')";
                System.Data.SqlClient.SqlCommand insertcommand = new System.Data.SqlClient.SqlCommand(insertQuery, connection);

                connection.Open();
                command1.ExecuteNonQuery();
                insertcommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Due Paid Successfully!");
                DisplayData();
                ClearData();

                DebitInvoiceForm salesReport = new DebitInvoiceForm();
                this.Hide();
                salesReport.invoiceNo.Text = dueInvoicetextBox.Text;

                salesReport.cusName.Text = sname.ToString();

                salesReport.salesDate.Text = date.ToString();


                salesReport.purchaseIDLabel.Text = pid.ToString();
                salesReport.itemLabel.Text = pname.ToString();

                salesReport.catLabel.Text = cat.ToString();

                salesReport.modelLabel.Text = model.ToString();

                salesReport.dueLabel.Text = due.ToString() + "TK";

                salesReport.paidAmountLabel.Text = due.ToString() + "TK";


                salesReport.Show();


            }
        }

        private void debitInfodataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(debitInfodataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
