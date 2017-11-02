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
    public partial class AddPurchaseForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        public AddPurchaseForm()
        {
            InitializeComponent();

           
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT StockName FROM StockDetails";
            string fetchQuery2 = "SELECT MAX(ID) FROM StockEntries";
            System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand(fetchQuery2, connection);
            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();

            var id = command2.ExecuteScalar();
            if (!(id is DBNull))
            {
                int maxId = Convert.ToInt32(id);
                int pID = maxId + 1;
                var pid = "PR1204088-" + pID;
                invoiceTextBox.Text = pid.ToString();
            }
            else
            {
                var pid = "PR1204088-1";
                invoiceTextBox.Text = pid.ToString();
            }


            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();


            while (reader1.Read())
            {
                pCombo.Items.Add(reader1["StockName"].ToString());
            }

            connection.Close();
            grossTotal.Text = "0.00";
        }
 

        private void AddPurchaseForm_Load(object sender, EventArgs e)
        {
            this.salesGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.salesGridView_RowPostPaint);
        }


        
        private void addPurchase_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            var date = dateTime.ToString("dd-MM-yyyy");

            var invoiceNo = invoiceTextBox.Text;
            

            var sName = supNametextBox.Text;
            var sAddress = supAddressTextBox.Text;
            var sContact = supContactTextBox.Text;

            var dis = discount.Text;
            var discountAmount = disAmTextBox.Text;

            var gross_total = grossTotal.Text;
            var payableTotal = payableAmount.Text;

            var paymentTotal = payment.Text;

            var dueTotal = dueAmount.Text;
            var mode = paymentMode.SelectedItem;
            var contactCheck = "";


            System.Data.SqlClient.SqlConnection connection1 = new System.Data.SqlClient.SqlConnection(connectionString);
            string supfetchQuery = "SELECT Contact FROM Supplier_Details";
            System.Data.SqlClient.SqlCommand commandfetch = new System.Data.SqlClient.SqlCommand(supfetchQuery, connection1);
            connection1.Open();
            System.Data.SqlClient.SqlDataReader reader1 = commandfetch.ExecuteReader();
            while (reader1.Read())
            {
                contactCheck = reader1["Contact"].ToString();
            }
            connection1.Close();

            //invoice start
            PInvoiceForm salesReport = new PInvoiceForm();
            this.Hide();
            salesReport.invoiceNoLabel.Text = "Invoice No : "+invoiceNo.ToString();
            salesReport.nameLabel.Text = "Supplier Name :"+sName.ToString();
            salesReport.addressLabel.Text = "Address : " + sAddress.ToString();
            salesReport.contactlabel.Text = "Contact No :" + sContact.ToString();
            // some portion end
 
            string StrQuery;
            try
            {
                using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
                { 
                    using (System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand())
                    {
                        comm.Connection = connection;
                        connection.Open();
                        if (sContact != contactCheck)
                        {
                            string queryCus = "INSERT INTO Supplier_Details VALUES('" + sName + "','" + sAddress + "','" + sContact + "')";
                            comm.CommandText = queryCus;
                            comm.ExecuteNonQuery();
                        }
                       
                        for (int i = 0; i < salesGridView.Rows.Count; i++)
                        {

                            //var pCheck = "";
                            //var cCheck = "";
                            //var mCheck = "";
                            //var stockCheck = "";
                            //string fetchQuery = "SELECT * FROM StockEntries";
                            //comm.CommandText = fetchQuery;
                            //System.Data.SqlClient.SqlDataReader reader3 = comm.ExecuteReader();
                            //while (reader3.Read())
                            //{
                            //    pCheck = reader3["stock_name"].ToString();
                            //    cCheck = reader3["category"].ToString();
                            //    mCheck = reader3["product_model"].ToString();
                            //    stockCheck = reader3["quantity"].ToString();
                            //}

                            //connection.Close();
                            //connection.Open();
                            //if (pCheck == salesGridView.Rows[i].Cells["productNameTextBox"].Value && cCheck == salesGridView.Rows[i].Cells["catTextBox"].Value && mCheck == salesGridView.Rows[i].Cells["modelTextBox"].Value)
                            //{
                                
                            //    var q = salesGridView.Rows[i].Cells["quantityTextBox"].Value.ToString();
                            //    int s4 = int.Parse(stockCheck);
                            //    int q4 = int.Parse(q);
                            //    int avail = s4 + q4;
                            //    var updatedStock = avail.ToString();
                            //    string updaetQuery = "UPDATE StockEntries SET quantity='" + updatedStock + "' WHERE stock_name='" + salesGridView.Rows[i].Cells["productNameTextBox"].Value + "' AND category='" + salesGridView.Rows[i].Cells["catTextBox"].Value + "' AND product_model='" + salesGridView.Rows[i].Cells["modelTextBox"].Value + "'";
                            //    comm.CommandText = updaetQuery;

                            //    comm.ExecuteNonQuery();

                            //}
                            //else{
                                  StrQuery = @"INSERT INTO StockEntries VALUES ('"
                                  + invoiceNo + "','"
                                  + salesGridView.Rows[i].Cells["productNameTextBox"].Value + "',' "
                                  + salesGridView.Rows[i].Cells["catTextBox"].Value + "', '"
                                  + salesGridView.Rows[i].Cells["modelTextBox"].Value + "', '"
                                  + sContact + "', '"
                                  + salesGridView.Rows[i].Cells["priceTextBox"].Value + "', '"
                                  + salesGridView.Rows[i].Cells["quantityTextBox"].Value + "','"
                                  + salesGridView.Rows[i].Cells["totalTextBox"].Value + "', '"
                                  + dis + "', '"
                                  + discountAmount + "', '"
                                  + gross_total + "', '"
                                  + paymentTotal + "', '"
                                  + dueTotal + "', '"
                                  + payableTotal + "', '"
                                  + mode + "', '"
                                  + date + "')";

                                comm.CommandText = StrQuery;
                             
                                comm.ExecuteNonQuery();
                            //}

                                 
                                salesReport.testdataGridView1.Rows.Insert(0,salesGridView.Rows[i].Cells["productNameTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["catTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["modelTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["priceTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["quantityTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["totalTextBox"].Value.ToString());
                                

                        }
                        salesGridView.Rows.Clear();
                        salesGridView.Refresh();
                        //MessageBox.Show("Successfull!!");
                        salesReport.dLabel.Text ="Discount : "+ dis.ToString()+" %";
                        //salesReport.disamountLabel.Text = discountAmount.ToString() + "TK";
                        //salesReport.payableAmountLabel.Text = payableTotal.ToString();

                        salesReport.gTotalLabel.Text ="Gross Total : "+ gross_total.ToString() + " TK";
                        salesReport.dueLabel.Text ="Due Amount : "+ dueTotal.ToString() + " TK";
                        salesReport.paymentLabel.Text ="Payment Amount : "+ paymentTotal.ToString() + " TK";

                        salesReport.Show();

                            
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException es)
            {
                MessageBox.Show("Error!" + es.Message, "Error");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT Category FROM StockDetails WHERE StockName='" + pCombo.SelectedItem + "'";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();


            System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                cCombo.Items.Add(reader1["Category"].ToString());
            }

            connection.Close();
        }

        private void cCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT ProductModel FROM StockDetails WHERE StockName='" + pCombo.SelectedItem + "' AND Category='" + cCombo.SelectedItem + "'";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();


            System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();

            while (reader1.Read())
            {
                mCombo.Items.Add(reader1["ProductModel"].ToString());
            }

            connection.Close();
        }

        private void mCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            //string fetchQuery = "SELECT quantity FROM StockEntries WHERE stock_name='" + pCombo.SelectedItem + "' AND category='" + cCombo.SelectedItem + "' AND product_model='"+mCombo.SelectedItem+"'";
            //System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            //connection.Open();


            //System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();
            //if(reader1.Read()){
            //    while (reader1.Read())
            //    {
            //        stockTextBox.Text = reader1["quantity"].ToString();
            //    }
            //    connection.Close();
            //}else{
            //    stockTextBox.Text = "0";
            //}
            
            
        }


        private void addItemBtn_Click(object sender, EventArgs e)
        {
            var pName = pCombo.SelectedItem;
            var cName = cCombo.SelectedItem;
            var model = mCombo.SelectedItem;
            var quty = qTextBox.Text;
            var price = pTextBox.Text;
           
            var total = tTextBox.Text;
            float t = 0;
            var pt = total;
            float.TryParse(pt, out t);

            float g;
            var grossT = grossTotal.Text;
            float.TryParse(grossT, out g);

            g = g + t;



            if (quty != "" || price != "" || total != "")
            {
                this.salesGridView.Rows.Insert(0, pName, cName, model, quty, price, total, "X");
                grossTotal.Text = g.ToString();

                Clear();
            }
            else
            {
                MessageBox.Show("Please Select Item and then add!!");
            }

        }

        public void Clear()
        {
            pCombo.ResetText();
            //to reset selected value
            pCombo.SelectedIndex = -1;
            cCombo.ResetText();
            cCombo.SelectedIndex = -1;
            cCombo.Items.Clear();
            mCombo.Items.Clear();
            mCombo.ResetText();
            //to reset selected value
            mCombo.SelectedIndex = -1;

            qTextBox.Text = "";
            pTextBox.Text = "";
            tTextBox.Text = "";
        }

        private void salesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                salesGridView.Rows.RemoveAt(e.RowIndex);

                discount.Text = "";
                disAmTextBox.Text = "";
                grossTotal.Text = "";
                payment.Text = "";
                dueAmount.Text = "";
                payableAmount.Text = "";


            }
        }

        private void pTextBox_TextChanged(object sender, EventArgs e)
        {
            int q = 0;
            var pr = qTextBox.Text;
            Int32.TryParse(pr, out q);

            int p = 0;
            var qr = pTextBox.Text;
            Int32.TryParse(qr, out p);

            int value = (q * p);

            tTextBox.Text = value.ToString();
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            float gt, d;
            var gross = grossTotal.Text;
            float.TryParse(gross, out gt);

            var diss = discount.Text;
            float.TryParse(diss, out d);

            //float gt = float.Parse(grossTotal.Text);
            //float d = float.Parse(discount.Text);
            float dis_am = (gt * d) / 100;
            disAmTextBox.Text = dis_am.ToString();

            float payable = (float.Parse(grossTotal.Text)) - dis_am;
            payableAmount.Text = payable.ToString();
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
            float p, pa;
            var pt = payment.Text;
            float.TryParse(pt, out p);

            var pta = payableAmount.Text;
            float.TryParse(pta, out pa);



            if (p >= pa)
            {
                dueAmount.Text = "0";
                payment.Text = float.Parse(payableAmount.Text).ToString();
            }
            else
            {
                float duepayment = pa - p;
                dueAmount.Text = duepayment.ToString();
            }
        }

        private void salesGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(salesGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void qTextBox_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
