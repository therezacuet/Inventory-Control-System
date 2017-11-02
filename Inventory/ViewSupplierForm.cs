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
    public partial class ViewSupplierForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public ViewSupplierForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void ViewSupplierForm_Load(object sender, EventArgs e)
        {
            this.supplierdataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.supplierdataGridView_RowPostPaint);
        }

        private void DisplayData()
        {

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT Name,Address,Contact FROM CustomerDetails";
            string supQuery = "SELECT Name,Address,Contact FROM Supplier_Details";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(supQuery, connection);
            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
           

            connection.Open();
            System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader);
                supplierdataGridView.DataSource = dt;
            }
            else
            {
                noResult.Visible = true;
            }

            connection.Close();
        }

        private void supplierdataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(supplierdataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
