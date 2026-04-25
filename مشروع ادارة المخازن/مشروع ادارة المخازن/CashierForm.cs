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
            { MessageBox.Show("?????? ???? ??? ???? ?? ???!"); return; }

            var product = DatabaseManager.GetProductById(code);
            if (product == null) { MessageBox.Show($"? ?????? '{code}' ?? ??????!"); return; }
            if (product.Quantity < qty) { MessageBox.Show($"?? ?????? ??????? {product.Quantity} ??!"); return; }

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
            dgvCart.Columns.Add("ID", "?????");
            dgvCart.Columns.Add("Name", "?????");
            dgvCart.Columns.Add("Price", "?????");
            dgvCart.Columns.Add("Qty", "??????");
            dgvCart.Columns.Add("Total", "????????");

            foreach (var item in _cart)
                dgvCart.Rows.Add(item.Product_ID, item.Product_Name,
                    item.UnitPrice.ToString("F2") + " ?", item.Quantity,
                    item.Total.ToString("F2") + " ?");

            lblTotal.Text = $"????????: {_cart.Sum(i => i.Total):F2} ?";
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
            if (_cart.Count == 0) { MessageBox.Show("???????? ?????!"); return; }
            decimal total = _cart.Sum(i => i.Total);
            if (MessageBox.Show($"????????: {total:F2} ?\n????? ??????",
                "?????", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            if (DatabaseManager.SaveSale(_cart, total))
            {
                var lowStock = DatabaseManager.GetLowStockProducts();
                if (lowStock.Count > 0)
                {
                    string names = string.Join("\n", lowStock.ConvertAll(p => $"• {p.Product_Name} (?????: {p.Quantity})"));
                    MessageBox.Show($"?? ??? ???? ???? ??????:\n\n{names}", "?????", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                _cart.Clear();
                RefreshCart();
                MessageBox.Show("? ??? ????? ?????!");
            }
            else MessageBox.Show("? ??? ????? ?? ?????.");
        }

    }
}
