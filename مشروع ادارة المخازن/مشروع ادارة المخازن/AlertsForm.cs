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
            dgvAlerts.Columns.Add("ID", "الكود");
            dgvAlerts.Columns.Add("Name", "اسم الصنف");
            dgvAlerts.Columns.Add("Qty", "الكمية");
            dgvAlerts.Columns.Add("Min", "الحد الأدنى");
            dgvAlerts.Columns.Add("Status", "الحالة");

            var list = DatabaseManager.GetLowStockProducts();
            lblLowStockCount.Text = list.Count.ToString();

            foreach (var p in list)
            {
                dgvAlerts.Rows.Add(p.Product_ID, p.Product_Name, p.Quantity,
                    p.Minimum_Limit, p.Quantity == 0 ? "نافد" : "منخفض");
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
