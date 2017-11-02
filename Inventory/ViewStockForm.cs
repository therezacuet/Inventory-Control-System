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
    public partial class ViewStockForm : Form
    {

        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        int ID = 0;
        string pr = "";
        public ViewStockForm()
        {
            InitializeComponent();
            DisplayData();

        }
       
        
        private void ViewStockForm_Load(object sender, EventArgs e)
        {
            this.stockDataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.stockDataGridView_RowPostPaint);
            
        }

        private void addStock_Click(object sender, EventArgs e)
        {
            var product_name = name_TextBox.Text;

            var category = catTextBox.Text;

            var product_model = modelTextBox.Text;
            string pName = "";
            string catName = "";
            string catModel = "";

            if (product_name != "" || category != "" || product_model!="")
                {
                   
                    System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    string fetchQuery = "SELECT * FROM StockDetails";
                    System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                    connection.Open();
                    System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();
                    while (reader1.Read())
                    {
                        catName = reader1["Category"].ToString();
                        catModel = reader1["ProductModel"].ToString();
                        pName = reader1["StockName"].ToString();
                    }
                    connection.Close();
                    if (catName != category && catModel != product_model && pName != product_name)
                    {

                        string query = "INSERT INTO StockDetails VALUES('" + product_name + "','" + category + "','" + product_model + "','Delete')";
                        System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

                        connection.Open();

                        command.ExecuteNonQuery();

                        connection.Close();
                        MessageBox.Show("Add Stock Successfully!!");
                        DisplayData();
                        ClearData();
                    }
                    else
                    {
                        MessageBox.Show("Stock already in Database!!");
                        ClearData();
                    }

                }
                else
                {

                    MessageBox.Show("Please FillUp Form Details!!");
                }

        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            var addCategory = new AddCategoryForm();
            addCategory.Show();
        }

        private void DisplayData()
        {
           
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            
            string fetchQuery = "SELECT StockID,StockName,Category,ProductModel FROM StockDetails";
            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString());
                DataTable dt = new DataTable();
                dt.Load(reader1);
                stockDataGridView.DataSource = dt;
            }
            else
            {
                resultTextLabel.Visible = true;
            }
            connection.Close();
        }

        

        private void stockDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            pr = stockDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            //Int32.TryParse(pr, out ID);

            name_TextBox.Visible = true;
            catTextBox.Visible = true;
            modelTextBox.Visible = true;
             
            
            name_TextBox.Text = stockDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            catTextBox.Text = stockDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            modelTextBox.Text = stockDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

            //MessageBox.Show(""+ID);
        }

        //Clear Data  
        private void ClearData()
        {
            name_TextBox.Text = "";
            catTextBox.Text = "";
            modelTextBox.Text = "";
            
            ID = 0;
            pr = "";
        }


        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (catTextBox.Visible != true)
            {
                MessageBox.Show("Please Select a Row!!");
            }
            else
            {
                if (pr != "")
                {
                    //string myString = pr.ToString();
                   
                    System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                    string fetchQuery = "DELETE FROM StockDetails WHERE StockID='"+pr+"'";
                    System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                    connection.Open();
                    command1.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    DisplayData();
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Please Select Record to Delete");
                    ClearData();
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (catTextBox.Visible != true)
            {
                MessageBox.Show("Please Select a Row!!");
            }
            else
            {
                //string myString = ID.ToString();
                var name = name_TextBox.Text;
                var cat = catTextBox.Text;
                var model = modelTextBox.Text;
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string fetchQuery = "UPDATE StockDetails SET StockName='" + name + "',Category='" + cat + "',ProductModel='" + model + "' WHERE StockID='" + pr + "'";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                connection.Open();
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Update Successfully!");
                DisplayData();
                ClearData();
            }
        }

        private void resultTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void stockDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(stockDataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }  



        
    }
}
