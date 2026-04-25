using InventoryManagement.Data;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.InitializeDatabase();
        }

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            using var form = new StoreManagementForm();
            form.ShowDialog(this);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            using var form = new CashierForm();
            form.ShowDialog(this);
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            using var form = new AlertsForm();
            form.ShowDialog(this);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using var form = new ReportsForm();
            form.ShowDialog(this);
        }
    }
}