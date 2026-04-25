using System.Drawing;
using System.Windows.Forms;

namespace InventoryManagement
{
    partial class ReportsForm
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
            pnReport = new Panel();
            dgvReports = new DataGridView();
            lblSummary = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            btnShowReport = new Button();
            lblTitle = new Label();
            pnReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // pnReport
            // 
            pnReport.BackColor = Color.FromArgb(30, 30, 47);
            pnReport.Controls.Add(dgvReports);
            pnReport.Location = new Point(32, 101);
            pnReport.Name = "pnReport";
            pnReport.Size = new Size(1084, 541);
            pnReport.TabIndex = 0;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeColumns = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.BackgroundColor = Color.FromArgb(18, 18, 30);
            dgvReports.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 47);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReports.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReports.Dock = DockStyle.Fill;
            dgvReports.EnableHeadersVisualStyles = false;
            dgvReports.GridColor = Color.FromArgb(50, 50, 70);
            dgvReports.Location = new Point(0, 0);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(1084, 541);
            dgvReports.TabIndex = 1;
            // 
            // lblSummary
            // 
            lblSummary.ForeColor = Color.FromArgb(0, 192, 0);
            lblSummary.Location = new Point(32, 648);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(930, 34);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "00.00 ج";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.BackColor = Color.FromArgb(18, 18, 30);
            lblTo.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblTo.ForeColor = Color.White;
            lblTo.Location = new Point(216, 70);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(62, 23);
            lblTo.TabIndex = 0;
            lblTo.Text = "إلى : ";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.BackColor = Color.FromArgb(18, 18, 30);
            lblFrom.Font = new Font("Tahoma", 13.8F, FontStyle.Bold);
            lblFrom.ForeColor = Color.White;
            lblFrom.Location = new Point(475, 71);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(56, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "من : ";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(32, 68);
            dtpTo.Name = "dtpTo";
            dtpTo.RightToLeftLayout = true;
            dtpTo.Size = new Size(170, 27);
            dtpTo.TabIndex = 2;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(292, 68);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.RightToLeftLayout = true;
            dtpFrom.Size = new Size(170, 27);
            dtpFrom.TabIndex = 1;
            // 
            // btnShowReport
            // 
            btnShowReport.BackColor = Color.Blue;
            btnShowReport.FlatStyle = FlatStyle.Popup;
            btnShowReport.Font = new Font("Tahoma", 12F);
            btnShowReport.ForeColor = Color.White;
            btnShowReport.Location = new Point(1014, 65);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(102, 30);
            btnShowReport.TabIndex = 3;
            btnShowReport.Text = "عرض التقرير";
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 22.2F);
            lblTitle.ForeColor = Color.Cyan;
            lblTitle.Location = new Point(818, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 36);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📊 تقارير المبيعات";
            lblTitle.Click += lblTitle_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(1128, 690);
            Controls.Add(lblSummary);
            Controls.Add(lblTitle);
            Controls.Add(btnShowReport);
            Controls.Add(lblTo);
            Controls.Add(pnReport);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(dtpTo);
            Font = new Font("Tahoma", 16.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(7, 6, 7, 6);
            MaximizeBox = false;
            Name = "ReportsForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "تقارير المبيعات";
            pnReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnReport;
        private Label lblSummary;
        private Label lblTo;
        private Label lblFrom;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Button btnShowReport;
        private Label lblTitle;
        private DataGridView dgvReports;
    }
}
