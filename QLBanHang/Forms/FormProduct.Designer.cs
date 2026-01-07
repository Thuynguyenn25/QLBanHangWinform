namespace QLBanHang
{
    partial class FormProduct
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
            uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            txtIDProduct = new Sunny.UI.UITextBox();
            txtName = new Sunny.UI.UITextBox();
            uiTextBox4 = new Sunny.UI.UITextBox();
            uiTextBox5 = new Sunny.UI.UITextBox();
            lblIDProdut = new Sunny.UI.UILabel();
            lblName = new Sunny.UI.UILabel();
            lblType = new Sunny.UI.UILabel();
            lblPrice = new Sunny.UI.UILabel();
            lblStock = new Sunny.UI.UILabel();
            lblDescribe = new Sunny.UI.UILabel();
            cmbType = new Sunny.UI.UIComboBox();
            rtxDescribe = new Sunny.UI.UIRichTextBox();
            uiFlowLayoutPanel1 = new Sunny.UI.UIFlowLayoutPanel();
            btnDelete = new Sunny.UI.UIButton();
            btnEdit = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiPanel3 = new Sunny.UI.UIPanel();
            uiFlowLayoutPanel2 = new Sunny.UI.UIFlowLayoutPanel();
            btnSearch = new Sunny.UI.UIButton();
            txtSearch = new Sunny.UI.UITextBox();
            (uiSplitContainer1).BeginInit();
            uiSplitContainer1.Panel1.SuspendLayout();
            uiSplitContainer1.Panel2.SuspendLayout();
            uiSplitContainer1.SuspendLayout();
            uiTableLayoutPanel2.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiTableLayoutPanel4.SuspendLayout();
            uiFlowLayoutPanel1.SuspendLayout();
            uiTableLayoutPanel3.SuspendLayout();
            uiFlowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            uiSplitContainer1.Dock = DockStyle.Fill;
            uiSplitContainer1.Location = new Point(0, 0);
            uiSplitContainer1.Margin = new Padding(0);
            uiSplitContainer1.MinimumSize = new Size(20, 20);
            uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            uiSplitContainer1.Panel1.Controls.Add(uiTableLayoutPanel2);
            // 
            // uiSplitContainer1.Panel2
            // 
            uiSplitContainer1.Panel2.BackColor = Color.White;
            uiSplitContainer1.Panel2.Controls.Add(uiPanel3);
            uiSplitContainer1.Panel2.Controls.Add(uiFlowLayoutPanel2);
            uiSplitContainer1.Size = new Size(1087, 553);
            uiSplitContainer1.SplitterDistance = 540;
            uiSplitContainer1.SplitterWidth = 11;
            uiSplitContainer1.TabIndex = 0;
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.ColumnCount = 1;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel2.Controls.Add(uiPanel1, 0, 0);
            uiTableLayoutPanel2.Dock = DockStyle.Fill;
            uiTableLayoutPanel2.Location = new Point(0, 0);
            uiTableLayoutPanel2.Margin = new Padding(0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 1;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            uiTableLayoutPanel2.Size = new Size(540, 553);
            uiTableLayoutPanel2.TabIndex = 0;
            uiTableLayoutPanel2.TagString = null;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiTableLayoutPanel4);
            uiPanel1.Controls.Add(uiTableLayoutPanel3);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(4, 5);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(532, 543);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel4
            // 
            uiTableLayoutPanel4.BackColor = Color.AliceBlue;
            uiTableLayoutPanel4.ColumnCount = 2;
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            uiTableLayoutPanel4.Controls.Add(txtIDProduct, 1, 0);
            uiTableLayoutPanel4.Controls.Add(txtName, 1, 1);
            uiTableLayoutPanel4.Controls.Add(uiTextBox4, 1, 3);
            uiTableLayoutPanel4.Controls.Add(uiTextBox5, 1, 4);
            uiTableLayoutPanel4.Controls.Add(lblIDProdut, 0, 0);
            uiTableLayoutPanel4.Controls.Add(lblName, 0, 1);
            uiTableLayoutPanel4.Controls.Add(lblType, 0, 2);
            uiTableLayoutPanel4.Controls.Add(lblPrice, 0, 3);
            uiTableLayoutPanel4.Controls.Add(lblStock, 0, 4);
            uiTableLayoutPanel4.Controls.Add(lblDescribe, 0, 5);
            uiTableLayoutPanel4.Controls.Add(cmbType, 1, 2);
            uiTableLayoutPanel4.Controls.Add(rtxDescribe, 1, 5);
            uiTableLayoutPanel4.Controls.Add(uiFlowLayoutPanel1, 1, 6);
            uiTableLayoutPanel4.Dock = DockStyle.Fill;
            uiTableLayoutPanel4.Location = new Point(0, 61);
            uiTableLayoutPanel4.Margin = new Padding(0);
            uiTableLayoutPanel4.Name = "uiTableLayoutPanel4";
            uiTableLayoutPanel4.RowCount = 7;
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5263157F));
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 31.5789471F));
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7894735F));
            uiTableLayoutPanel4.Size = new Size(532, 482);
            uiTableLayoutPanel4.TabIndex = 1;
            uiTableLayoutPanel4.TagString = null;
            uiTableLayoutPanel4.Paint += uiTableLayoutPanel4_Paint;
            // 
            // txtIDProduct
            // 
            txtIDProduct.Dock = DockStyle.Fill;
            txtIDProduct.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDProduct.Location = new Point(124, 5);
            txtIDProduct.Margin = new Padding(4, 5, 4, 5);
            txtIDProduct.MinimumSize = new Size(1, 16);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Padding = new Padding(5);
            txtIDProduct.ShowText = false;
            txtIDProduct.Size = new Size(404, 40);
            txtIDProduct.TabIndex = 0;
            txtIDProduct.TextAlignment = ContentAlignment.MiddleLeft;
            txtIDProduct.Watermark = "";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(124, 55);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MinimumSize = new Size(1, 16);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(5);
            txtName.ShowText = false;
            txtName.Size = new Size(404, 40);
            txtName.TabIndex = 1;
            txtName.TextAlignment = ContentAlignment.MiddleLeft;
            txtName.Watermark = "";
            // 
            // uiTextBox4
            // 
            uiTextBox4.Dock = DockStyle.Fill;
            uiTextBox4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox4.Location = new Point(124, 155);
            uiTextBox4.Margin = new Padding(4, 5, 4, 5);
            uiTextBox4.MinimumSize = new Size(1, 16);
            uiTextBox4.Name = "uiTextBox4";
            uiTextBox4.Padding = new Padding(5);
            uiTextBox4.ShowText = false;
            uiTextBox4.Size = new Size(404, 40);
            uiTextBox4.TabIndex = 3;
            uiTextBox4.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox4.Watermark = "";
            // 
            // uiTextBox5
            // 
            uiTextBox5.Dock = DockStyle.Fill;
            uiTextBox5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox5.Location = new Point(124, 205);
            uiTextBox5.Margin = new Padding(4, 5, 4, 5);
            uiTextBox5.MinimumSize = new Size(1, 16);
            uiTextBox5.Name = "uiTextBox5";
            uiTextBox5.Padding = new Padding(5);
            uiTextBox5.ShowText = false;
            uiTextBox5.Size = new Size(404, 40);
            uiTextBox5.TabIndex = 4;
            uiTextBox5.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox5.Watermark = "";
            // 
            // lblIDProdut
            // 
            lblIDProdut.Dock = DockStyle.Fill;
            lblIDProdut.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIDProdut.ForeColor = Color.FromArgb(48, 48, 48);
            lblIDProdut.Location = new Point(3, 0);
            lblIDProdut.Name = "lblIDProdut";
            lblIDProdut.Size = new Size(114, 50);
            lblIDProdut.TabIndex = 6;
            lblIDProdut.Text = "Mã hàng:";
            lblIDProdut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(48, 48, 48);
            lblName.Location = new Point(3, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 50);
            lblName.TabIndex = 7;
            lblName.Text = "Tên hàng:";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            lblType.Dock = DockStyle.Fill;
            lblType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblType.ForeColor = Color.FromArgb(48, 48, 48);
            lblType.Location = new Point(3, 100);
            lblType.Name = "lblType";
            lblType.Size = new Size(114, 50);
            lblType.TabIndex = 8;
            lblType.Text = "Danh mục:";
            lblType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(48, 48, 48);
            lblPrice.Location = new Point(3, 150);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 50);
            lblPrice.TabIndex = 9;
            lblPrice.Text = "Đơn giá:";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStock
            // 
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(48, 48, 48);
            lblStock.Location = new Point(3, 200);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(114, 50);
            lblStock.TabIndex = 10;
            lblStock.Text = "Stock:";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescribe
            // 
            lblDescribe.Dock = DockStyle.Fill;
            lblDescribe.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescribe.ForeColor = Color.FromArgb(48, 48, 48);
            lblDescribe.Location = new Point(3, 250);
            lblDescribe.Name = "lblDescribe";
            lblDescribe.Size = new Size(114, 152);
            lblDescribe.TabIndex = 11;
            lblDescribe.Text = "Mô tả:";
            lblDescribe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbType
            // 
            cmbType.DataSource = null;
            cmbType.Dock = DockStyle.Fill;
            cmbType.FillColor = Color.White;
            cmbType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbType.Location = new Point(124, 105);
            cmbType.Margin = new Padding(4, 5, 4, 5);
            cmbType.MinimumSize = new Size(63, 0);
            cmbType.Name = "cmbType";
            cmbType.Padding = new Padding(0, 0, 30, 2);
            cmbType.Size = new Size(404, 40);
            cmbType.SymbolSize = 24;
            cmbType.TabIndex = 12;
            cmbType.Text = "Danh mục";
            cmbType.TextAlignment = ContentAlignment.MiddleLeft;
            cmbType.Watermark = "";
            // 
            // rtxDescribe
            // 
            rtxDescribe.Dock = DockStyle.Fill;
            rtxDescribe.FillColor = Color.White;
            rtxDescribe.Font = new Font("Microsoft Sans Serif", 12F);
            rtxDescribe.Location = new Point(124, 255);
            rtxDescribe.Margin = new Padding(4, 5, 4, 5);
            rtxDescribe.MinimumSize = new Size(1, 1);
            rtxDescribe.Name = "rtxDescribe";
            rtxDescribe.Padding = new Padding(2);
            rtxDescribe.ShowText = false;
            rtxDescribe.Size = new Size(404, 142);
            rtxDescribe.TabIndex = 13;
            rtxDescribe.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiFlowLayoutPanel1
            // 
            uiFlowLayoutPanel1.Controls.Add(btnDelete);
            uiFlowLayoutPanel1.Controls.Add(btnEdit);
            uiFlowLayoutPanel1.Controls.Add(btnSave);
            uiFlowLayoutPanel1.Dock = DockStyle.Fill;
            uiFlowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiFlowLayoutPanel1.Location = new Point(124, 407);
            uiFlowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            uiFlowLayoutPanel1.MinimumSize = new Size(1, 1);
            uiFlowLayoutPanel1.Name = "uiFlowLayoutPanel1";
            uiFlowLayoutPanel1.Padding = new Padding(2);
            uiFlowLayoutPanel1.RectColor = Color.Transparent;
            uiFlowLayoutPanel1.ShowText = false;
            uiFlowLayoutPanel1.Size = new Size(404, 70);
            uiFlowLayoutPanel1.TabIndex = 14;
            uiFlowLayoutPanel1.Text = "uiFlowLayoutPanel1";
            uiFlowLayoutPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(299, 16);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 1;
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.Location = new Point(153, 16);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Left;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F);
            btnSave.Location = new Point(5, 16);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiTableLayoutPanel3
            // 
            uiTableLayoutPanel3.BackColor = Color.AliceBlue;
            uiTableLayoutPanel3.ColumnCount = 1;
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel3.Controls.Add(uiPanel2, 0, 0);
            uiTableLayoutPanel3.Dock = DockStyle.Top;
            uiTableLayoutPanel3.Location = new Point(0, 0);
            uiTableLayoutPanel3.Margin = new Padding(0);
            uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            uiTableLayoutPanel3.RowCount = 1;
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel3.Size = new Size(532, 61);
            uiTableLayoutPanel3.TabIndex = 0;
            uiTableLayoutPanel3.TagString = null;
            // 
            // uiPanel2
            // 
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 0;
            uiPanel2.RectColor = Color.Transparent;
            uiPanel2.Size = new Size(532, 61);
            uiPanel2.TabIndex = 0;
            uiPanel2.Text = "Thông tin sản phẩm";
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            uiPanel3.Dock = DockStyle.Top;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(0, 80);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(536, 65);
            uiPanel3.TabIndex = 1;
            uiPanel3.Text = "Danh mục thông tin sản phẩm";
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiFlowLayoutPanel2
            // 
            uiFlowLayoutPanel2.Controls.Add(btnSearch);
            uiFlowLayoutPanel2.Controls.Add(txtSearch);
            uiFlowLayoutPanel2.Dock = DockStyle.Top;
            uiFlowLayoutPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiFlowLayoutPanel2.Location = new Point(0, 0);
            uiFlowLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            uiFlowLayoutPanel2.MinimumSize = new Size(1, 1);
            uiFlowLayoutPanel2.Name = "uiFlowLayoutPanel2";
            uiFlowLayoutPanel2.Padding = new Padding(2);
            uiFlowLayoutPanel2.RectColor = Color.White;
            uiFlowLayoutPanel2.ShowText = false;
            uiFlowLayoutPanel2.Size = new Size(536, 80);
            uiFlowLayoutPanel2.TabIndex = 0;
            uiFlowLayoutPanel2.Text = "uiFlowLayoutPanel2";
            uiFlowLayoutPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F);
            btnSearch.Location = new Point(16, 14);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F);
            txtSearch.Location = new Point(148, 14);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(309, 40);
            txtSearch.TabIndex = 3;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 553);
            Controls.Add(uiSplitContainer1);
            MinimumSize = new Size(1000, 600);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cửa Hàng";
            uiSplitContainer1.Panel1.ResumeLayout(false);
            uiSplitContainer1.Panel2.ResumeLayout(false);
            (uiSplitContainer1).EndInit();
            uiSplitContainer1.ResumeLayout(false);
            uiTableLayoutPanel2.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiTableLayoutPanel4.ResumeLayout(false);
            uiFlowLayoutPanel1.ResumeLayout(false);
            uiTableLayoutPanel3.ResumeLayout(false);
            uiFlowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton btnAddCate;
        private Sunny.UI.UITextBox txtSearchCate;
        private Sunny.UI.UIButton btnSearchCate;
        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UITextBox txtIDProduct;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UILabel lblIDProdut;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UILabel lblType;
        private Sunny.UI.UILabel lblPrice;
        private Sunny.UI.UILabel lblStock;
        private Sunny.UI.UILabel lblDescribe;
        private Sunny.UI.UIComboBox cmbType;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIRichTextBox rtxDescribe;
        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel1;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel2;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
    }
}