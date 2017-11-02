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
    public partial class ViewPurchaseForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public ViewPurchaseForm()
        {
            InitializeComponent();
            DisplayData();
            viewPurchaseDatagrid.Update();
            viewPurchaseDatagrid.Refresh();
        }

        private void ViewPurchaseForm_Load(object sender, EventArgs e)
        {
            this.viewPurchaseDatagrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.viewPurchaseDatagrid_RowPostPaint);
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            var addPurchase = new AddPurchaseForm();
            addPurchase.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var viewStock = new ViewStockAvail();
            viewStock.Show();
        }

        public void DisplayData()
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT StockEntries.PrID,StockEntries.stock_name,StockEntries.category,StockEntries.product_model,StockEntries.price,StockEntries.quantity,StockEntries.total,StockEntries.discount,StockEntries.discountAmount,StockEntries.payableAmount,StockEntries.payment,StockEntries.dueAmount,StockEntries.mode,StockEntries.date,Supplier_Details.Name FROM StockEntries INNER JOIN Supplier_Details ON StockEntries.supplier_id=Supplier_Details.Contact";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                viewPurchaseDatagrid.DataSource = dt;
            }
            else
            {
                resultTextLabel.Visible = true;
            }
            connection.Close();
        }

        private void refrshBtn_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void viewPurchaseDatagrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(viewPurchaseDatagrid.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void addpurchasePanel_Click(object sender, EventArgs e)
        {
            var addPurchase = new AddPurchaseForm();
            addPurchase.Show();
        }
    }
}
