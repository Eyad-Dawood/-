using InventoryManagement.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        private readonly AdminUser _currentUser;
        public bool LogoutRequested { get; private set; }

        public Form1() : this(new AdminUser
        {
            FullName = "مدير النظام",
            Username = "admin"
        })
        {
        }

        public Form1(AdminUser currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            lblWelcome.Text = $"أهلاً بك يا {_currentUser.FullName} في نظام إدارة المخزن";
            lblCurrentAdmin.Text = $"المدير الحالي: {_currentUser.FullName}";
            lblCurrentAdminUser.Text = $"اسم المستخدم: {_currentUser.Username}";
        }

        private void btnStoreManagement_Click(object sender, EventArgs e)
        {
            using var form = new StoreManagementForm();
            form.ShowDialog(this);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            using var form = new CashierForm();
            form.ShowDialog(this);
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            using var form = new AlertsForm();
            form.ShowDialog(this);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using var form = new ReportsForm();
            form.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد تسجيل الخروج والعودة إلى شاشة الدخول؟", "تسجيل الخروج",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            LogoutRequested = true;
            Close();
        }
    }
}
