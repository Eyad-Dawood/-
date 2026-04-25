using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class Form1
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
            pnWelcome = new Panel();
            lblWelcome = new Label();
            pnNavigation = new Panel();
            btnReports = new Button();
            btnAlerts = new Button();
            btnCashier = new Button();
            btnStoreManagement = new Button();
            lblNavigationTitle = new Label();
            pnWelcome.SuspendLayout();
            pnNavigation.SuspendLayout();
            SuspendLayout();
            // 
            // pnWelcome
            // 
            pnWelcome.BackColor = Color.FromArgb(18, 18, 30);
            pnWelcome.Controls.Add(lblWelcome);
            pnWelcome.Location = new Point(0, 0);
            pnWelcome.Name = "pnWelcome";
            pnWelcome.Size = new Size(910, 649);
            pnWelcome.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Tahoma", 32F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(910, 649);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "🏪 أهلاً بك في نظام إدارة المخزن";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnNavigation
            // 
            pnNavigation.BackColor = Color.FromArgb(30, 30, 47);
            pnNavigation.Controls.Add(btnReports);
            pnNavigation.Controls.Add(btnAlerts);
            pnNavigation.Controls.Add(btnCashier);
            pnNavigation.Controls.Add(btnStoreManagement);
            pnNavigation.Controls.Add(lblNavigationTitle);
            pnNavigation.Location = new Point(910, -10);
            pnNavigation.Name = "pnNavigation";
            pnNavigation.Size = new Size(263, 666);
            pnNavigation.TabIndex = 1;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnReports.ForeColor = Color.FromArgb(137, 137, 163);
            btnReports.Location = new Point(9, 283);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(241, 56);
            btnReports.TabIndex = 4;
            btnReports.Text = "📊 التقارير";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAlerts
            // 
            btnAlerts.Cursor = Cursors.Hand;
            btnAlerts.FlatStyle = FlatStyle.Flat;
            btnAlerts.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnAlerts.ForeColor = Color.FromArgb(137, 137, 163);
            btnAlerts.Location = new Point(10, 221);
            btnAlerts.Name = "btnAlerts";
            btnAlerts.Size = new Size(241, 56);
            btnAlerts.TabIndex = 3;
            btnAlerts.Text = "🔔 التنبيه";
            btnAlerts.UseVisualStyleBackColor = true;
            btnAlerts.Click += btnAlerts_Click;
            // 
            // btnCashier
            // 
            btnCashier.Cursor = Cursors.Hand;
            btnCashier.FlatStyle = FlatStyle.Flat;
            btnCashier.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnCashier.ForeColor = Color.FromArgb(137, 137, 163);
            btnCashier.Location = new Point(9, 159);
            btnCashier.Name = "btnCashier";
            btnCashier.Size = new Size(241, 56);
            btnCashier.TabIndex = 2;
            btnCashier.Text = "🧾 الكاشير";
            btnCashier.UseVisualStyleBackColor = true;
            btnCashier.Click += btnCashier_Click;
            // 
            // btnStoreManagement
            // 
            btnStoreManagement.Cursor = Cursors.Hand;
            btnStoreManagement.FlatStyle = FlatStyle.Flat;
            btnStoreManagement.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnStoreManagement.ForeColor = Color.FromArgb(137, 137, 163);
            btnStoreManagement.Location = new Point(8, 97);
            btnStoreManagement.Name = "btnStoreManagement";
            btnStoreManagement.Size = new Size(241, 56);
            btnStoreManagement.TabIndex = 1;
            btnStoreManagement.Text = "🗳️ إدارة المخزن";
            btnStoreManagement.UseVisualStyleBackColor = true;
            btnStoreManagement.Click += btnStoreManagement_Click;
            // 
            // lblNavigationTitle
            // 
            lblNavigationTitle.AutoSize = true;
            lblNavigationTitle.ForeColor = Color.White;
            lblNavigationTitle.Location = new Point(51, 28);
            lblNavigationTitle.Name = "lblNavigationTitle";
            lblNavigationTitle.Size = new Size(152, 34);
            lblNavigationTitle.TabIndex = 0;
            lblNavigationTitle.Text = "🏪 المخزن";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 649);
            Controls.Add(pnNavigation);
            Controls.Add(pnWelcome);
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نظام إدارة المخزن";
            pnWelcome.ResumeLayout(false);
            pnNavigation.ResumeLayout(false);
            pnNavigation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnWelcome;
        private Label lblWelcome;
        private Panel pnNavigation;
        private Button btnReports;
        private Button btnAlerts;
        private Button btnCashier;
        private Button btnStoreManagement;
        private Label lblNavigationTitle;
    }
}