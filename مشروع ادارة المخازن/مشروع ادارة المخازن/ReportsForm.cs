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
            dgvReport.DataSource = dt;
            decimal total = 0;
            if (dt.Columns.Contains("????????"))
                foreach (System.Data.DataRow row in dt.Rows)
                    if (decimal.TryParse(row["????????"].ToString(), out decimal v)) total += v;
            lblSummary.Text = $"?????? ??????: {total:F2} ?  |  ??? ????????: {dt.Rows.Count}";
        }

        private void lblSummary_Click(object sender, EventArgs e)
        {

        }
    }
}
