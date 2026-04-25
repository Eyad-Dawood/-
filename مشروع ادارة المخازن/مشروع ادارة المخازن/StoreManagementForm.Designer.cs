using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class StoreManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnProductGrid = new Panel();
            dgvProducts = new DataGridView();
            pnProductEditor = new Panel();
            btnDeleteProduct = new Button();
            btnClearFields = new Button();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtMinLimit = new TextBox();
            lblMinLimit = new Label();
            txtProductName = new TextBox();
            lblProductName = new Label();
            txtProductQuantity = new TextBox();
            lblProductQuantity = new Label();
            txtProductId = new TextBox();
            lblProductId = new Label();
            txtSearch = new TextBox();
            lblTitle = new Label();
            pnProductGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnProductEditor.SuspendLayout();
            SuspendLayout();
            // 
            // pnProductGrid
            // 
            pnProductGrid.BackColor = Color.FromArgb(30, 30, 47);
            pnProductGrid.Controls.Add(dgvProducts);
            pnProductGrid.Location = new Point(319, 149);
            pnProductGrid.Name = "pnProductGrid";
            pnProductGrid.Size = new Size(772, 477);
            pnProductGrid.TabIndex = 0;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.FromArgb(18, 18, 30);
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 47);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.GridColor = Color.FromArgb(50, 50, 70);
            dgvProducts.Location = new Point(0, 0);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(772, 477);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // pnProductEditor
            // 
            pnProductEditor.BackColor = Color.FromArgb(30, 30, 47);
            pnProductEditor.Controls.Add(btnDeleteProduct);
            pnProductEditor.Controls.Add(btnClearFields);
            pnProductEditor.Controls.Add(btnAddProduct);
            pnProductEditor.Controls.Add(btnUpdateProduct);
            pnProductEditor.Controls.Add(txtPrice);
            pnProductEditor.Controls.Add(lblPrice);
            pnProductEditor.Controls.Add(txtMinLimit);
            pnProductEditor.Controls.Add(lblMinLimit);
            pnProductEditor.Controls.Add(txtProductName);
            pnProductEditor.Controls.Add(lblProductName);
            pnProductEditor.Controls.Add(txtProductQuantity);
            pnProductEditor.Controls.Add(lblProductQuantity);
            pnProductEditor.Controls.Add(txtProductId);
            pnProductEditor.Controls.Add(lblProductId);
            pnProductEditor.Location = new Point(40, 105);
            pnProductEditor.Name = "pnProductEditor";
            pnProductEditor.Size = new Size(254, 539);
            pnProductEditor.TabIndex = 1;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.BackColor = Color.FromArgb(192, 64, 0);
            btnDeleteProduct.FlatStyle = FlatStyle.Popup;
            btnDeleteProduct.Font = new Font("Tahoma", 13.8F);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(19, 438);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(227, 40);
            btnDeleteProduct.TabIndex = 8;
            btnDeleteProduct.Text = "حذف 🗑️";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.BackColor = Color.FromArgb(30, 30, 47);
            btnClearFields.FlatStyle = FlatStyle.Popup;
            btnClearFields.Font = new Font("Tahoma", 13.8F);
            btnClearFields.ForeColor = Color.White;
            btnClearFields.Location = new Point(19, 485);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(227, 40);
            btnClearFields.TabIndex = 9;
            btnClearFields.Text = "مسح الحقول ♻️";
            btnClearFields.UseVisualStyleBackColor = false;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.FromArgb(0, 192, 0);
            btnAddProduct.FlatStyle = FlatStyle.Popup;
            btnAddProduct.Font = new Font("Tahoma", 12F);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(19, 344);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(227, 40);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "إضافة سلعة ➕";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = Color.FromArgb(99, 102, 241);
            btnUpdateProduct.FlatStyle = FlatStyle.Popup;
            btnUpdateProduct.Font = new Font("Tahoma", 13.8F);
            btnUpdateProduct.ForeColor = Color.White;
            btnUpdateProduct.Location = new Point(19, 391);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(227, 41);
            btnUpdateProduct.TabIndex = 7;
            btnUpdateProduct.Text = "تعديل ✏️";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.FromArgb(30, 30, 47);
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Tahoma", 10.2F);
            txtPrice.ForeColor = Color.FromArgb(137, 137, 163);
            txtPrice.Location = new Point(11, 267);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(243, 24);
            txtPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblPrice.ForeColor = Color.CornflowerBlue;
            lblPrice.Location = new Point(101, 237);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 0;
            lblPrice.Text = "السعر";
            // 
            // txtMinLimit
            // 
            txtMinLimit.BackColor = Color.FromArgb(30, 30, 47);
            txtMinLimit.BorderStyle = BorderStyle.FixedSingle;
            txtMinLimit.Font = new Font("Tahoma", 10.2F);
            txtMinLimit.ForeColor = Color.FromArgb(137, 137, 163);
            txtMinLimit.Location = new Point(8, 203);
            txtMinLimit.Name = "txtMinLimit";
            txtMinLimit.Size = new Size(243, 24);
            txtMinLimit.TabIndex = 4;
            // 
            // lblMinLimit
            // 
            lblMinLimit.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblMinLimit.ForeColor = Color.CornflowerBlue;
            lblMinLimit.Location = new Point(98, 179);
            lblMinLimit.Name = "lblMinLimit";
            lblMinLimit.Size = new Size(100, 23);
            lblMinLimit.TabIndex = 0;
            lblMinLimit.Text = "الحد الأدنى";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.FromArgb(30, 30, 47);
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Tahoma", 10.2F);
            txtProductName.ForeColor = Color.FromArgb(137, 137, 163);
            txtProductName.Location = new Point(7, 85);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(243, 24);
            txtProductName.TabIndex = 2;
            // 
            // lblProductName
            // 
            lblProductName.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblProductName.ForeColor = Color.CornflowerBlue;
            lblProductName.Location = new Point(98, 61);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "اسم السلعة";
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.BackColor = Color.FromArgb(30, 30, 47);
            txtProductQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtProductQuantity.Font = new Font("Tahoma", 10.2F);
            txtProductQuantity.ForeColor = Color.FromArgb(137, 137, 163);
            txtProductQuantity.Location = new Point(8, 145);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(243, 24);
            txtProductQuantity.TabIndex = 3;
            // 
            // lblProductQuantity
            // 
            lblProductQuantity.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblProductQuantity.ForeColor = Color.CornflowerBlue;
            lblProductQuantity.Location = new Point(98, 122);
            lblProductQuantity.Name = "lblProductQuantity";
            lblProductQuantity.Size = new Size(100, 23);
            lblProductQuantity.TabIndex = 0;
            lblProductQuantity.Text = "الكمية";
            // 
            // txtProductId
            // 
            txtProductId.BackColor = Color.FromArgb(30, 30, 47);
            txtProductId.BorderStyle = BorderStyle.FixedSingle;
            txtProductId.Font = new Font("Tahoma", 10.2F);
            txtProductId.ForeColor = Color.FromArgb(137, 137, 163);
            txtProductId.Location = new Point(7, 27);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(243, 24);
            txtProductId.TabIndex = 1;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            lblProductId.ForeColor = Color.CornflowerBlue;
            lblProductId.Location = new Point(90, 4);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(133, 14);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "كود السلعة / الباركود";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 30, 47);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Tahoma", 12F);
            txtSearch.ForeColor = Color.FromArgb(137, 137, 163);
            txtSearch.Location = new Point(346, 100);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ابحث بالاسم او الكود ....";
            txtSearch.Size = new Size(365, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(935, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(156, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "إدارة المخزن 🏪";
            // 
            // StoreManagementForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(1103, 649);
            Controls.Add(lblTitle);
            Controls.Add(txtSearch);
            Controls.Add(pnProductEditor);
            Controls.Add(pnProductGrid);
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "StoreManagementForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "إدارة المخزن";
            pnProductGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnProductEditor.ResumeLayout(false);
            pnProductEditor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnProductGrid;
        private DataGridView dgvProducts;
        private Panel pnProductEditor;
        private Button btnDeleteProduct;
        private Button btnClearFields;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtMinLimit;
        private Label lblMinLimit;
        private TextBox txtProductName;
        private Label lblProductName;
        private TextBox txtProductQuantity;
        private Label lblProductQuantity;
        private TextBox txtProductId;
        private Label lblProductId;
        private TextBox txtSearch;
        private Label lblTitle;
    }
}
