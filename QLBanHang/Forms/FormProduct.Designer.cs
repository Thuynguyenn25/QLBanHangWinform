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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            txtIDProduct = new Sunny.UI.UITextBox();
            txtName = new Sunny.UI.UITextBox();
            txtPrice = new Sunny.UI.UITextBox();
            txtStock = new Sunny.UI.UITextBox();
            lblIDProdut = new Sunny.UI.UILabel();
            lblName = new Sunny.UI.UILabel();
            lblType = new Sunny.UI.UILabel();
            lblPrice = new Sunny.UI.UILabel();
            lblStock = new Sunny.UI.UILabel();
            cboCategory = new Sunny.UI.UIComboBox();
            uiFlowLayoutPanel1 = new Sunny.UI.UIFlowLayoutPanel();
            btnDelete = new Sunny.UI.UIButton();
            btnEdit = new Sunny.UI.UIButton();
            btnAdd = new Sunny.UI.UIButton();
            uiTableLayoutPanel6 = new Sunny.UI.UITableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            btnImport = new Sunny.UI.UIButton();
            uiPanel5 = new Sunny.UI.UIPanel();
            btnClear = new Sunny.UI.UIButton();
            chkIsActive = new Sunny.UI.UICheckBox();
            uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            uiPanel4 = new Sunny.UI.UIPanel();
            dgvProduct = new Sunny.UI.UIDataGridView();
            cChose = new DataGridViewCheckBoxColumn();
            cIDProduct = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cPrice = new DataGridViewTextBoxColumn();
            cStock = new DataGridViewTextBoxColumn();
            cIsActive = new DataGridViewTextBoxColumn();
            cCategoryID = new DataGridViewTextBoxColumn();
            cmsProduct = new Sunny.UI.UIContextMenuStrip();
            tsmiSelectItem = new ToolStripMenuItem();
            tsmiSelectAll = new ToolStripMenuItem();
            tsmiUnselect = new ToolStripMenuItem();
            tsmiDeleteItem = new ToolStripMenuItem();
            uiPanel3 = new Sunny.UI.UIPanel();
            txtSearch = new Sunny.UI.UITextBox();
            btnSearch = new Sunny.UI.UIButton();
            (uiSplitContainer1).BeginInit();
            uiSplitContainer1.Panel1.SuspendLayout();
            uiSplitContainer1.Panel2.SuspendLayout();
            uiSplitContainer1.SuspendLayout();
            uiTableLayoutPanel2.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiTableLayoutPanel4.SuspendLayout();
            uiFlowLayoutPanel1.SuspendLayout();
            uiTableLayoutPanel6.SuspendLayout();
            uiPanel5.SuspendLayout();
            uiTableLayoutPanel3.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            uiPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            cmsProduct.SuspendLayout();
            uiPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            uiSplitContainer1.BarColor = Color.FromArgb(80, 160, 255);
            uiSplitContainer1.Dock = DockStyle.Fill;
            uiSplitContainer1.HandleColor = Color.MediumBlue;
            uiSplitContainer1.HandleHoverColor = SystemColors.Highlight;
            uiSplitContainer1.Location = new Point(0, 0);
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
            uiSplitContainer1.Panel2.Controls.Add(uiTableLayoutPanel1);
            uiSplitContainer1.Size = new Size(1177, 553);
            uiSplitContainer1.SplitterDistance = 582;
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
            uiTableLayoutPanel2.Size = new Size(582, 553);
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
            uiPanel1.Size = new Size(574, 543);
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
            uiTableLayoutPanel4.Controls.Add(txtPrice, 1, 3);
            uiTableLayoutPanel4.Controls.Add(txtStock, 1, 4);
            uiTableLayoutPanel4.Controls.Add(lblIDProdut, 0, 0);
            uiTableLayoutPanel4.Controls.Add(lblName, 0, 1);
            uiTableLayoutPanel4.Controls.Add(lblType, 0, 2);
            uiTableLayoutPanel4.Controls.Add(lblPrice, 0, 3);
            uiTableLayoutPanel4.Controls.Add(lblStock, 0, 4);
            uiTableLayoutPanel4.Controls.Add(cboCategory, 1, 2);
            uiTableLayoutPanel4.Controls.Add(uiFlowLayoutPanel1, 1, 6);
            uiTableLayoutPanel4.Controls.Add(uiTableLayoutPanel6, 0, 5);
            uiTableLayoutPanel4.Controls.Add(uiPanel5, 1, 5);
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
            uiTableLayoutPanel4.Size = new Size(574, 482);
            uiTableLayoutPanel4.TabIndex = 1;
            uiTableLayoutPanel4.TagString = null;
            // 
            // txtIDProduct
            // 
            txtIDProduct.Dock = DockStyle.Fill;
            txtIDProduct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtIDProduct.Location = new Point(124, 5);
            txtIDProduct.Margin = new Padding(4, 5, 4, 5);
            txtIDProduct.MinimumSize = new Size(1, 16);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Padding = new Padding(5);
            txtIDProduct.ShowText = false;
            txtIDProduct.Size = new Size(446, 40);
            txtIDProduct.TabIndex = 0;
            txtIDProduct.TextAlignment = ContentAlignment.MiddleLeft;
            txtIDProduct.Watermark = "";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(124, 55);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MinimumSize = new Size(1, 16);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(5);
            txtName.ShowText = false;
            txtName.Size = new Size(446, 40);
            txtName.TabIndex = 1;
            txtName.TextAlignment = ContentAlignment.MiddleLeft;
            txtName.Watermark = "";
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPrice.Location = new Point(124, 155);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.MinimumSize = new Size(1, 16);
            txtPrice.Name = "txtPrice";
            txtPrice.Padding = new Padding(5);
            txtPrice.ShowText = false;
            txtPrice.Size = new Size(446, 40);
            txtPrice.TabIndex = 3;
            txtPrice.TextAlignment = ContentAlignment.MiddleLeft;
            txtPrice.Watermark = "";
            txtPrice.Leave += txtPrice_Leave;
            // 
            // txtStock
            // 
            txtStock.Dock = DockStyle.Fill;
            txtStock.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtStock.Location = new Point(124, 205);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.MinimumSize = new Size(1, 16);
            txtStock.Name = "txtStock";
            txtStock.Padding = new Padding(5);
            txtStock.ShowText = false;
            txtStock.Size = new Size(446, 40);
            txtStock.TabIndex = 4;
            txtStock.TextAlignment = ContentAlignment.MiddleLeft;
            txtStock.Watermark = "";
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
            lblStock.Text = "SL tồn kho: ";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboCategory
            // 
            cboCategory.DataSource = null;
            cboCategory.Dock = DockStyle.Fill;
            cboCategory.FillColor = Color.White;
            cboCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboCategory.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboCategory.Location = new Point(124, 105);
            cboCategory.Margin = new Padding(4, 5, 4, 5);
            cboCategory.MinimumSize = new Size(63, 0);
            cboCategory.Name = "cboCategory";
            cboCategory.Padding = new Padding(0, 0, 30, 2);
            cboCategory.Size = new Size(446, 40);
            cboCategory.SymbolSize = 24;
            cboCategory.TabIndex = 12;
            cboCategory.Text = "Danh mục";
            cboCategory.TextAlignment = ContentAlignment.MiddleLeft;
            cboCategory.Watermark = "";
            // 
            // uiFlowLayoutPanel1
            // 
            uiFlowLayoutPanel1.Controls.Add(btnDelete);
            uiFlowLayoutPanel1.Controls.Add(btnEdit);
            uiFlowLayoutPanel1.Controls.Add(btnAdd);
            uiFlowLayoutPanel1.Dock = DockStyle.Fill;
            uiFlowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiFlowLayoutPanel1.Location = new Point(124, 407);
            uiFlowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            uiFlowLayoutPanel1.MinimumSize = new Size(1, 1);
            uiFlowLayoutPanel1.Name = "uiFlowLayoutPanel1";
            uiFlowLayoutPanel1.Padding = new Padding(2);
            uiFlowLayoutPanel1.RectColor = Color.Transparent;
            uiFlowLayoutPanel1.ShowText = false;
            uiFlowLayoutPanel1.Size = new Size(446, 70);
            uiFlowLayoutPanel1.TabIndex = 14;
            uiFlowLayoutPanel1.Text = "uiFlowLayoutPanel1";
            uiFlowLayoutPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(341, 16);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Radius = 1;
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEdit.Font = new Font("Microsoft Sans Serif", 12F);
            btnEdit.Location = new Point(174, 16);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Sửa";
            btnEdit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Left;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(5, 16);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // uiTableLayoutPanel6
            // 
            uiTableLayoutPanel6.ColumnCount = 1;
            uiTableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel6.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel6.Controls.Add(btnImport, 0, 1);
            uiTableLayoutPanel6.Dock = DockStyle.Fill;
            uiTableLayoutPanel6.Location = new Point(3, 253);
            uiTableLayoutPanel6.Name = "uiTableLayoutPanel6";
            uiTableLayoutPanel6.RowCount = 2;
            uiTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel6.Size = new Size(114, 146);
            uiTableLayoutPanel6.TabIndex = 18;
            uiTableLayoutPanel6.TagString = null;
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Bottom;
            uiLabel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(3, 44);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(108, 29);
            uiLabel1.TabIndex = 16;
            uiLabel1.Text = "uiLabel1";
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.None;
            btnImport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnImport.Location = new Point(3, 90);
            btnImport.MinimumSize = new Size(1, 1);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(108, 39);
            btnImport.TabIndex = 2;
            btnImport.Text = "Import";
            btnImport.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            // 
            // uiPanel5
            // 
            uiPanel5.Controls.Add(btnClear);
            uiPanel5.Controls.Add(chkIsActive);
            uiPanel5.Dock = DockStyle.Fill;
            uiPanel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel5.Location = new Point(124, 255);
            uiPanel5.Margin = new Padding(4, 5, 4, 5);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.RectColor = Color.FromArgb(243, 249, 255);
            uiPanel5.Size = new Size(446, 142);
            uiPanel5.TabIndex = 19;
            uiPanel5.Text = null;
            uiPanel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F);
            btnClear.Location = new Point(150, 29);
            btnClear.MinimumSize = new Size(1, 1);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(108, 42);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnClear.Click += btnClear_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            chkIsActive.ForeColor = Color.FromArgb(48, 48, 48);
            chkIsActive.Location = new Point(-1, 0);
            chkIsActive.MinimumSize = new Size(1, 1);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(114, 36);
            chkIsActive.TabIndex = 15;
            chkIsActive.Text = "Đang bán";
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
            uiTableLayoutPanel3.Size = new Size(574, 61);
            uiTableLayoutPanel3.TabIndex = 0;
            uiTableLayoutPanel3.TagString = null;
            // 
            // uiPanel2
            // 
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Radius = 0;
            uiPanel2.RectColor = Color.Transparent;
            uiPanel2.Size = new Size(574, 61);
            uiPanel2.TabIndex = 0;
            uiPanel2.Text = "Thông tin sản phẩm";
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Controls.Add(uiPanel4, 0, 1);
            uiTableLayoutPanel1.Controls.Add(uiPanel3, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 2;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0198917F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.98011F));
            uiTableLayoutPanel1.Size = new Size(584, 553);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(dgvProduct);
            uiPanel4.Dock = DockStyle.Fill;
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel4.Location = new Point(0, 72);
            uiPanel4.Margin = new Padding(0);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.Size = new Size(584, 481);
            uiPanel4.TabIndex = 1;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeight = 32;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { cChose, cIDProduct, cName, cPrice, cStock, cIsActive, cCategoryID });
            dgvProduct.ContextMenuStrip = cmsProduct;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvProduct.GridColor = Color.MediumBlue;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvProduct.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProduct.SelectedIndex = -1;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(584, 481);
            dgvProduct.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellClick += dgvProduct_CellClick;
            dgvProduct.RowPrePaint += dgvProduct_RowPrePaint;
            dgvProduct.MouseDown += dgvProduct_MouseDown;
            // 
            // cChose
            // 
            cChose.HeaderText = "";
            cChose.MinimumWidth = 6;
            cChose.Name = "cChose";
            cChose.Resizable = DataGridViewTriState.True;
            cChose.SortMode = DataGridViewColumnSortMode.Automatic;
            cChose.Width = 60;
            // 
            // cIDProduct
            // 
            cIDProduct.HeaderText = "Mã sản phẩm";
            cIDProduct.MinimumWidth = 6;
            cIDProduct.Name = "cIDProduct";
            cIDProduct.ReadOnly = true;
            cIDProduct.Width = 125;
            // 
            // cName
            // 
            cName.HeaderText = "Tên sản phẩm";
            cName.MinimumWidth = 6;
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 125;
            // 
            // cPrice
            // 
            cPrice.HeaderText = "Giá";
            cPrice.MinimumWidth = 6;
            cPrice.Name = "cPrice";
            cPrice.ReadOnly = true;
            cPrice.Width = 125;
            // 
            // cStock
            // 
            cStock.HeaderText = "SL tồn kho";
            cStock.MinimumWidth = 6;
            cStock.Name = "cStock";
            cStock.ReadOnly = true;
            cStock.Width = 125;
            // 
            // cIsActive
            // 
            cIsActive.HeaderText = "IsActive";
            cIsActive.MinimumWidth = 6;
            cIsActive.Name = "cIsActive";
            cIsActive.Width = 125;
            // 
            // cCategoryID
            // 
            cCategoryID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cCategoryID.HeaderText = "Danh mục";
            cCategoryID.MinimumWidth = 6;
            cCategoryID.Name = "cCategoryID";
            cCategoryID.ReadOnly = true;
            // 
            // cmsProduct
            // 
            cmsProduct.BackColor = Color.FromArgb(243, 249, 255);
            cmsProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cmsProduct.ImageScalingSize = new Size(20, 20);
            cmsProduct.Items.AddRange(new ToolStripItem[] { tsmiSelectItem, tsmiSelectAll, tsmiUnselect, tsmiDeleteItem });
            cmsProduct.Name = "cmsProduct";
            cmsProduct.Size = new Size(185, 124);
            // 
            // tsmiSelectItem
            // 
            tsmiSelectItem.Name = "tsmiSelectItem";
            tsmiSelectItem.Size = new Size(184, 30);
            tsmiSelectItem.Text = "Chọn";
            tsmiSelectItem.Click += tsmiSelectItem_Click;
            // 
            // tsmiSelectAll
            // 
            tsmiSelectAll.Name = "tsmiSelectAll";
            tsmiSelectAll.Size = new Size(184, 30);
            tsmiSelectAll.Text = "Chọn tất cả";
            tsmiSelectAll.Click += tsmiSelectAll_Click;
            // 
            // tsmiUnselect
            // 
            tsmiUnselect.Name = "tsmiUnselect";
            tsmiUnselect.Size = new Size(184, 30);
            tsmiUnselect.Text = "Bỏ chọn";
            tsmiUnselect.Click += tsmiUnselect_Click;
            // 
            // tsmiDeleteItem
            // 
            tsmiDeleteItem.Name = "tsmiDeleteItem";
            tsmiDeleteItem.Size = new Size(184, 30);
            tsmiDeleteItem.Text = "Xóa";
            tsmiDeleteItem.Click += tsmiDeleteItem_Click;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(txtSearch);
            uiPanel3.Controls.Add(btnSearch);
            uiPanel3.Dock = DockStyle.Fill;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel3.Location = new Point(0, 0);
            uiPanel3.Margin = new Padding(0);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(584, 72);
            uiPanel3.TabIndex = 0;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.None;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSearch.Location = new Point(222, 14);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(286, 40);
            txtSearch.TabIndex = 1;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSearch.Location = new Point(79, 12);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 44);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TipsFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSearch.Click += btnSearch_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 553);
            Controls.Add(uiSplitContainer1);
            MinimumSize = new Size(1000, 600);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormProduct";
            Load += FormProduct_Load;
            Shown += FormProduct_Shown;
            uiSplitContainer1.Panel1.ResumeLayout(false);
            uiSplitContainer1.Panel2.ResumeLayout(false);
            (uiSplitContainer1).EndInit();
            uiSplitContainer1.ResumeLayout(false);
            uiTableLayoutPanel2.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiTableLayoutPanel4.ResumeLayout(false);
            uiFlowLayoutPanel1.ResumeLayout(false);
            uiTableLayoutPanel6.ResumeLayout(false);
            uiPanel5.ResumeLayout(false);
            uiTableLayoutPanel3.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            cmsProduct.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
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
        private Sunny.UI.UITextBox txtStock;
        private Sunny.UI.UILabel lblIDProdut;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UILabel lblType;
        private Sunny.UI.UILabel lblPrice;
        private Sunny.UI.UILabel lblStock;
        private Sunny.UI.UIComboBox cboCategory;
        private Sunny.UI.UITextBox txtPrice;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIFlowLayoutPanel uiFlowLayoutPanel1;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIDataGridView dgvProduct;
        private Sunny.UI.UITextBox txtSearch;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UICheckBox chkIsActive;
        private Sunny.UI.UIButton btnClear;
        private DataGridViewCheckBoxColumn cChose;
        private DataGridViewTextBoxColumn cIDProduct;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cPrice;
        private DataGridViewTextBoxColumn cStock;
        private DataGridViewTextBoxColumn cIsActive;
        private DataGridViewTextBoxColumn cCategoryID;
        private Sunny.UI.UIContextMenuStrip cmsProduct;
        private ToolStripMenuItem tsmiSelectItem;
        private ToolStripMenuItem tsmiSelectAll;
        private ToolStripMenuItem tsmiUnselect;
        private ToolStripMenuItem tsmiDeleteItem;
        private Sunny.UI.UIButton btnImport;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel6;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UILabel uiLabel1;
    }
}