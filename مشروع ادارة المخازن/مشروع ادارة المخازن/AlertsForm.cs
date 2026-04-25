using InventoryManagement.Data;

namespace InventoryManagement
{
    public partial class AlertsForm : Form
    {
        public AlertsForm()
        {
            InitializeComponent();
            RefreshAlerts();
        }

        private void RefreshAlerts()
        {
            dgvAlerts.Rows.Clear();
            dgvAlerts.Columns.Clear();
            dgvAlerts.Columns.Add("ID", "?????");
            dgvAlerts.Columns.Add("Name", "??????");
            dgvAlerts.Columns.Add("Qty", "??????");
            dgvAlerts.Columns.Add("Min", "???? ??????");
            dgvAlerts.Columns.Add("Status", "??????");

            var list = DatabaseManager.GetLowStockProducts();
            lblLowStockCount.Text = list.Count.ToString();

            foreach (var p in list)
            {
                dgvAlerts.Rows.Add(p.Product_ID, p.Product_Name, p.Quantity,
                    p.Minimum_Limit, p.Quantity == 0 ? "?? ????" : "?? ??????");
                dgvAlerts.Rows[dgvAlerts.Rows.Count - 1]
                    .DefaultCellStyle.BackColor = Color.FromArgb(60, 30, 30);
            }
        }

        private void btnRefreshAlerts_Click(object sender, EventArgs e)
        {
            RefreshAlerts();
        }

    }
}
