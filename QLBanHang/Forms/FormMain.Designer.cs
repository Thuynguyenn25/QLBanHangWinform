namespace QLBanHang
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tblMain = new Sunny.UI.UITableLayoutPanel();
            pnlHeader = new Sunny.UI.UIPanel();
            msMenu = new MenuStrip();
            tsmiSystem = new ToolStripMenuItem();
            tsmiExit = new ToolStripMenuItem();
            tsmiCatgr = new ToolStripMenuItem();
            tsmiProduct = new ToolStripMenuItem();
            tsmiCategory = new ToolStripMenuItem();
            tsmiBusiness = new ToolStripMenuItem();
            tsmiSale = new ToolStripMenuItem();
            tsmiReport = new ToolStripMenuItem();
            pnlFooter = new Sunny.UI.UIPanel();
            ssStatus = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            statusTime = new ToolStripStatusLabel();
            pnlContent = new Sunny.UI.UIPanel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            uiBarChartWeek = new Sunny.UI.UIBarChart();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiPanel5 = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            lblProductEx = new Sunny.UI.UILabel();
            uiPanel4 = new Sunny.UI.UIPanel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            lblSub = new Sunny.UI.UILabel();
            lblOrderCount = new Sunny.UI.UILabel();
            lblRevenueToday = new Sunny.UI.UILabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            qLSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            qLLoạiSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            nghiệpVụToolStripMenuItem = new ToolStripMenuItem();
            bánHàngToolStripMenuItem = new ToolStripMenuItem();
            tmrTimeFt = new System.Windows.Forms.Timer(components);
            tblMain.SuspendLayout();
            pnlHeader.SuspendLayout();
            msMenu.SuspendLayout();
            pnlFooter.SuspendLayout();
            ssStatus.SuspendLayout();
            pnlContent.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiTableLayoutPanel2.SuspendLayout();
            uiPanel5.SuspendLayout();
            uiPanel4.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(pnlHeader, 0, 0);
            tblMain.Controls.Add(pnlFooter, 0, 2);
            tblMain.Controls.Add(pnlContent, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 35);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.Size = new Size(1025, 518);
            tblMain.TabIndex = 0;
            tblMain.TagString = null;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(msMenu);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.FillColor = SystemColors.ActiveCaption;
            pnlHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.MinimumSize = new Size(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1025, 65);
            pnlHeader.TabIndex = 3;
            pnlHeader.Text = null;
            pnlHeader.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // msMenu
            // 
            msMenu.BackColor = SystemColors.GradientInactiveCaption;
            msMenu.Dock = DockStyle.Fill;
            msMenu.ImageScalingSize = new Size(20, 20);
            msMenu.Items.AddRange(new ToolStripItem[] { tsmiSystem, tsmiCatgr, tsmiBusiness });
            msMenu.Location = new Point(0, 0);
            msMenu.Name = "msMenu";
            msMenu.RightToLeft = RightToLeft.No;
            msMenu.Size = new Size(1025, 65);
            msMenu.TabIndex = 0;
            msMenu.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            tsmiSystem.BackColor = SystemColors.GradientInactiveCaption;
            tsmiSystem.DropDownItems.AddRange(new ToolStripItem[] { tsmiExit });
            tsmiSystem.Font = new Font("Segoe UI", 10F);
            tsmiSystem.Name = "tsmiSystem";
            tsmiSystem.Padding = new Padding(10, 4, 10, 4);
            tsmiSystem.Size = new Size(106, 61);
            tsmiSystem.Text = "Hệ thống";
            // 
            // tsmiExit
            // 
            tsmiExit.Name = "tsmiExit";
            tsmiExit.Size = new Size(224, 28);
            tsmiExit.Text = "Thoát";
            tsmiExit.Click += tsmiExit_Click;
            // 
            // tsmiCatgr
            // 
            tsmiCatgr.DropDownItems.AddRange(new ToolStripItem[] { tsmiProduct, tsmiCategory });
            tsmiCatgr.Font = new Font("Segoe UI", 10F);
            tsmiCatgr.Name = "tsmiCatgr";
            tsmiCatgr.Padding = new Padding(10, 4, 10, 4);
            tsmiCatgr.Size = new Size(113, 61);
            tsmiCatgr.Text = "Danh mục";
            // 
            // tsmiProduct
            // 
            tsmiProduct.Name = "tsmiProduct";
            tsmiProduct.Size = new Size(227, 28);
            tsmiProduct.Text = "QL Sản Phẩm";
            tsmiProduct.Click += tsmiProduct_Click;
            // 
            // tsmiCategory
            // 
            tsmiCategory.Name = "tsmiCategory";
            tsmiCategory.Size = new Size(227, 28);
            tsmiCategory.Text = "QL loại sản phẩm";
            tsmiCategory.Click += tsmiCategory_Click;
            // 
            // tsmiBusiness
            // 
            tsmiBusiness.DropDownItems.AddRange(new ToolStripItem[] { tsmiSale, tsmiReport });
            tsmiBusiness.Font = new Font("Segoe UI", 10F);
            tsmiBusiness.Name = "tsmiBusiness";
            tsmiBusiness.Padding = new Padding(10, 4, 10, 4);
            tsmiBusiness.Size = new Size(113, 61);
            tsmiBusiness.Text = "Nghiệp vụ";
            tsmiBusiness.TextDirection = ToolStripTextDirection.Horizontal;
            // 
            // tsmiSale
            // 
            tsmiSale.Name = "tsmiSale";
            tsmiSale.Size = new Size(233, 28);
            tsmiSale.Text = "Bán hàng";
            tsmiSale.Click += tsmiSale_Click;
            // 
            // tsmiReport
            // 
            tsmiReport.Name = "tsmiReport";
            tsmiReport.Size = new Size(233, 28);
            tsmiReport.Text = "Báo cáo/Thống kê";
            tsmiReport.Click += tsmiReport_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(ssStatus);
            pnlFooter.Dock = DockStyle.Fill;
            pnlFooter.FillColor = SystemColors.ActiveCaption;
            pnlFooter.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlFooter.Location = new Point(0, 468);
            pnlFooter.Margin = new Padding(0);
            pnlFooter.MinimumSize = new Size(1, 1);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1025, 50);
            pnlFooter.TabIndex = 2;
            pnlFooter.Text = null;
            pnlFooter.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ssStatus
            // 
            ssStatus.BackColor = SystemColors.InactiveBorder;
            ssStatus.Dock = DockStyle.Fill;
            ssStatus.ImageScalingSize = new Size(20, 20);
            ssStatus.Items.AddRange(new ToolStripItem[] { lblStatus, statusTime });
            ssStatus.Location = new Point(0, 0);
            ssStatus.Name = "ssStatus";
            ssStatus.Size = new Size(1025, 50);
            ssStatus.TabIndex = 1;
            ssStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Margin = new Padding(2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(501, 46);
            lblStatus.Spring = true;
            lblStatus.Text = "Trạng thái: ";
            // 
            // statusTime
            // 
            statusTime.Font = new Font("Segoe UI", 10F);
            statusTime.Margin = new Padding(2);
            statusTime.Name = "statusTime";
            statusTime.Size = new Size(501, 46);
            statusTime.Spring = true;
            statusTime.Text = "//";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(uiTableLayoutPanel1);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.FillColor = SystemColors.GradientInactiveCaption;
            pnlContent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlContent.Location = new Point(0, 65);
            pnlContent.Margin = new Padding(0);
            pnlContent.MinimumSize = new Size(1, 1);
            pnlContent.Name = "pnlContent";
            pnlContent.RectColor = SystemColors.ControlDarkDark;
            pnlContent.RectDisableColor = Color.Silver;
            pnlContent.Size = new Size(1025, 403);
            pnlContent.TabIndex = 1;
            pnlContent.Text = null;
            pnlContent.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Controls.Add(uiPanel3, 0, 2);
            uiTableLayoutPanel1.Controls.Add(uiPanel2, 0, 1);
            uiTableLayoutPanel1.Controls.Add(uiPanel1, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Margin = new Padding(5);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 3;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 57F));
            uiTableLayoutPanel1.Size = new Size(1025, 403);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(uiBarChartWeek);
            uiPanel3.Dock = DockStyle.Fill;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel3.Location = new Point(0, 172);
            uiPanel3.Margin = new Padding(0);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.RectColor = SystemColors.AppWorkspace;
            uiPanel3.RectSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            uiPanel3.Size = new Size(1025, 231);
            uiPanel3.TabIndex = 2;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiBarChartWeek
            // 
            uiBarChartWeek.Dock = DockStyle.Fill;
            uiBarChartWeek.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiBarChartWeek.LegendFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiBarChartWeek.Location = new Point(0, 0);
            uiBarChartWeek.MinimumSize = new Size(1, 1);
            uiBarChartWeek.Name = "uiBarChartWeek";
            uiBarChartWeek.Size = new Size(1025, 231);
            uiBarChartWeek.SubFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiBarChartWeek.TabIndex = 0;
            uiBarChartWeek.Text = "uiBarChart1";
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiTableLayoutPanel2);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel2.Location = new Point(0, 52);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel2.RectSides = ToolStripStatusLabelBorderSides.Top;
            uiPanel2.Size = new Size(1025, 120);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.ColumnCount = 2;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel2.Controls.Add(uiPanel5, 1, 0);
            uiTableLayoutPanel2.Controls.Add(uiPanel4, 0, 0);
            uiTableLayoutPanel2.Dock = DockStyle.Fill;
            uiTableLayoutPanel2.Location = new Point(0, 0);
            uiTableLayoutPanel2.Margin = new Padding(0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 1;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel2.Size = new Size(1025, 120);
            uiTableLayoutPanel2.TabIndex = 0;
            uiTableLayoutPanel2.TagString = null;
            // 
            // uiPanel5
            // 
            uiPanel5.Controls.Add(uiLabel1);
            uiPanel5.Controls.Add(lblProductEx);
            uiPanel5.Dock = DockStyle.Fill;
            uiPanel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel5.Location = new Point(512, 0);
            uiPanel5.Margin = new Padding(0);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel5.RectSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            uiPanel5.Size = new Size(513, 120);
            uiPanel5.TabIndex = 4;
            uiPanel5.Text = null;
            uiPanel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(16, 11);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(206, 35);
            uiLabel1.TabIndex = 4;
            uiLabel1.Text = "Sản phẩm sắp hết hàng:";
            // 
            // lblProductEx
            // 
            lblProductEx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblProductEx.ForeColor = Color.FromArgb(192, 0, 0);
            lblProductEx.Location = new Point(232, 10);
            lblProductEx.Name = "lblProductEx";
            lblProductEx.Size = new Size(254, 35);
            lblProductEx.TabIndex = 3;
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(uiLabel3);
            uiPanel4.Controls.Add(uiLabel2);
            uiPanel4.Controls.Add(lblSub);
            uiPanel4.Controls.Add(lblOrderCount);
            uiPanel4.Controls.Add(lblRevenueToday);
            uiPanel4.Dock = DockStyle.Fill;
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel4.Location = new Point(0, 0);
            uiPanel4.Margin = new Padding(0);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel4.RectSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            uiPanel4.Size = new Size(512, 120);
            uiPanel4.TabIndex = 3;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(18, 79);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(145, 35);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "Số đơn hôm nay:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(18, 9);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(189, 35);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "Doanh thu hôm nay:";
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblSub.ForeColor = SystemColors.Highlight;
            lblSub.Location = new Point(76, 44);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(324, 28);
            lblSub.TabIndex = 2;
            lblSub.Text = "So với ngày hôm qua: ";
            // 
            // lblOrderCount
            // 
            lblOrderCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblOrderCount.ForeColor = Color.FromArgb(48, 48, 48);
            lblOrderCount.Location = new Point(169, 80);
            lblOrderCount.Name = "lblOrderCount";
            lblOrderCount.Size = new Size(165, 35);
            lblOrderCount.TabIndex = 1;
            // 
            // lblRevenueToday
            // 
            lblRevenueToday.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblRevenueToday.ForeColor = Color.FromArgb(48, 48, 48);
            lblRevenueToday.Location = new Point(214, 10);
            lblRevenueToday.Name = "lblRevenueToday";
            lblRevenueToday.Size = new Size(202, 35);
            lblRevenueToday.TabIndex = 0;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(lblTitle);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(0);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = SystemColors.AppWorkspace;
            uiPanel1.Size = new Size(1025, 52);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1025, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÍ BÁN HÀNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(149, 30);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { qLSảnPhẩmToolStripMenuItem, qLLoạiSảnPhẩmToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(210, 30);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // qLSảnPhẩmToolStripMenuItem
            // 
            qLSảnPhẩmToolStripMenuItem.Name = "qLSảnPhẩmToolStripMenuItem";
            qLSảnPhẩmToolStripMenuItem.Size = new Size(207, 26);
            qLSảnPhẩmToolStripMenuItem.Text = "QL sản phẩm";
            // 
            // qLLoạiSảnPhẩmToolStripMenuItem
            // 
            qLLoạiSảnPhẩmToolStripMenuItem.Name = "qLLoạiSảnPhẩmToolStripMenuItem";
            qLLoạiSảnPhẩmToolStripMenuItem.Size = new Size(207, 26);
            qLLoạiSảnPhẩmToolStripMenuItem.Text = "QL loại sản phẩm";
            // 
            // nghiệpVụToolStripMenuItem
            // 
            nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bánHàngToolStripMenuItem });
            nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            nghiệpVụToolStripMenuItem.Size = new Size(210, 30);
            nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // bánHàngToolStripMenuItem
            // 
            bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            bánHàngToolStripMenuItem.Size = new Size(154, 26);
            bánHàngToolStripMenuItem.Text = "Bán hàng";
            // 
            // tmrTimeFt
            // 
            tmrTimeFt.Enabled = true;
            tmrTimeFt.Interval = 1000;
            tmrTimeFt.Tick += tmrTimeFt_Tick;
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1025, 553);
            Controls.Add(tblMain);
            IsMdiContainer = true;
            MainMenuStrip = msMenu;
            MinimumSize = new Size(800, 500);
            Name = "FrmMain";
            Text = "Quản lí bán hàng mini";
            ZoomScaleRect = new Rectangle(19, 19, 1025, 553);
            Load += FrmMain_Load_1;
            tblMain.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            msMenu.ResumeLayout(false);
            msMenu.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ssStatus.ResumeLayout(false);
            ssStatus.PerformLayout();
            pnlContent.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiTableLayoutPanel2.ResumeLayout(false);
            uiPanel5.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel tblMain;
        private Sunny.UI.UIPanel pnlFooter;
        private Sunny.UI.UIPanel pnlContent;
        private ToolStripMenuItem tsmiSystem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem qLSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem qLLoạiSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private ToolStripMenuItem bánHàngToolStripMenuItem;
        private StatusStrip ssStatus;
        private ToolStripStatusLabel lblStatus;
        private Sunny.UI.UIPanel pnlHeader;
        private MenuStrip msMenu;
        private ToolStripMenuItem tsmiCatgr;
        private ToolStripMenuItem tsmiBusiness;
        private ToolStripMenuItem tsmiExit;
        private ToolStripMenuItem tsmiProduct;
        private ToolStripMenuItem tsmiCategory;
        private ToolStripMenuItem tsmiSale;
        private ToolStripStatusLabel statusTime;
        private System.Windows.Forms.Timer tmrTimeFt;
        private ToolStripMenuItem tsmiReport;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UILabel lblOrderCount;
        private Sunny.UI.UILabel lblRevenueToday;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UILabel lblProductEx;
        private Sunny.UI.UILabel lblSub;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIBarChart uiBarChartWeek;
    }
}
