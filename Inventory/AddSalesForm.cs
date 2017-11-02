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
    public partial class AddSalesForm : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
        float p, pa;
        public AddSalesForm()
        {
            InitializeComponent();

            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT stock_name FROM StockEntries";
            System.Data.SqlClient.SqlCommand command1 = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);

            string fetchQuery2 = "SELECT MAX(ID) FROM SalesDetails";
            System.Data.SqlClient.SqlCommand command2 = new System.Data.SqlClient.SqlCommand(fetchQuery2, connection);
            connection.Open();
            var id = command2.ExecuteScalar();
            if (!(id is DBNull))
            {
                int maxId = Convert.ToInt32(id);
                int pID = maxId + 1;
                var pid = "SL1204088-" + pID;
                invoiceTextBox.Text = pid.ToString();
            }
            else
            {
                var pid = "SL1204088-1";
                invoiceTextBox.Text = pid.ToString();
            }




            System.Data.SqlClient.SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                pCombo.Items.Add(reader1["stock_name"].ToString());
            }

            connection.Close();

            grossTotal.Text = "0.00";

            
 
        }


        private void AddSalesForm_Load(object sender, EventArgs e)
        {
            this.salesGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.salesGridView_RowPostPaint);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
  
        private void pCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT category FROM StockEntries WHERE stock_name='" + pCombo.SelectedItem + "'";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();
            System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                cCombo.Items.Add(reader1["category"].ToString());
                 


            }
            connection.Close();
        }

        private void cCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT product_model FROM StockEntries WHERE stock_name='" + pCombo.SelectedItem + "' AND category='" + cCombo.SelectedItem + "'";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();
            System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                mCombo.Items.Add(reader1["product_model"].ToString());
 
            }
            connection.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var pName = pCombo.SelectedItem;
            var cName = cCombo.SelectedItem;
            var model = mCombo.SelectedItem;
            var quty = qTextBox.Text;
            var price = pTextBox.Text;
            var stock = stockTextBox.Text;
            var total = tTextBox.Text;
            float t = 0;
            var pt = total;
            float.TryParse(pt, out t);

            float g;
            var grossT = grossTotal.Text;
            float.TryParse(grossT, out g);
 
            g = g + t;



            if (quty != "" || price != "" || stock != "" || total != "")
            {
                this.salesGridView.Rows.Insert(0, pName, cName, model, quty, price, stock, total, "X");
                grossTotal.Text = g.ToString();
                 
                Clear();
            }
            else {
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
            stockTextBox.Text = "";
            tTextBox.Text = "";
        }

        private void mCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            string fetchQuery = "SELECT DISTINCT quantity FROM StockEntries WHERE stock_name='" + pCombo.SelectedItem + "' AND category='" + cCombo.SelectedItem + "' AND product_model='" + mCombo.SelectedItem + "'";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(fetchQuery, connection);
            connection.Open();
            System.Data.SqlClient.SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                stockTextBox.Text = reader1["quantity"].ToString();
            }
            connection.Close();
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

        private void salesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                
                    salesGridView.Rows.RemoveAt(e.RowIndex);
                    discount.Text = "";
                    disAmTextBox.Text = "";
                    grossTotal.Text = "";
                    paymentSales.Text = "";
                    dueAmount.Text = "";
                    payableAmount.Text = "";

            }
        }


        private void addSales_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            var date = dateTime.ToString("dd-MM-yyyy");

            var invoiceNo=invoiceTextBox.Text;
            var challanNo=chalantextBox.Text;
            var purchaseWorkOrder=purchaseOrdertextBox.Text;

            var cusName=cusNametextBox.Text;
            var cusAddress=cusAddressTextBox.Text;
            var cusContact=cuscontactTextBox.Text;

            var dis=discount.Text;
            var discountAmount=disAmTextBox.Text;

            var gross_total=grossTotal.Text;
            var payableTotal=payableAmount.Text;

            var paymentTotal=paymentSales.Text;

            var dueTotal=dueAmount.Text;
            var mode = paymentMode.SelectedItem;
            var contactCheck = "";
            if (challanNo != "" || purchaseWorkOrder != "" || cusName != "" || cusContact != "" || payableTotal != "")
            {
                System.Data.SqlClient.SqlConnection connection1 = new System.Data.SqlClient.SqlConnection(connectionString);
                string supfetchQuery = "SELECT Contact FROM CustomerDetails";
                System.Data.SqlClient.SqlCommand commandfetch = new System.Data.SqlClient.SqlCommand(supfetchQuery, connection1);
                connection1.Open();
                System.Data.SqlClient.SqlDataReader reader1 = commandfetch.ExecuteReader();
                while (reader1.Read())
                {
                    contactCheck = reader1["Contact"].ToString();
                }
                connection1.Close();

                //invoice start
                SalesInvoiceForm salesReport = new SalesInvoiceForm();
                this.Hide();
                salesReport.invoiceNoLabel.Text = "Invoice No : " + invoiceNo.ToString();
                salesReport.nameLabel.Text = "Customer Name :" + cusName.ToString();
                salesReport.addressLabel.Text = "Address : " + cusAddress.ToString();
                salesReport.contactlabel.Text = "Contact No :" + cusContact.ToString();
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
                            if (cusContact != contactCheck)
                            {
                                string queryCus = "INSERT INTO CustomerDetails VALUES('" + cusName + "','" + cusAddress + "','" + cusContact + "')";
                                comm.CommandText = queryCus;
                                comm.ExecuteNonQuery();
                            }
 
                            for (int i = 0; i < salesGridView.Rows.Count; i++)
                            {
                                var s = salesGridView.Rows[i].Cells["stockAvail"].Value.ToString();
                                var q = salesGridView.Rows[i].Cells["quantityTextBox"].Value.ToString();
                                int s4 = int.Parse(s);
                                int q4 = int.Parse(q);
                                int avail = s4 - q4;
                                var updatedStock = avail.ToString();
                                string updaetQuery = "UPDATE StockEntries SET quantity='" + updatedStock + "' WHERE stock_name='" + salesGridView.Rows[i].Cells["productNameTextBox"].Value + "' AND category='" + salesGridView.Rows[i].Cells["catTextBox"].Value + "' AND product_model='" + salesGridView.Rows[i].Cells["modelTextBox"].Value + "'";
                                System.Data.SqlClient.SqlCommand commandUpdate1 = new System.Data.SqlClient.SqlCommand(updaetQuery, connection);
                                commandUpdate1.ExecuteNonQuery();

                                  StrQuery = @"INSERT INTO SalesDetails VALUES ('"
                                    + invoiceNo + "', '"
                                    + challanNo + "', '"
                                    + purchaseWorkOrder + "', '"
                                    + salesGridView.Rows[i].Cells["productNameTextBox"].Value + "',' "
                                    + salesGridView.Rows[i].Cells["catTextBox"].Value + "', '"
                                    + salesGridView.Rows[i].Cells["modelTextBox"].Value + "', '"
                                    + salesGridView.Rows[i].Cells["priceTextBox"].Value + "', '"
                                    + salesGridView.Rows[i].Cells["quantityTextBox"].Value + "', '"
                                    + cusContact + "', '" 
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

                                salesReport.testdataGridView1.Rows.Insert(0, salesGridView.Rows[i].Cells["productNameTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["catTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["modelTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["priceTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["quantityTextBox"].Value.ToString(), salesGridView.Rows[i].Cells["totalTextBox"].Value.ToString());
                             
                            }
                            salesGridView.Rows.Clear();
                            salesGridView.Refresh();
                            //MessageBox.Show("Successfull!!");

                             
                            salesReport.dLabel.Text = "Discount : " + dis.ToString() + " %";
                            //salesReport.disamountLabel.Text = discountAmount.ToString() + "TK";
                            //salesReport.payableAmountLabel.Text = payableTotal.ToString();

                            salesReport.gTotalLabel.Text = "Gross Total : " + gross_total.ToString() + " TK";
                            salesReport.dueLabel.Text = "Due Amount : " + dueTotal.ToString() + " TK";
                            salesReport.paymentLabel.Text = "Payment Amount : " + paymentTotal.ToString() + " TK";

                            salesReport.Show();
                        }
                    }
                }
                catch (System.Data.SqlClient.SqlException es)
                {
                    MessageBox.Show("Error!" + es.Message, "Error");
                }
            }else{
                MessageBox.Show("Please Add Form Details !!");
            }
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            float gt, d;
            var gross = grossTotal.Text;
            float.TryParse(gross, out gt);

            var diss = discount.Text;
            float.TryParse(diss, out d);
            float dis_am = (gt * d) / 100;
            disAmTextBox.Text = dis_am.ToString();

            float payable = (float.Parse(grossTotal.Text)) - dis_am;
            payableAmount.Text = payable.ToString();
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
            var pt = paymentSales.Text;
            float.TryParse(pt, out p);

            var pta = payableAmount.Text;
            float.TryParse(pta, out pa);
            if (p >= pa)
            {
                dueAmount.Text = "0";
                paymentSales.Text = float.Parse(payableAmount.Text).ToString();
            }
            else
            {
                float duepayment = pa - p;
                dueAmount.Text = duepayment.ToString();
            }

        }

        private void qTextBox_TextChanged(object sender, EventArgs e)
        {
            int q;
            var pt = qTextBox.Text;
            int.TryParse(pt, out q);

            int s;
            var st = stockTextBox.Text;
            int.TryParse(st, out s);

            if (q >= s)
            {

                qTextBox.Text = int.Parse(stockTextBox.Text).ToString();
            }
        }

        private void chalantextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
 

        private void purchaseOrdertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cuscontactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void qTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void pTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void payment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void salesGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(salesGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dueAmount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void invoiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
