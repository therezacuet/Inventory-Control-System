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
    public partial class ViewSalesForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public ViewSalesForm()
        {
            InitializeComponent();

            DisplayData();
        }

        private void ViewSalesForm_Load(object sender, EventArgs e)
        {
            this.viewSaledataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.viewSaledataGridView_RowPostPaint);
        }

        private void resultTextLabel_Click(object sender, EventArgs e)
        {

        }

        public void DisplayData()
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT SalesDetails.SalesID,SalesDetails.stock_name,SalesDetails.category,SalesDetails.product_model,SalesDetails.price,SalesDetails.quantity,SalesDetails.total,SalesDetails.discount,SalesDetails.discountAmount,SalesDetails.payableAmount,SalesDetails.payment,SalesDetails.dueAmount,SalesDetails.mode,SalesDetails.date,CustomerDetails.Name FROM SalesDetails INNER JOIN CustomerDetails ON SalesDetails.customerId=CustomerDetails.Contact";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                viewSaledataGridView.DataSource = dt;
            }

            else
            {
                resultTextLabel.Visible = true;
            }

            connection.Close();
        }

        private void viewSaledataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(viewSaledataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void refreshBtn_Click_1(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void addsalesPanel_Click(object sender, EventArgs e)
        {
            var addsale = new AddSalesForm();
            addsale.Show();
        }
 
    }
}
