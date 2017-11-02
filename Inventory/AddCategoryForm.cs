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
    public partial class AddCategoryForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        int ID = 0;
        DataTable dt = new DataTable();
        public AddCategoryForm()
        {
            InitializeComponent();
            Display();
            


        }

        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

        }

        private void addCatBtn_Click(object sender, EventArgs e)
        {

            var category_n = cat_name.Text;
            var p_model = product_model.Text;
            string catName = "";
            string catModel = "";
            string myString = ID.ToString();
            if (category_n != "" || p_model != "")
            {
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string fetchQuery = "SELECT category_name,product_model FROM Category_details";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                connection.Open();
                System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    catName = reader1["category_name"].ToString();
                    catModel = reader1["product_model"].ToString();
                }
                connection.Close();

                if (catName != category_n && catModel != p_model)
                {
                    string query = "INSERT INTO Category_details VALUES('" + category_n + "','" + p_model + "','Delete')";
                    System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Add Category Successfully");
                    Display();
                    ClearData();
                }else{
                    MessageBox.Show("Category already in Database!!");
                }

              }else{
              
                MessageBox.Show("Please FillUp Form Details!!");
              }
        }

        private void viewCatdataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(viewCatdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            cat_name.Text = viewCatdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            product_model.Text = viewCatdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        public void Display(){
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT id,category_name,product_model FROM Category_details";

            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            if (reader1.HasRows)
            {
                //productNamePurchase.Items.Add(reader1["StockName"].ToString
                dt.Load(reader1);
                viewCatdataGridView.DataSource = dt;
            }

            connection.Close();
        }

        //Clear Data  
        private void ClearData()
        {
            cat_name.Text = "";
            product_model.Text = "";
            ID = 0;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string myString = ID.ToString();
            var cat = cat_name.Text;
            var model = product_model.Text;

            if (cat != "" || model!="")
            {
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string fetchQuery = "UPDATE Category_details SET category_name='" + cat + "',product_model='" + cat + "' WHERE id='" + myString + "'";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                connection.Open();
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Update Successfully!");
                Display();
                ClearData();
            }else{
                MessageBox.Show("Please Select a Row!!");
            }
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string myString = ID.ToString();

                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string fetchQuery = "DELETE FROM Category_details WHERE id='" + myString + "'";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                connection.Open();
                command1.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted Successfully!");
                Display();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }
    }
}
