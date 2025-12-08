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
            pnlFooter = new Sunny.UI.UIPanel();
            ssStatus = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            statusTime = new ToolStripStatusLabel();
            pnlContent = new Sunny.UI.UIPanel();
            lblHintFM = new Sunny.UI.UILabel();
            lblTitleFM = new Sunny.UI.UILabel();
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
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.Size = new Size(1057, 518);
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
            pnlHeader.Size = new Size(1057, 65);
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
            msMenu.Size = new Size(1057, 65);
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
            tsmiExit.Size = new Size(138, 28);
            tsmiExit.Text = "Thoát";
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
            tsmiBusiness.DropDownItems.AddRange(new ToolStripItem[] { tsmiSale });
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
            tsmiSale.Size = new Size(224, 28);
            tsmiSale.Text = "Bán hàng";
            tsmiSale.Click += tsmiSale_Click;
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
            pnlFooter.Size = new Size(1057, 50);
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
            ssStatus.Size = new Size(1057, 50);
            ssStatus.TabIndex = 1;
            ssStatus.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.Margin = new Padding(2);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(517, 46);
            lblStatus.Spring = true;
            lblStatus.Text = "Trạng thái: ";
            // 
            // statusTime
            // 
            statusTime.Font = new Font("Segoe UI", 10F);
            statusTime.Margin = new Padding(2);
            statusTime.Name = "statusTime";
            statusTime.Size = new Size(517, 46);
            statusTime.Spring = true;
            statusTime.Text = "//";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(lblHintFM);
            pnlContent.Controls.Add(lblTitleFM);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.FillColor = SystemColors.GradientActiveCaption;
            pnlContent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlContent.Location = new Point(0, 65);
            pnlContent.Margin = new Padding(0);
            pnlContent.MinimumSize = new Size(1, 1);
            pnlContent.Name = "pnlContent";
            pnlContent.RectColor = SystemColors.ActiveCaption;
            pnlContent.Size = new Size(1057, 403);
            pnlContent.TabIndex = 1;
            pnlContent.Text = null;
            pnlContent.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblHintFM
            // 
            lblHintFM.Anchor = AnchorStyles.None;
            lblHintFM.BackColor = SystemColors.GradientActiveCaption;
            lblHintFM.Font = new Font("Segoe UI", 9F);
            lblHintFM.ForeColor = Color.FromArgb(48, 48, 48);
            lblHintFM.Location = new Point(337, 85);
            lblHintFM.Name = "lblHintFM";
            lblHintFM.Size = new Size(350, 70);
            lblHintFM.TabIndex = 1;
            lblHintFM.Text = "Vui lòng chọn chức năng ở thanh menu phía trên";
            lblHintFM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleFM
            // 
            lblTitleFM.Anchor = AnchorStyles.None;
            lblTitleFM.BackColor = SystemColors.GradientActiveCaption;
            lblTitleFM.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTitleFM.ForeColor = Color.FromArgb(48, 48, 48);
            lblTitleFM.Location = new Point(365, 5);
            lblTitleFM.Name = "lblTitleFM";
            lblTitleFM.Size = new Size(284, 80);
            lblTitleFM.TabIndex = 0;
            lblTitleFM.Text = "QUẢN LÝ BÁN HÀNG MINI";
            lblTitleFM.TextAlign = ContentAlignment.MiddleCenter;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 518);
            Controls.Add(tblMain);
            IsMdiContainer = true;
            MainMenuStrip = msMenu;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí bán hàng";
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
        private Sunny.UI.UILabel lblTitleFM;
        private System.Windows.Forms.Timer tmrTimeFt;
        private Sunny.UI.UILabel lblHintFM;
    }
}
