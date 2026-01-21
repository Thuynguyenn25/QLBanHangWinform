namespace QLBanHang.Forms
{
    partial class FormReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tlpMainReport = new Sunny.UI.UITableLayoutPanel();
            pnlPanel3 = new Sunny.UI.UIPanel();
            pnlPanel2 = new Sunny.UI.UIPanel();
            uiTabControl1 = new Sunny.UI.UITabControl();
            tabPage1 = new TabPage();
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiPanel4 = new Sunny.UI.UIPanel();
            lblAvgOrder = new Sunny.UI.UILabel();
            lblOrderCount = new Sunny.UI.UILabel();
            lblTotalRevenue = new Sunny.UI.UILabel();
            dgvRevenue = new Sunny.UI.UIDataGridView();
            cSTT = new DataGridViewTextBoxColumn();
            cNgay = new DataGridViewTextBoxColumn();
            cSoDon = new DataGridViewTextBoxColumn();
            cDoanhThu = new DataGridViewTextBoxColumn();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            btnViewReport = new Sunny.UI.UIButton();
            uiPanel2 = new Sunny.UI.UIPanel();
            dtpToDate = new Sunny.UI.UIDatetimePicker();
            lblToDate = new Label();
            uiPanel1 = new Sunny.UI.UIPanel();
            dtpFromDate = new Sunny.UI.UIDatetimePicker();
            lblFromDate = new Label();
            tlpMainReport.SuspendLayout();
            pnlPanel2.SuspendLayout();
            uiTabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            uiTableLayoutPanel2.SuspendLayout();
            uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            uiTableLayoutPanel1.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMainReport
            // 
            tlpMainReport.ColumnCount = 1;
            tlpMainReport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMainReport.Controls.Add(pnlPanel3, 0, 2);
            tlpMainReport.Controls.Add(pnlPanel2, 0, 1);
            tlpMainReport.Controls.Add(uiTableLayoutPanel1, 0, 0);
            tlpMainReport.Dock = DockStyle.Fill;
            tlpMainReport.Location = new Point(0, 35);
            tlpMainReport.Name = "tlpMainReport";
            tlpMainReport.RowCount = 3;
            tlpMainReport.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tlpMainReport.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpMainReport.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlpMainReport.Size = new Size(1094, 507);
            tlpMainReport.TabIndex = 0;
            tlpMainReport.TagString = null;
            // 
            // pnlPanel3
            // 
            pnlPanel3.Dock = DockStyle.Fill;
            pnlPanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel3.Location = new Point(0, 419);
            pnlPanel3.Margin = new Padding(0);
            pnlPanel3.MinimumSize = new Size(1, 1);
            pnlPanel3.Name = "pnlPanel3";
            pnlPanel3.RectColor = SystemColors.Highlight;
            pnlPanel3.Size = new Size(1094, 88);
            pnlPanel3.TabIndex = 2;
            pnlPanel3.Text = null;
            pnlPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // pnlPanel2
            // 
            pnlPanel2.Controls.Add(uiTabControl1);
            pnlPanel2.Dock = DockStyle.Fill;
            pnlPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel2.Location = new Point(0, 70);
            pnlPanel2.Margin = new Padding(0);
            pnlPanel2.MinimumSize = new Size(1, 1);
            pnlPanel2.Name = "pnlPanel2";
            pnlPanel2.RectColor = SystemColors.Highlight;
            pnlPanel2.Size = new Size(1094, 349);
            pnlPanel2.TabIndex = 1;
            pnlPanel2.Text = null;
            pnlPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.Dock = DockStyle.Fill;
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(0, 0);
            uiTabControl1.MainPage = "";
            uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(1094, 349);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabBackColor = SystemColors.GradientInactiveCaption;
            uiTabControl1.TabIndex = 0;
            uiTabControl1.TabSelectedColor = SystemColors.GradientInactiveCaption;
            uiTabControl1.TabUnSelectedColor = Color.FromArgb(80, 160, 255);
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            uiTabControl1.TipsFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiTableLayoutPanel2);
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1094, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Doanh thu";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.ColumnCount = 1;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel2.Controls.Add(uiPanel4, 0, 0);
            uiTableLayoutPanel2.Controls.Add(dgvRevenue, 0, 1);
            uiTableLayoutPanel2.Dock = DockStyle.Fill;
            uiTableLayoutPanel2.Location = new Point(0, 0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 2;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.42857F));
            uiTableLayoutPanel2.Size = new Size(1094, 309);
            uiTableLayoutPanel2.TabIndex = 0;
            uiTableLayoutPanel2.TagString = null;
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(lblAvgOrder);
            uiPanel4.Controls.Add(lblOrderCount);
            uiPanel4.Controls.Add(lblTotalRevenue);
            uiPanel4.Dock = DockStyle.Fill;
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel4.Location = new Point(0, 0);
            uiPanel4.Margin = new Padding(0);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel4.Size = new Size(1094, 88);
            uiPanel4.TabIndex = 0;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblAvgOrder
            // 
            lblAvgOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblAvgOrder.ForeColor = Color.FromArgb(48, 48, 48);
            lblAvgOrder.Location = new Point(390, 54);
            lblAvgOrder.Name = "lblAvgOrder";
            lblAvgOrder.Size = new Size(285, 29);
            lblAvgOrder.TabIndex = 2;
            lblAvgOrder.Text = "Giá trị đơn TB:";
            // 
            // lblOrderCount
            // 
            lblOrderCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblOrderCount.ForeColor = Color.FromArgb(48, 48, 48);
            lblOrderCount.Location = new Point(12, 54);
            lblOrderCount.Name = "lblOrderCount";
            lblOrderCount.Size = new Size(285, 29);
            lblOrderCount.TabIndex = 1;
            lblOrderCount.Text = "Số đơn:";
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTotalRevenue.ForeColor = Color.FromArgb(48, 48, 48);
            lblTotalRevenue.Location = new Point(12, 12);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(285, 29);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "Tổng doanh thu:";
            // 
            // dgvRevenue
            // 
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.AllowUserToDeleteRows = false;
            dgvRevenue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRevenue.BackgroundColor = Color.White;
            dgvRevenue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRevenue.ColumnHeadersHeight = 32;
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRevenue.Columns.AddRange(new DataGridViewColumn[] { cSTT, cNgay, cSoDon, cDoanhThu });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRevenue.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRevenue.Dock = DockStyle.Fill;
            dgvRevenue.EnableHeadersVisualStyles = false;
            dgvRevenue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvRevenue.GridColor = Color.FromArgb(80, 160, 255);
            dgvRevenue.Location = new Point(3, 91);
            dgvRevenue.Name = "dgvRevenue";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRevenue.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRevenue.RowHeadersVisible = false;
            dgvRevenue.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvRevenue.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRevenue.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvRevenue.SelectedIndex = -1;
            dgvRevenue.Size = new Size(1088, 215);
            dgvRevenue.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvRevenue.TabIndex = 1;
            // 
            // cSTT
            // 
            cSTT.HeaderText = "STT";
            cSTT.MinimumWidth = 6;
            cSTT.Name = "cSTT";
            cSTT.ReadOnly = true;
            cSTT.Width = 125;
            // 
            // cNgay
            // 
            cNgay.HeaderText = "Ngày ";
            cNgay.MinimumWidth = 6;
            cNgay.Name = "cNgay";
            cNgay.ReadOnly = true;
            cNgay.Width = 125;
            // 
            // cSoDon
            // 
            cSoDon.HeaderText = "Số đơn";
            cSoDon.MinimumWidth = 6;
            cSoDon.Name = "cSoDon";
            cSoDon.ReadOnly = true;
            cSoDon.Width = 125;
            // 
            // cDoanhThu
            // 
            cDoanhThu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cDoanhThu.HeaderText = "Doanh thu";
            cDoanhThu.MinimumWidth = 6;
            cDoanhThu.Name = "cDoanhThu";
            cDoanhThu.ReadOnly = true;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 3;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel1.Controls.Add(uiPanel3, 2, 0);
            uiTableLayoutPanel1.Controls.Add(uiPanel2, 1, 0);
            uiTableLayoutPanel1.Controls.Add(uiPanel1, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(3, 3);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(1088, 64);
            uiTableLayoutPanel1.TabIndex = 3;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(btnViewReport);
            uiPanel3.Dock = DockStyle.Fill;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel3.Location = new Point(724, 0);
            uiPanel3.Margin = new Padding(0);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel3.Size = new Size(364, 64);
            uiPanel3.TabIndex = 4;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnViewReport
            // 
            btnViewReport.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnViewReport.Location = new Point(103, 9);
            btnViewReport.MinimumSize = new Size(1, 1);
            btnViewReport.Name = "btnViewReport";
            btnViewReport.Size = new Size(162, 44);
            btnViewReport.TabIndex = 0;
            btnViewReport.Text = "Xem Báo cáo";
            btnViewReport.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnViewReport.Click += btnViewReport_Click;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(dtpToDate);
            uiPanel2.Controls.Add(lblToDate);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel2.Location = new Point(362, 0);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel2.Size = new Size(362, 64);
            uiPanel2.TabIndex = 3;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dtpToDate
            // 
            dtpToDate.DateCultureInfo = new System.Globalization.CultureInfo("en-US");
            dtpToDate.FillColor = Color.White;
            dtpToDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpToDate.Location = new Point(101, 14);
            dtpToDate.Margin = new Padding(4, 5, 4, 5);
            dtpToDate.MaxLength = 19;
            dtpToDate.MinimumSize = new Size(63, 0);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Padding = new Padding(0, 0, 30, 2);
            dtpToDate.Size = new Size(218, 36);
            dtpToDate.SymbolDropDown = 61555;
            dtpToDate.SymbolNormal = 61555;
            dtpToDate.SymbolSize = 24;
            dtpToDate.TabIndex = 2;
            dtpToDate.Text = "2026-01-16 15:54:03";
            dtpToDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpToDate.Value = new DateTime(2026, 1, 16, 15, 54, 3, 347);
            dtpToDate.Watermark = "";
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.BackColor = Color.FromArgb(243, 249, 255);
            lblToDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblToDate.Location = new Point(25, 22);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(79, 23);
            lblToDate.TabIndex = 1;
            lblToDate.Text = "Tới ngày:";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(dtpFromDate);
            uiPanel1.Controls.Add(lblFromDate);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(0);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel1.Size = new Size(362, 64);
            uiPanel1.TabIndex = 2;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dtpFromDate
            // 
            dtpFromDate.DateCultureInfo = new System.Globalization.CultureInfo("en-US");
            dtpFromDate.FillColor = Color.White;
            dtpFromDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpFromDate.Location = new Point(125, 14);
            dtpFromDate.Margin = new Padding(4, 5, 4, 5);
            dtpFromDate.MaxLength = 19;
            dtpFromDate.MinimumSize = new Size(63, 0);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Padding = new Padding(0, 0, 30, 2);
            dtpFromDate.Size = new Size(218, 36);
            dtpFromDate.SymbolDropDown = 61555;
            dtpFromDate.SymbolNormal = 61555;
            dtpFromDate.SymbolSize = 24;
            dtpFromDate.TabIndex = 1;
            dtpFromDate.Text = "2026-01-16 15:54:03";
            dtpFromDate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpFromDate.Value = new DateTime(2026, 1, 16, 15, 54, 3, 347);
            dtpFromDate.Watermark = "";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.BackColor = Color.FromArgb(243, 249, 255);
            lblFromDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblFromDate.Location = new Point(43, 22);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(75, 23);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "Từ ngày:";
            // 
            // FormReport
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1094, 542);
            Controls.Add(tlpMainReport);
            Name = "FormReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Báo cáo thống kê";
            ZoomScaleRect = new Rectangle(19, 19, 1094, 542);
            Load += FormReport_Load;
            tlpMainReport.ResumeLayout(false);
            pnlPanel2.ResumeLayout(false);
            uiTabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            uiTableLayoutPanel2.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            uiTableLayoutPanel1.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiPanel2.PerformLayout();
            uiPanel1.ResumeLayout(false);
            uiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel tlpMainReport;
        private Sunny.UI.UIPanel pnlPanel3;
        private Sunny.UI.UIPanel pnlPanel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIDatetimePicker dtpFromDate;
        private Label lblFromDate;
        private Label lblToDate;
        private Sunny.UI.UIButton btnViewReport;
        private Sunny.UI.UIDatetimePicker dtpToDate;
        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabPage1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UILabel lblOrderCount;
        private Sunny.UI.UILabel lblTotalRevenue;
        private Sunny.UI.UILabel lblAvgOrder;
        private Sunny.UI.UIDataGridView dgvRevenue;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cNgay;
        private DataGridViewTextBoxColumn cSoDon;
        private DataGridViewTextBoxColumn cDoanhThu;
    }
}