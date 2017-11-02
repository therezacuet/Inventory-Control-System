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
    public partial class SplashScreenForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var username = userNameTextBox.Text;

            var pass = passwordTextBox.Text;
            if (username!="" && pass!="")
            {
                System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
                string fetchQuery = "SELECT * FROM AdminTable";
                System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
                connection.Open();
                System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    var user=reader1["userName"].ToString();
                    var p=reader1["password"].ToString();
                    if (user == username &&  p== pass)
                    {
                        DashboardForm main = new DashboardForm();
                        main.Show();

                        SplashScreenForm s = new SplashScreenForm();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Incorrect UserName or Password!!");
                    }
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Enter UserName and Password!!");
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            int loadCount = Inventory.Properties.Settings.Default.LoadCount;
            if (loadCount > 50)
            {
                MessageBox.Show("Trial version expired! Please Contact with 01745-454894");
                this.Close();
            }
        }

        private void SplashScreenForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Inventory.Properties.Settings.Default.LoadCount += 1;
                Inventory.Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Failed to save settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
