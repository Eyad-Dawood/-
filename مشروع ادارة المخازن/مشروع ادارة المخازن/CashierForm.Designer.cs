using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class CashierForm
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
            btnAddToCart = new Button();
            txtBarcode = new TextBox();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            lblBarcode = new Label();
            pnCart = new Panel();
            dgvCart = new DataGridView();
            btnClearCart = new Button();
            btnRemoveItem = new Button();
            btnConfirmSale = new Button();
            lblTotal = new Label();
            pnLowStockInfo = new Panel();
            lblLowStockTitle = new Label();
            pnLowStockList = new Panel();
            lblLowStockItems = new Label();
            lblTitle = new Label();
            pnCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            pnLowStockInfo.SuspendLayout();
            pnLowStockList.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.FromArgb(99, 102, 241);
            btnAddToCart.FlatStyle = FlatStyle.Popup;
            btnAddToCart.Font = new Font("Tahoma", 12F);
            btnAddToCart.ForeColor = Color.White;
            btnAddToCart.Location = new Point(29, 111);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(128, 39);
            btnAddToCart.TabIndex = 0;
            btnAddToCart.Text = "➕ إضافة";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = Color.FromArgb(30, 30, 47);
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Font = new Font("Tahoma", 12F);
            txtBarcode.ForeColor = Color.Cornsilk;
            txtBarcode.Location = new Point(457, 116);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(183, 27);
            txtBarcode.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.BackColor = Color.FromArgb(30, 30, 47);
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Font = new Font("Tahoma", 12F);
            txtQuantity.ForeColor = Color.White;
            txtQuantity.Location = new Point(241, 118);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(51, 27);
            txtQuantity.TabIndex = 1;
            txtQuantity.Text = "1";
            txtQuantity.TextAlign = HorizontalAlignment.Center;
            txtQuantity.KeyDown += txtQuantity_KeyDown;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.FromArgb(18, 18, 30);
            lblQuantity.Font = new Font("Tahoma", 12F);
            lblQuantity.ForeColor = Color.White;
            lblQuantity.Location = new Point(167, 120);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(68, 19);
            lblQuantity.TabIndex = 0;
            lblQuantity.Text = "الكمية : ";
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.BackColor = Color.FromArgb(18, 18, 30);
            lblBarcode.Font = new Font("Tahoma", 12F);
            lblBarcode.ForeColor = Color.White;
            lblBarcode.Location = new Point(326, 120);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(128, 19);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "باركود/كود السلعة";
            // 
            // pnCart
            // 
            pnCart.Controls.Add(dgvCart);
            pnCart.Location = new Point(21, 159);
            pnCart.Name = "pnCart";
            pnCart.Size = new Size(891, 455);
            pnCart.TabIndex = 3;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeColumns = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.FromArgb(18, 18, 30);
            dgvCart.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 47);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.GridColor = Color.FromArgb(50, 50, 70);
            dgvCart.Location = new Point(0, 0);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(891, 455);
            dgvCart.TabIndex = 0;
            dgvCart.CellContentClick += dgvCart_CellContentClick;
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.FromArgb(40, 40, 60);
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Tahoma", 13.8F);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(412, 629);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(201, 43);
            btnClearCart.TabIndex = 3;
            btnClearCart.Text = "مسح ♻️";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BackColor = Color.Red;
            btnRemoveItem.FlatStyle = FlatStyle.Popup;
            btnRemoveItem.Font = new Font("Tahoma", 13.8F);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(221, 629);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(185, 43);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "حذف الصنف 🗑️ ";
            btnRemoveItem.UseVisualStyleBackColor = false;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnConfirmSale
            // 
            btnConfirmSale.BackColor = Color.FromArgb(0, 192, 0);
            btnConfirmSale.FlatStyle = FlatStyle.Popup;
            btnConfirmSale.Font = new Font("Tahoma", 13.8F);
            btnConfirmSale.ForeColor = Color.White;
            btnConfirmSale.Location = new Point(21, 629);
            btnConfirmSale.Name = "btnConfirmSale";
            btnConfirmSale.Size = new Size(194, 43);
            btnConfirmSale.TabIndex = 4;
            btnConfirmSale.Text = "تأكيد البيع ✅";
            btnConfirmSale.UseVisualStyleBackColor = false;
            btnConfirmSale.Click += btnConfirmSale_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotal.Location = new Point(619, 635);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(183, 27);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "الاجمالي 0.00 ج";
            // 
            // pnLowStockInfo
            // 
            pnLowStockInfo.BackColor = Color.FromArgb(30, 30, 47);
            pnLowStockInfo.Controls.Add(lblLowStockTitle);
            pnLowStockInfo.Location = new Point(935, 93);
            pnLowStockInfo.Name = "pnLowStockInfo";
            pnLowStockInfo.Size = new Size(214, 583);
            pnLowStockInfo.TabIndex = 4;
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Tahoma", 10.8F);
            lblLowStockTitle.ForeColor = Color.Gold;
            lblLowStockTitle.Location = new Point(39, 14);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(136, 18);
            lblLowStockTitle.TabIndex = 0;
            lblLowStockTitle.Text = "سلع تحتاج تجديد 🔔";
            // 
            // pnLowStockList
            // 
            pnLowStockList.BackColor = Color.FromArgb(40, 40, 60);
            pnLowStockList.Controls.Add(lblLowStockItems);
            pnLowStockList.Location = new Point(949, 135);
            pnLowStockList.Name = "pnLowStockList";
            pnLowStockList.Size = new Size(188, 527);
            pnLowStockList.TabIndex = 5;
            // 
            // lblLowStockItems
            // 
            lblLowStockItems.ForeColor = Color.Lime;
            lblLowStockItems.Location = new Point(15, 7);
            lblLowStockItems.Name = "lblLowStockItems";
            lblLowStockItems.Size = new Size(168, 22);
            lblLowStockItems.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(985, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 27);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "\U0001f9fe الكاشير";
            // 
            // CashierForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(1167, 688);
            Controls.Add(btnClearCart);
            Controls.Add(lblTitle);
            Controls.Add(btnRemoveItem);
            Controls.Add(pnLowStockList);
            Controls.Add(btnConfirmSale);
            Controls.Add(lblTotal);
            Controls.Add(pnLowStockInfo);
            Controls.Add(pnCart);
            Controls.Add(lblBarcode);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(txtBarcode);
            Controls.Add(btnAddToCart);
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "CashierForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "الكاشير";
            pnCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            pnLowStockInfo.ResumeLayout(false);
            pnLowStockInfo.PerformLayout();
            pnLowStockList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddToCart;
        private TextBox txtBarcode;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private Label lblBarcode;
        private Panel pnCart;
        private Button btnClearCart;
        private Button btnRemoveItem;
        private Button btnConfirmSale;
        private Label lblTotal;
        private DataGridView dgvCart;
        private Panel pnLowStockInfo;
        private Label lblLowStockTitle;
        private Panel pnLowStockList;
        private Label lblLowStockItems;
        private Label lblTitle;
    }
}
