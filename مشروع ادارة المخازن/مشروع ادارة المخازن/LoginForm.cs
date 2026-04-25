using InventoryManagement.Data;
using InventoryManagement.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class LoginForm : Form
    {
        public AdminUser? LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            RefreshAdminHint();
        }

        private void RefreshAdminHint()
        {
            bool hasAdmins = DatabaseManager.HasAnyAdminUsers();
            lblAdminHint.Text = hasAdmins
                ? "يمكنك تسجيل الدخول بحساب مدير أو إنشاء حساب مدير جديد."
                : "لا يوجد أي حساب مدير حتى الآن. أنشئ أول حساب للبدء.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text.Trim();
            string password = txtLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("يرجى إدخال اسم المستخدم وكلمة المرور.", "تسجيل الدخول",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = DatabaseManager.ValidateAdminLogin(username, password);
            if (user == null)
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.", "تسجيل الدخول",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoggedInUser = user;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string fullName = txtRegisterFullName.Text.Trim();
            string username = txtRegisterUsername.Text.Trim();
            string password = txtRegisterPassword.Text;
            string confirmPassword = txtRegisterConfirmPassword.Text;

            if (new[] { fullName, username, password, confirmPassword }.Any(string.IsNullOrWhiteSpace))
            {
                MessageBox.Show("يرجى تعبئة جميع بيانات إنشاء الحساب.", "إنشاء حساب مدير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Contains(' '))
            {
                MessageBox.Show("اسم المستخدم يجب أن يكون بدون مسافات.", "إنشاء حساب مدير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("يجب أن تتكون كلمة المرور من 6 أحرف على الأقل.", "إنشاء حساب مدير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                MessageBox.Show("كلمتا المرور غير متطابقتين.", "إنشاء حساب مدير",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DatabaseManager.RegisterAdmin(fullName, username, password, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "إنشاء حساب مدير",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("تم إنشاء حساب المدير بنجاح. يمكنك تسجيل الدخول الآن.", "إنشاء حساب مدير",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtLoginUsername.Text = username;
            txtLoginPassword.Clear();
            txtRegisterFullName.Clear();
            txtRegisterUsername.Clear();
            txtRegisterPassword.Clear();
            txtRegisterConfirmPassword.Clear();
            txtLoginPassword.Focus();
            RefreshAdminHint();
        }

        private void chkShowLoginPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLoginPassword.UseSystemPasswordChar = !chkShowLoginPassword.Checked;
        }

        private void chkShowRegisterPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool showPassword = chkShowRegisterPassword.Checked;
            txtRegisterPassword.UseSystemPasswordChar = !showPassword;
            txtRegisterConfirmPassword.UseSystemPasswordChar = !showPassword;
        }

        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtRegisterConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreateAccount_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void grpRegister_Enter(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
