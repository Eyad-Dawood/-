using مشروع_ادارة_المخازن.Data;
using مشروع_ادارة_المخازن.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace مشروع_ادارة_المخازن
{
    public partial class Form1 : Form
    {
        private List<SaleItem> _cart = new List<SaleItem>();

        public Form1()
        {
            InitializeComponent();
            DatabaseManager.InitializeDatabase();
            LoadProducts();
            RefreshAlerts();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        // ══════════════════════════════════════════
        // 📦 المخزن
        // textBox1=كود | textBox2=الكمية | textBox3=الاسم | textBox4=الحد الأدنى | textBox5=السعر
        // ══════════════════════════════════════════

        private void LoadProducts(string search = "")
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "الكود");
            dataGridView1.Columns.Add("Name", "الاسم");
            dataGridView1.Columns.Add("Qty", "الكمية");
            dataGridView1.Columns.Add("Min", "الحد الأدنى");
            dataGridView1.Columns.Add("Price", "السعر");
            dataGridView1.Columns.Add("Status", "الحالة");

            foreach (var p in DatabaseManager.GetAllProducts())
            {
                if (!string.IsNullOrEmpty(search) &&
                    !p.Product_Name.Contains(search) &&
                    !p.Product_ID.Contains(search)) continue;

                dataGridView1.Rows.Add(
                    p.Product_ID, p.Product_Name, p.Quantity,
                    p.Minimum_Limit, p.Price.ToString("F2") + " ج",
                    p.IsLowStock ? "⚠️ منخفض" : "✅ كافي");

                if (p.IsLowStock)
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1]
                        .DefaultCellStyle.BackColor = Color.FromArgb(60, 30, 30);
            }
        }

        private void button3_Click(object sender, EventArgs e) // ➕ إضافة
        {
            if (!ValidateStockFields(out Product p)) return;
            if (DatabaseManager.GetProductById(p.Product_ID) != null)
            { MessageBox.Show("الكود ده موجود بالفعل!"); return; }
            if (DatabaseManager.AddProduct(p))
            { MessageBox.Show("✅ تمت الإضافة!"); ClearStockFields(); LoadProducts(); RefreshAlerts(); }
            else MessageBox.Show("❌ فيه مشكلة.");
        }

        private void button2_Click(object sender, EventArgs e) // ✏️ تعديل
        {
            if (!ValidateStockFields(out Product p)) return;
            if (DatabaseManager.UpdateProduct(p))
            { MessageBox.Show("✅ تم التعديل!"); ClearStockFields(); LoadProducts(); RefreshAlerts(); }
            else MessageBox.Show("❌ فيه مشكلة.");
        }

        private void button4_Click(object sender, EventArgs e) // 🗑️ حذف
        {
            if (string.IsNullOrEmpty(textBox1.Text)) { MessageBox.Show("اختار سلعة الأول!"); return; }
            if (MessageBox.Show("متأكد؟", "تأكيد", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { DatabaseManager.DeleteProduct(textBox1.Text); ClearStockFields(); LoadProducts(); RefreshAlerts(); }
        }

        private void button1_Click(object sender, EventArgs e) // ♻️ مسح
        {
            ClearStockFields();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var row = dataGridView1.SelectedRows[0];
            textBox1.Text = row.Cells["ID"].Value?.ToString();      // كود
            textBox3.Text = row.Cells["Name"].Value?.ToString();    // اسم ← textBox3
            textBox2.Text = row.Cells["Qty"].Value?.ToString();     // كمية ← textBox2
            textBox4.Text = row.Cells["Min"].Value?.ToString();     // حد أدنى
            textBox5.Text = row.Cells["Price"].Value?.ToString().Replace(" ج", ""); // سعر
            textBox1.ReadOnly = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(textBox6.Text);
        }

        private bool ValidateStockFields(out Product p)
        {
            p = null;
            // textBox1=كود, textBox3=اسم
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            { MessageBox.Show("الكود والاسم مطلوبين!"); return false; }
            // textBox2=كمية, textBox4=حد أدنى, textBox5=سعر
            if (!int.TryParse(textBox2.Text, out int qty) ||
                !int.TryParse(textBox4.Text, out int min) ||
                !decimal.TryParse(textBox5.Text, out decimal price))
            { MessageBox.Show("الكمية والحد الأدنى والسعر لازم أرقام!"); return false; }
            p = new Product
            {
                Product_ID = textBox1.Text.Trim(),
                Product_Name = textBox3.Text.Trim(),
                Quantity = qty,
                Minimum_Limit = min,
                Price = price
            };
            return true;
        }

        private void ClearStockFields()
        {
            textBox1.Text = textBox2.Text = textBox3.Text =
            textBox4.Text = textBox5.Text = "";
            textBox1.ReadOnly = false;
            dataGridView1.ClearSelection();
        }

        // ══════════════════════════════════════════
        // 🧾 الكاشير
        // textBox7=الكمية (صغير) | textBox8=الباركود (كبير)
        // ══════════════════════════════════════════

        private void button5_Click(object sender, EventArgs e) // ➕ إضافة للفاتورة
        {
            string code = textBox8.Text.Trim(); // textBox8 = الباركود الكبير
            if (string.IsNullOrEmpty(code)) return;

            if (!int.TryParse(textBox7.Text, out int qty) || qty <= 0) // textBox7 = الكمية
            { MessageBox.Show("الكمية لازم رقم أكبر من صفر!"); return; }

            var product = DatabaseManager.GetProductById(code);
            if (product == null) { MessageBox.Show($"❌ السلعة '{code}' مش موجودة!"); return; }
            if (product.Quantity < qty) { MessageBox.Show($"⚠️ الكمية المتاحة {product.Quantity} بس!"); return; }

            var existing = _cart.Find(i => i.Product_ID == product.Product_ID);
            if (existing != null) existing.Quantity += qty;
            else _cart.Add(new SaleItem
            {
                Product_ID = product.Product_ID,
                Product_Name = product.Product_Name,
                Quantity = qty,
                UnitPrice = product.Price
            });

            RefreshCart();
            textBox8.Clear(); textBox7.Text = "1"; textBox8.Focus();
        }

        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { button5_Click(sender, e); e.SuppressKeyPress = true; }
        }

        private void RefreshCart()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("ID", "الكود");
            dataGridView2.Columns.Add("Name", "الاسم");
            dataGridView2.Columns.Add("Price", "السعر");
            dataGridView2.Columns.Add("Qty", "الكمية");
            dataGridView2.Columns.Add("Total", "الإجمالي");

            foreach (var item in _cart)
                dataGridView2.Rows.Add(item.Product_ID, item.Product_Name,
                    item.UnitPrice.ToString("F2") + " ج", item.Quantity,
                    item.Total.ToString("F2") + " ج");

            label13.Text = $"الإجمالي: {_cart.Sum(i => i.Total):F2} ج";
        }

        private void button7_Click(object sender, EventArgs e) // 🗑️ حذف صنف
        {
            if (dataGridView2.SelectedRows.Count == 0) return;
            string id = dataGridView2.SelectedRows[0].Cells["ID"].Value?.ToString();
            _cart.RemoveAll(i => i.Product_ID == id);
            RefreshCart();
        }

        private void button8_Click(object sender, EventArgs e) // ♻️ مسح الفاتورة
        {
            _cart.Clear(); RefreshCart();
        }

        private void button6_Click(object sender, EventArgs e) // ✅ تأكيد البيع
        {
            if (_cart.Count == 0) { MessageBox.Show("الفاتورة فاضية!"); return; }
            decimal total = _cart.Sum(i => i.Total);
            if (MessageBox.Show($"الإجمالي: {total:F2} ج\nتأكيد البيع؟",
                "تأكيد", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            if (DatabaseManager.SaveSale(_cart, total))
            {
                var lowStock = DatabaseManager.GetLowStockProducts();
                if (lowStock.Count > 0)
                {
                    string names = string.Join("\n", lowStock.ConvertAll(p => $"• {p.Product_Name} (متبقي: {p.Quantity})"));
                    MessageBox.Show($"⚠️ سلع وصلت للحد الأدنى:\n\n{names}", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                _cart.Clear(); RefreshCart(); RefreshAlerts();
                MessageBox.Show("✅ تمت عملية البيع!");
            }
            else MessageBox.Show("❌ فيه مشكلة في الحفظ.");
        }

        // ══════════════════════════════════════════
        // 🔔 التنبيهات
        // ══════════════════════════════════════════

        private void RefreshAlerts()
        {
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.Columns.Add("ID", "الكود");
            dataGridView3.Columns.Add("Name", "السلعة");
            dataGridView3.Columns.Add("Qty", "الكمية");
            dataGridView3.Columns.Add("Min", "الحد الأدنى");
            dataGridView3.Columns.Add("Status", "الحالة");

            var list = DatabaseManager.GetLowStockProducts();
            label15.Text = list.Count.ToString(); // ← تحديث العداد

            foreach (var p in list)
            {
                dataGridView3.Rows.Add(p.Product_ID, p.Product_Name, p.Quantity,
                    p.Minimum_Limit, p.Quantity == 0 ? "🚨 نفذت" : "⚠️ منخفضة");
                dataGridView3.Rows[dataGridView3.Rows.Count - 1]
                    .DefaultCellStyle.BackColor = Color.FromArgb(60, 30, 30);
            }
        }

        private void button9_Click(object sender, EventArgs e) // 🔄 تحديث التنبيهات
        {
            RefreshAlerts();
        }

        // ══════════════════════════════════════════
        // 📊 التقارير
        // ══════════════════════════════════════════

        private void button10_Click(object sender, EventArgs e) // 🔍 عرض
        {
            var dt = DatabaseManager.GetSalesReport(dateTimePicker1.Value, dateTimePicker2.Value);
            dataGridView4.DataSource = dt;
            decimal total = 0;
            if (dt.Columns.Contains("الإجمالي"))
                foreach (System.Data.DataRow row in dt.Rows)
                    if (decimal.TryParse(row["الإجمالي"].ToString(), out decimal v)) total += v;
            label20.Text = $"إجمالي الفترة: {total:F2} ج  |  عدد العمليات: {dt.Rows.Count}";
        

        }

        // ══════════════════════════════════════════
        // 🧭 التنقل — Click مش CheckedChanged
        // ══════════════════════════════════════════

        private void radioButton1_Click(object sender, EventArgs e)
        {
            panalStoreManagment.Visible = true;
            panelAlerts.Visible = false;
            panelcasher.Visible = false;
            panelReports.Visible = false;
            panelWelcome.Visible = false;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            panalStoreManagment.Visible = false;
            panelAlerts.Visible = false;
            panelcasher.Visible = true;
            panelReports.Visible = false;
            panelWelcome.Visible = false;
            textBox8.Focus();
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            panalStoreManagment.Visible = false;
            panelAlerts.Visible = true;
            panelcasher.Visible = false;
            panelReports.Visible = false;
            panelWelcome.Visible = false;
            RefreshAlerts();
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            panalStoreManagment.Visible = false;
            panelAlerts.Visible = false;
            panelcasher.Visible = false;
            panelReports.Visible = true;
            panelWelcome.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e) {
        }
        private void label14_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }
    }
}