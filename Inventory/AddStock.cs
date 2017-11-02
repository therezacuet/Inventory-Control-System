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
    public partial class AddStockForm : Form
    {

        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public AddStockForm()
        {
            InitializeComponent();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT category_name FROM Category_details";
            
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();

           
            while (reader.Read())
            {
                categoryCombo.Items.Add(reader["category_name"].ToString());
            }

            connection.Close();
        }
        

        private void addProductButton_Click(object sender, EventArgs e)
        {

            var product_name = productNameText.Text;

            var category = categoryCombo.SelectedItem;

            var product_model = productModelCombo.SelectedItem;

            

            if (product_name!="")
            {
                
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);



                string query = "INSERT INTO StockDetails VALUES('" + product_name + "','" + category + "','" + product_model + "','Delete')";
                System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);

                connection.Open();
            
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Add Stock Successfully!!");
                productNameText.Text = "";
                categoryCombo.Items.Add("");
                productModelCombo.Items.Add("");

            }else{

                MessageBox.Show("Please FillUp Form Details!!");
            }



            
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT product_model FROM Category_details WHERE category_name='"+categoryCombo.SelectedItem+"'";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();


            System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                productModelCombo.Items.Add(reader1["product_model"].ToString());
            }

            connection.Close();
        }

        private void AddStockForm_Load(object sender, EventArgs e)
        {

        }
    }
}
