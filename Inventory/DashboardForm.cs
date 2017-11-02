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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }


        private void salesPanel_Click(object sender, EventArgs e)
        {
            var viewSales = new ViewSalesForm();
            viewSales.Show();
        }

        private void purchasePanel_Click(object sender, EventArgs e)
        {
            var viewPurchase = new ViewPurchaseForm();
            viewPurchase.Show();
        }

        private void stockPanel_Click(object sender, EventArgs e)
        {
            var viewStock = new ViewStockForm();
            viewStock.Show();
        }

        private void viewStockPanel_Click(object sender, EventArgs e)
        {
            var viewStock = new ViewStockAvail();
            viewStock.Show();
        }

        private void cusPanel_Click(object sender, EventArgs e)
        {
            var viewCus = new ViewCustomerForm();
            viewCus.Show();
        }

        private void SupplierPanel_Click(object sender, EventArgs e)
        {
            var viewSup = new ViewSupplierForm();
            viewSup.Show();
        }

        private void DebitInfoPnael_Click(object sender, EventArgs e)
        {
            var debitInfo = new DebitInfoForm();
            debitInfo.Show();
        }

        private void creditInfoPanel_Click(object sender, EventArgs e)
        {
            var creditInfo = new CreditInfoForm();
            creditInfo.Show();
        }

        private void reportPanel_Click(object sender, EventArgs e)
        {
            var report = new AllReportForm();
            report.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

    }
}
