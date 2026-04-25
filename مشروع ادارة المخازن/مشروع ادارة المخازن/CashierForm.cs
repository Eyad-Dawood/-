using InventoryManagement.Data;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class CashierForm : Form
    {
        private readonly List<SaleItem> _cart = new List<SaleItem>();

        public CashierForm()
        {
            InitializeComponent();
            RefreshCart();
            txtBarcode.Focus();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string code = txtBarcode.Text.Trim();
            if (string.IsNullOrEmpty(code)) return;

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("يرجى إدخال كمية صحيحة أكبر من صفر.");
                return;
            }

            var product = DatabaseManager.GetProductById(code);
            if (product == null)
            {
                MessageBox.Show($"الصنف بالكود '{code}' غير موجود.");
                return;
            }
            if (product.Quantity < qty)
            {
                MessageBox.Show($"الكمية المتاحة فقط {product.Quantity}.");
                return;
            }

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
            txtBarcode.Clear();
            txtQuantity.Text = "1";
            txtBarcode.Focus();
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnAddToCart_Click(sender, e); e.SuppressKeyPress = true; }
        }

        private void RefreshCart()
        {
            dgvCart.Rows.Clear();
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("ID", "الكود");
            dgvCart.Columns.Add("Name", "اسم الصنف");
            dgvCart.Columns.Add("Price", "سعر الوحدة");
            dgvCart.Columns.Add("Qty", "الكمية");
            dgvCart.Columns.Add("Total", "الإجمالي");

            foreach (var item in _cart)
                dgvCart.Rows.Add(item.Product_ID, item.Product_Name,
                    item.UnitPrice.ToString("F2") + " ج.م", item.Quantity,
                    item.Total.ToString("F2") + " ج.م");

            lblTotal.Text = $"إجمالي الفاتورة: {_cart.Sum(i => i.Total):F2} ج.م";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0) return;
            string id = dgvCart.SelectedRows[0].Cells["ID"].Value?.ToString();
            _cart.RemoveAll(i => i.Product_ID == id);
            RefreshCart();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCart();
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("سلة المبيعات فارغة.");
                return;
            }

            decimal total = _cart.Sum(i => i.Total);
            if (MessageBox.Show($"إجمالي الفاتورة: {total:F2} ج.م\nهل تريد تأكيد البيع؟",
                "تأكيد البيع", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            if (DatabaseManager.SaveSale(_cart, total))
            {
                var lowStock = DatabaseManager.GetLowStockProducts();
                if (lowStock.Count > 0)
                {
                    string names = string.Join("\n", lowStock.ConvertAll(p => $"- {p.Product_Name} (الكمية: {p.Quantity})"));
                    MessageBox.Show($"تنبيه: توجد أصناف منخفضة المخزون:\n\n{names}", "تنبيه المخزون", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                _cart.Clear();
                RefreshCart();
                MessageBox.Show("تم حفظ عملية البيع بنجاح.");
            }
            else MessageBox.Show("تعذر حفظ عملية البيع.");
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
