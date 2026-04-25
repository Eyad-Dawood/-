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
            pnReport = new Panel();
            lblSummary = new Label();
            lblTo = new Label();
            lblFrom = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            btnShowReport = new Button();
            dgvReport = new DataGridView();
            lblTitle = new Label();
            pnReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // pnReport
            // 
            pnReport.BackColor = Color.FromArgb(30, 30, 47);
            pnReport.Controls.Add(lblSummary);
            pnReport.Controls.Add(dgvReport);
            pnReport.Location = new Point(32, 101);
            pnReport.Name = "pnReport";
            pnReport.Size = new Size(868, 541);
            pnReport.TabIndex = 0;
            // 
            // lblSummary
            // 
            lblSummary.ForeColor = Color.FromArgb(0, 192, 0);
            lblSummary.Location = new Point(318, 479);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(507, 34);
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
            btnShowReport.Location = new Point(795, 65);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new Size(102, 30);
            btnShowReport.TabIndex = 3;
            btnShowReport.Text = "عرض التقرير";
            btnShowReport.UseVisualStyleBackColor = false;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.BackgroundColor = Color.FromArgb(30, 30, 47);
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Dock = DockStyle.Fill;
            dgvReport.Location = new Point(0, 0);
            dgvReport.Name = "dgvReport";
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(868, 541);
            dgvReport.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Tahoma", 22.2F);
            lblTitle.ForeColor = Color.Cyan;
            lblTitle.Location = new Point(599, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 36);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "📊 تقارير المبيعات";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 18, 30);
            ClientSize = new Size(910, 649);
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
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
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
        private DataGridView dgvReport;
        private Button btnShowReport;
        private Label lblTitle;
    }
}
