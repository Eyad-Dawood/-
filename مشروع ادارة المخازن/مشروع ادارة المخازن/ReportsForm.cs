using InventoryManagement.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            DataTable dt = DatabaseManager.GetSalesReport(dtpFrom.Value, dtpTo.Value);
            dgvReports.DataSource = dt;
            decimal total = 0;
            if (dt.Columns.Contains("الإجمالي"))
                foreach (System.Data.DataRow row in dt.Rows)
                    if (decimal.TryParse(row["الإجمالي"].ToString(), out decimal v)) total += v;
            lblSummary.Text = $"إجمالي المبيعات: {total:F2} ج.م  |  عدد العمليات: {dt.Rows.Count}";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
