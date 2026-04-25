using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class AlertsForm
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
            pnAlerts = new Panel();
            lblLowStockCountTitle = new Label();
            lblLowStockCount = new Label();
            btnRefreshAlerts = new Button();
            lblTitle = new Label();
            dgvAlerts = new DataGridView();
            pnAlerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlerts).BeginInit();
            SuspendLayout();
            // 
            // pnAlerts
            // 
            pnAlerts.BackColor = Color.FromArgb(30, 30, 47);
            pnAlerts.Controls.Add(dgvAlerts);
            pnAlerts.Location = new Point(32, 71);
            pnAlerts.Name = "pnAlerts";
            pnAlerts.Size = new Size(1113, 541);
            pnAlerts.TabIndex = 0;
            // 
            // lblLowStockCountTitle
            // 
            lblLowStockCountTitle.AutoSize = true;
            lblLowStockCountTitle.Font = new Font("Tahoma", 12F);
            lblLowStockCountTitle.ForeColor = SystemColors.ControlLightLight;
            lblLowStockCountTitle.Location = new Point(32, 622);
            lblLowStockCountTitle.Name = "lblLowStockCountTitle";
            lblLowStockCountTitle.Size = new Size(160, 19);
            lblLowStockCountTitle.TabIndex = 0;
            lblLowStockCountTitle.Text = "عدد الأصناف المنخفضة";
            // 
            // lblLowStockCount
            // 
            lblLowStockCount.AutoSize = true;
            lblLowStockCount.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            lblLowStockCount.ForeColor = SystemColors.ButtonFace;
            lblLowStockCount.Location = new Point(198, 623);
            lblLowStockCount.Name = "lblLowStockCount";
            lblLowStockCount.Size = new Size(18, 18);
            lblLowStockCount.TabIndex = 1;
            lblLowStockCount.Text = "0";
            // 
            // btnRefreshAlerts
            // 
            btnRefreshAlerts.BackColor = Color.FromArgb(55, 55, 80);
            btnRefreshAlerts.FlatStyle = FlatStyle.Popup;
            btnRefreshAlerts.Font = new Font("Tahoma", 12F);
            btnRefreshAlerts.ForeColor = Color.White;
            btnRefreshAlerts.Location = new Point(1008, 618);
            btnRefreshAlerts.Name = "btnRefreshAlerts";
            btnRefreshAlerts.Size = new Size(137, 32);
            btnRefreshAlerts.TabIndex = 2;
            btnRefreshAlerts.Text = "تحديث التنبيهات";
            btnRefreshAlerts.UseVisualStyleBackColor = false;
            btnRefreshAlerts.Click += btnRefreshAlerts_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 22.2F);
            lblTitle.ForeColor = Color.Gold;
            lblTitle.Location = new Point(976, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(169, 36);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "التنبيهات 🔔";
            // 
            // dgvProducts
            // 
            dgvAlerts.AllowUserToAddRows = false;
            dgvAlerts.AllowUserToDeleteRows = false;
            dgvAlerts.AllowUserToResizeColumns = false;
            dgvAlerts.AllowUserToResizeRows = false;
            dgvAlerts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlerts.BackgroundColor = Color.FromArgb(18, 18, 30);
            dgvAlerts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 47);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAlerts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAlerts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAlerts.Dock = DockStyle.Fill;
            dgvAlerts.EnableHeadersVisualStyles = false;
            dgvAlerts.GridColor = Color.FromArgb(50, 50, 70);
            dgvAlerts.Location = new Point(0, 0);
            dgvAlerts.Name = "dgvProducts";
            dgvAlerts.RowHeadersWidth = 51;
            dgvAlerts.Size = new Size(1113, 541);
            dgvAlerts.TabIndex = 1;
            // 
            // AlertsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(1157, 656);
            Controls.Add(lblLowStockCountTitle);
            Controls.Add(lblLowStockCount);
            Controls.Add(lblTitle);
            Controls.Add(pnAlerts);
            Controls.Add(btnRefreshAlerts);
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "AlertsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "التنبيهات";
            pnAlerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlerts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnAlerts;
        private Label lblLowStockCountTitle;
        private Label lblLowStockCount;
        private Button btnRefreshAlerts;
        private Label lblTitle;
        private DataGridView dgvAlerts;
    }
}
