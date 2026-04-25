using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class LoginForm
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
            pnlMain = new Panel();
            lblAdminHint = new Label();
            grpRegister = new GroupBox();
            chkShowRegisterPassword = new CheckBox();
            btnCreateAccount = new Button();
            txtRegisterConfirmPassword = new TextBox();
            lblRegisterConfirmPassword = new Label();
            txtRegisterPassword = new TextBox();
            lblRegisterPassword = new Label();
            txtRegisterUsername = new TextBox();
            lblRegisterUsername = new Label();
            txtRegisterFullName = new TextBox();
            lblRegisterFullName = new Label();
            grpLogin = new GroupBox();
            chkShowLoginPassword = new CheckBox();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            lblLoginPassword = new Label();
            txtLoginUsername = new TextBox();
            lblLoginUsername = new Label();
            lblTitle = new Label();
            pnlMain.SuspendLayout();
            grpRegister.SuspendLayout();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(18, 18, 30);
            pnlMain.Controls.Add(lblAdminHint);
            pnlMain.Controls.Add(grpRegister);
            pnlMain.Controls.Add(grpLogin);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1064, 661);
            pnlMain.TabIndex = 0;
            // 
            // lblAdminHint
            // 
            lblAdminHint.ForeColor = Color.Gainsboro;
            lblAdminHint.Location = new Point(171, 58);
            lblAdminHint.Name = "lblAdminHint";
            lblAdminHint.Size = new Size(720, 32);
            lblAdminHint.TabIndex = 4;
            lblAdminHint.Text = "يمكنك تسجيل الدخول بحساب مدير أو إنشاء حساب جديد.";
            lblAdminHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpRegister
            // 
            grpRegister.Controls.Add(chkShowRegisterPassword);
            grpRegister.Controls.Add(btnCreateAccount);
            grpRegister.Controls.Add(txtRegisterConfirmPassword);
            grpRegister.Controls.Add(lblRegisterConfirmPassword);
            grpRegister.Controls.Add(txtRegisterPassword);
            grpRegister.Controls.Add(lblRegisterPassword);
            grpRegister.Controls.Add(txtRegisterUsername);
            grpRegister.Controls.Add(lblRegisterUsername);
            grpRegister.Controls.Add(txtRegisterFullName);
            grpRegister.Controls.Add(lblRegisterFullName);
            grpRegister.ForeColor = Color.White;
            grpRegister.Location = new Point(52, 121);
            grpRegister.Name = "grpRegister";
            grpRegister.Size = new Size(462, 490);
            grpRegister.TabIndex = 3;
            grpRegister.TabStop = false;
            grpRegister.Text = "إنشاء حساب مدير";
            grpRegister.Enter += grpRegister_Enter;
            // 
            // chkShowRegisterPassword
            // 
            chkShowRegisterPassword.AutoSize = true;
            chkShowRegisterPassword.Font = new Font("Tahoma", 10.8F);
            chkShowRegisterPassword.Location = new Point(264, 368);
            chkShowRegisterPassword.Name = "chkShowRegisterPassword";
            chkShowRegisterPassword.Size = new Size(139, 22);
            chkShowRegisterPassword.TabIndex = 8;
            chkShowRegisterPassword.Text = "إظهار كلمات المرور";
            chkShowRegisterPassword.UseVisualStyleBackColor = true;
            chkShowRegisterPassword.CheckedChanged += chkShowRegisterPassword_CheckedChanged;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(32, 178, 170);
            btnCreateAccount.FlatStyle = FlatStyle.Popup;
            btnCreateAccount.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(34, 414);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(382, 46);
            btnCreateAccount.TabIndex = 9;
            btnCreateAccount.Text = "إنشاء الحساب";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // txtRegisterConfirmPassword
            // 
            txtRegisterConfirmPassword.BackColor = Color.FromArgb(30, 30, 47);
            txtRegisterConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterConfirmPassword.ForeColor = Color.White;
            txtRegisterConfirmPassword.Location = new Point(34, 320);
            txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            txtRegisterConfirmPassword.Size = new Size(382, 34);
            txtRegisterConfirmPassword.TabIndex = 7;
            txtRegisterConfirmPassword.UseSystemPasswordChar = true;
            txtRegisterConfirmPassword.KeyDown += txtRegisterConfirmPassword_KeyDown;
            // 
            // lblRegisterConfirmPassword
            // 
            lblRegisterConfirmPassword.AutoSize = true;
            lblRegisterConfirmPassword.Location = new Point(269, 284);
            lblRegisterConfirmPassword.Name = "lblRegisterConfirmPassword";
            lblRegisterConfirmPassword.Size = new Size(188, 27);
            lblRegisterConfirmPassword.TabIndex = 6;
            lblRegisterConfirmPassword.Text = "تأكيد كلمة المرور";
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.BackColor = Color.FromArgb(30, 30, 47);
            txtRegisterPassword.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterPassword.ForeColor = Color.White;
            txtRegisterPassword.Location = new Point(34, 237);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(382, 34);
            txtRegisterPassword.TabIndex = 5;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Location = new Point(324, 201);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(132, 27);
            lblRegisterPassword.TabIndex = 4;
            lblRegisterPassword.Text = "كلمة المرور";
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.BackColor = Color.FromArgb(30, 30, 47);
            txtRegisterUsername.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterUsername.ForeColor = Color.White;
            txtRegisterUsername.Location = new Point(34, 154);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(382, 34);
            txtRegisterUsername.TabIndex = 3;
            // 
            // lblRegisterUsername
            // 
            lblRegisterUsername.AutoSize = true;
            lblRegisterUsername.Location = new Point(283, 118);
            lblRegisterUsername.Name = "lblRegisterUsername";
            lblRegisterUsername.Size = new Size(174, 27);
            lblRegisterUsername.TabIndex = 2;
            lblRegisterUsername.Text = "اسم المستخدم";
            // 
            // txtRegisterFullName
            // 
            txtRegisterFullName.BackColor = Color.FromArgb(30, 30, 47);
            txtRegisterFullName.BorderStyle = BorderStyle.FixedSingle;
            txtRegisterFullName.ForeColor = Color.White;
            txtRegisterFullName.Location = new Point(34, 72);
            txtRegisterFullName.Name = "txtRegisterFullName";
            txtRegisterFullName.Size = new Size(382, 34);
            txtRegisterFullName.TabIndex = 1;
            // 
            // lblRegisterFullName
            // 
            lblRegisterFullName.AutoSize = true;
            lblRegisterFullName.Location = new Point(330, 42);
            lblRegisterFullName.Name = "lblRegisterFullName";
            lblRegisterFullName.Size = new Size(127, 27);
            lblRegisterFullName.TabIndex = 0;
            lblRegisterFullName.Text = "اسم المدير";
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(chkShowLoginPassword);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtLoginPassword);
            grpLogin.Controls.Add(lblLoginPassword);
            grpLogin.Controls.Add(txtLoginUsername);
            grpLogin.Controls.Add(lblLoginUsername);
            grpLogin.ForeColor = Color.White;
            grpLogin.Location = new Point(550, 149);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(462, 462);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            grpLogin.Text = "تسجيل دخول المدير";
            // 
            // chkShowLoginPassword
            // 
            chkShowLoginPassword.AutoSize = true;
            chkShowLoginPassword.Font = new Font("Tahoma", 10.8F);
            chkShowLoginPassword.Location = new Point(281, 210);
            chkShowLoginPassword.Name = "chkShowLoginPassword";
            chkShowLoginPassword.Size = new Size(132, 22);
            chkShowLoginPassword.TabIndex = 4;
            chkShowLoginPassword.Text = "إظهار كلمة المرور";
            chkShowLoginPassword.UseVisualStyleBackColor = true;
            chkShowLoginPassword.CheckedChanged += chkShowLoginPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(99, 102, 241);
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(381, 47);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.BackColor = Color.FromArgb(30, 30, 47);
            txtLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPassword.ForeColor = Color.White;
            txtLoginPassword.Location = new Point(40, 159);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(381, 34);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.UseSystemPasswordChar = true;
            txtLoginPassword.KeyDown += txtLoginPassword_KeyDown;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Location = new Point(323, 123);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(132, 27);
            lblLoginPassword.TabIndex = 2;
            lblLoginPassword.Text = "كلمة المرور";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.BackColor = Color.FromArgb(30, 30, 47);
            txtLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtLoginUsername.ForeColor = Color.White;
            txtLoginUsername.Location = new Point(40, 77);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(381, 34);
            txtLoginUsername.TabIndex = 1;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Location = new Point(281, 41);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(174, 27);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "اسم المستخدم";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Tahoma", 22.2F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(219, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(627, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "تسجيل الدخول إلى نظام إدارة المخزن";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(1064, 661);
            Controls.Add(pnlMain);
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            pnlMain.ResumeLayout(false);
            grpRegister.ResumeLayout(false);
            grpRegister.PerformLayout();
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private Label lblTitle;
        private GroupBox grpLogin;
        private TextBox txtLoginUsername;
        private Label lblLoginUsername;
        private TextBox txtLoginPassword;
        private Label lblLoginPassword;
        private Button btnLogin;
        private CheckBox chkShowLoginPassword;
        private GroupBox grpRegister;
        private TextBox txtRegisterFullName;
        private Label lblRegisterFullName;
        private TextBox txtRegisterUsername;
        private Label lblRegisterUsername;
        private TextBox txtRegisterPassword;
        private Label lblRegisterPassword;
        private TextBox txtRegisterConfirmPassword;
        private Label lblRegisterConfirmPassword;
        private Button btnCreateAccount;
        private CheckBox chkShowRegisterPassword;
        private Label lblAdminHint;
    }
}
