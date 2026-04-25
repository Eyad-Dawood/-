using InventoryManagement.Data;
using InventoryManagement.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class StoreManagementForm : Form
    {
        public StoreManagementForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts(string search = "")
        {
            dgvProducts.Rows.Clear();
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add("ID", "الكود");
            dgvProducts.Columns.Add("Name", "الاسم");
            dgvProducts.Columns.Add("Qty", "الكمية");
            dgvProducts.Columns.Add("Min", "الحد الأدنى");
            dgvProducts.Columns.Add("Price", "السعر");
            dgvProducts.Columns.Add("Status", "الحالة");

            foreach (var p in DatabaseManager.GetAllProducts())
            {
                if (!string.IsNullOrEmpty(search) &&
                    !p.Product_Name.Contains(search) &&
                    !p.Product_ID.Contains(search)) continue;

                dgvProducts.Rows.Add(
                    p.Product_ID, p.Product_Name, p.Quantity,
                    p.Minimum_Limit, p.Price.ToString("F2") + " ج.م",
                    p.IsLowStock ? "مخزون منخفض" : "متوفر");

                if (p.IsLowStock)
                    dgvProducts.Rows[dgvProducts.Rows.Count - 1]
                        .DefaultCellStyle.BackColor = Color.FromArgb(60, 30, 30);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateStockFields(out Product p)) return;
            if (DatabaseManager.GetProductById(p.Product_ID) != null)
            {
                MessageBox.Show("يوجد صنف بهذا الكود بالفعل.");
                return;
            }
            if (DatabaseManager.AddProduct(p))
            {
                MessageBox.Show("تمت إضافة الصنف بنجاح.");
                ClearStockFields();
                LoadProducts();
            }
            else MessageBox.Show("تعذر إضافة الصنف.");
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateStockFields(out Product p)) return;
            if (DatabaseManager.UpdateProduct(p))
            {
                MessageBox.Show("تم تحديث الصنف بنجاح.");
                ClearStockFields();
                LoadProducts();
            }
            else MessageBox.Show("تعذر تحديث الصنف.");
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("يرجى اختيار صنف للحذف.");
                return;
            }
            if (MessageBox.Show("هل أنت متأكد من حذف هذا الصنف؟", "تأكيد الحذف", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DatabaseManager.DeleteProduct(txtProductId.Text);
                ClearStockFields();
                LoadProducts();
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearStockFields();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0) return;
            var row = dgvProducts.SelectedRows[0];
            txtProductId.Text = row.Cells["ID"].Value?.ToString();
            txtProductName.Text = row.Cells["Name"].Value?.ToString();
            txtProductQuantity.Text = row.Cells["Qty"].Value?.ToString();
            txtMinLimit.Text = row.Cells["Min"].Value?.ToString();
            txtPrice.Text = row.Cells["Price"].Value?.ToString().Replace(" ج.م", "");
            txtProductId.ReadOnly = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearch.Text);
        }

        private bool ValidateStockFields(out Product p)
        {
            p = null;
            if (string.IsNullOrWhiteSpace(txtProductId.Text) || string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("يرجى إدخال الكود واسم الصنف.");
                return false;
            }
            if (!int.TryParse(txtProductQuantity.Text, out int qty) ||
                !int.TryParse(txtMinLimit.Text, out int min) ||
                !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("يرجى إدخال الكمية والحد الأدنى والسعر بصيغة صحيحة.");
                return false;
            }
            p = new Product
            {
                Product_ID = txtProductId.Text.Trim(),
                Product_Name = txtProductName.Text.Trim(),
                Quantity = qty,
                Minimum_Limit = min,
                Price = price
            };
            return true;
        }

        private void ClearStockFields()
        {
            txtProductId.Text = txtProductQuantity.Text = txtProductName.Text =
            txtMinLimit.Text = txtPrice.Text = "";
            txtProductId.ReadOnly = false;
            dgvProducts.ClearSelection();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
