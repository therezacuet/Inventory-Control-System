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
    public partial class AllReportForm : Form
    {

        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public AllReportForm()
        {
            InitializeComponent();
            this.purdateTimePicker1.Value = DateTime.Now;
            this.purdateTimePicker2.Value = DateTime.Now;
            this.salesdateTimePicker1.Value = DateTime.Now;
            this.salesdateTimePicker2.Value = DateTime.Now;
            this.debitdateTimePicker1.Value = DateTime.Now;
            this.debitdateTimePicker2.Value = DateTime.Now;
            this.creditdateTimePicker1.Value = DateTime.Now;
            this.creditdateTimePicker2.Value = DateTime.Now;
            this.prodateTimePicker1.Value = DateTime.Now;
            this.prodateTimePicker2.Value = DateTime.Now;
        }

        private void AllReportForm_Load(object sender, EventArgs e)
        {

        }

        private void purReportBtn_Click(object sender, EventArgs e)
        {
            PurchaseReportInvoiceForm purReport = new PurchaseReportInvoiceForm();
            this.Hide();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT StockEntries.stock_name,StockEntries.category,StockEntries.product_model,StockEntries.price,StockEntries.quantity,StockEntries.total,StockEntries.date,Supplier_Details.Name FROM StockEntries INNER JOIN Supplier_Details ON StockEntries.supplier_id=Supplier_Details.Contact WHERE date BETWEEN '" + purdateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + purdateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                purReport.reportGridView.DataSource = dt;
            }

            connection.Close();
            purReport.fromdateLabel.Text = purdateTimePicker1.Value.Date.ToString("d/M/yyyy");
            purReport.toDateLabel.Text = purdateTimePicker2.Value.Date.ToString("d/M/yyyy");
            purReport.Show();

        }

        private void salesReportBtn_Click(object sender, EventArgs e)
        {
            SalesReportInvoice salesReport = new SalesReportInvoice();
            this.Hide();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT Salesdetails.stock_name,Salesdetails.category,Salesdetails.product_model,Salesdetails.price,Salesdetails.quantity,Salesdetails.total,Salesdetails.date,CustomerDetails.Name FROM Salesdetails INNER JOIN CustomerDetails ON Salesdetails.customerId=CustomerDetails.Contact WHERE date BETWEEN '" + salesdateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + salesdateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                salesReport.reportGridView.DataSource = dt;
            }

            connection.Close();
            salesReport.fromDateLabel.Text = purdateTimePicker1.Value.Date.ToString("d/M/yyyy");
            salesReport.toDateLabel.Text = purdateTimePicker2.Value.Date.ToString("d/M/yyyy");
            salesReport.Show();
        }

        private void debitBtn_Click(object sender, EventArgs e)
        {
            DebitReportInvoiceForm debitReport = new DebitReportInvoiceForm();
            this.Hide();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT CustomerDetails.Name,CustomerDetails.Address,CustomerDetails.Contact,SalesDetails.dueAmount,SalesDetails.date FROM SalesDetails INNER JOIN CustomerDetails ON SalesDetails.customerId=CustomerDetails.Contact AND SalesDetails.dueAmount!='0' WHERE date BETWEEN '" + debitdateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + debitdateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                debitReport.reportGridView.DataSource = dt;
            }

            connection.Close();
            debitReport.fromdateLabel.Text = debitdateTimePicker1.Value.Date.ToString("d/M/yyyy");
            debitReport.toDateLabel.Text = debitdateTimePicker2.Value.Date.ToString("d/M/yyyy");
            debitReport.Show();
        }

        private void creditBtn_Click(object sender, EventArgs e)
        {
            CreditReportInvoiceForm creditReport = new CreditReportInvoiceForm();
            this.Hide();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT Supplier_Details.Name,Supplier_Details.Address,Supplier_Details.Contact,StockEntries.dueAmount,StockEntries.date FROM StockEntries INNER JOIN Supplier_Details ON StockEntries.supplier_id=Supplier_Details.Contact AND StockEntries.dueAmount!='0' WHERE date BETWEEN '" + creditdateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + creditdateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                creditReport.reportGridView.DataSource = dt;
            }

            connection.Close();
            creditReport.fromdateLabel.Text = debitdateTimePicker1.Value.Date.ToString("d/M/yyyy");
            creditReport.toDateLabel.Text = debitdateTimePicker2.Value.Date.ToString("d/M/yyyy");
            creditReport.Show();
        }

        private void profitBtn_Click(object sender, EventArgs e)
        {

            FinancialReportInvoiceForm finanReport = new FinancialReportInvoiceForm();
            this.Hide();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuerypurchase = "SELECT SUM(CONVERT(float,payableAmount)) from dbo.StockEntries WHERE date BETWEEN '" + prodateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + prodateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";
            string fetchQueryPurdue = "SELECT SUM(CONVERT(float,dueAmount)) from dbo.StockEntries WHERE dueAmount!='0' AND date BETWEEN '" + prodateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + prodateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            string fetchQuerysales = "SELECT SUM(CONVERT(float,payableAmount)) from dbo.SalesDetails WHERE date BETWEEN '" + prodateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + prodateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            string fetchQuerySalesdue = "SELECT SUM(CONVERT(float,dueAmount)) from dbo.SalesDetails WHERE dueAmount!='0' AND date BETWEEN '" + prodateTimePicker1.Value.Date.ToString("d/M/yyyy") + "' AND '" + prodateTimePicker2.Value.Date.ToString("d/M/yyyy") + "'";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuerypurchase, connection);
            System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand(fetchQueryPurdue, connection);
            System.Data.SqlClient.SqlCommand command3 = new System.Data.SqlClient.SqlCommand(fetchQuerysales, connection);
            System.Data.SqlClient.SqlCommand command4 = new System.Data.SqlClient.SqlCommand(fetchQuerySalesdue, connection);
            connection.Open();

            var totalpurchase = command1.ExecuteScalar();
            connection.Close();

            connection.Open();
           
            var totalPurchaseDue = command2.ExecuteScalar();
            connection.Close();

            connection.Open();
          
            var totalSales = command3.ExecuteScalar();
            connection.Close();

            connection.Open();
           
            var totalSalesDue = command4.ExecuteScalar();
            connection.Close();

            //MessageBox.Show("Pur: "+totalpurchase +"Total pur Due :"+ totalPurchaseDue +"Total Sales :"+totalSales +"Total Sales Due :"+totalSalesDue);

            finanReport.fromdateLabel.Text = prodateTimePicker1.Value.Date.ToString("d/M/yyyy");
            finanReport.todateLabel.Text = prodateTimePicker2.Value.Date.ToString("d/M/yyyy");
            finanReport.totalPurchaseLabel.Text = totalpurchase.ToString()+" TK";
            finanReport.totalSaleslabel.Text = totalSales.ToString() + " TK";

            float pt = 0;
            float.TryParse(totalpurchase.ToString(), out pt);

            float st = 0;
            float.TryParse(totalSales.ToString(), out st);

            float sum = pt + st;

            //finanReport.totalAmount.Text = sum.ToString() + " TK";

            finanReport.totalsalesDueLabel.Text = totalSalesDue.ToString() + " TK";
            finanReport.totalPurDueLabel.Text = totalPurchaseDue.ToString() + " TK";

            float pdt = 0;
            float.TryParse(totalPurchaseDue.ToString(), out pdt);

            float sdt = 0;
            float.TryParse(totalSalesDue.ToString(), out sdt);

            float sumd = pdt + sdt;
            //finanReport.totalDueAmount.Text = sumd.ToString() + " TK";

    
            finanReport.Show();

        }
    }
}
