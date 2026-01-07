namespace QLBanHang
{
    partial class FormSale
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
            uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            dgvCart = new Sunny.UI.UIDataGridView();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            cUnitPrice = new DataGridViewTextBoxColumn();
            cCount = new DataGridViewTextBoxColumn();
            cLineTotal = new DataGridViewTextBoxColumn();
            uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            lblTotalAmount = new Sunny.UI.UILabel();
            uiTableLayoutPanel9 = new Sunny.UI.UITableLayoutPanel();
            btnAdd = new Sunny.UI.UIButton();
            btnDelete = new Sunny.UI.UIButton();
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            txtUnitPrice = new Sunny.UI.UITextBox();
            txtProduct = new Sunny.UI.UILabel();
            cboProduct1 = new Sunny.UI.UIComboBox();
            lblCategory = new Sunny.UI.UILabel();
            lblPrice = new Sunny.UI.UILabel();
            lblCount = new Sunny.UI.UILabel();
            cboCategory = new Sunny.UI.UIComboBox();
            txtCount = new Sunny.UI.UITextBox();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lblChose = new Sunny.UI.UILabel();
            uiTableLayoutPanel8 = new Sunny.UI.UITableLayoutPanel();
            btnConfirm = new Sunny.UI.UIButton();
            btnExit = new Sunny.UI.UIButton();
            lblTotal = new Sunny.UI.UILabel();
            uiTableLayoutPanel7 = new Sunny.UI.UITableLayoutPanel();
            rdoCash = new Sunny.UI.UIRadioButton();
            uiRadioButton1 = new Sunny.UI.UIRadioButton();
            uiPanel3 = new Sunny.UI.UIPanel();
            lblCard = new Sunny.UI.UILabel();
            uiPanel2 = new Sunny.UI.UIPanel();
            lblBill = new Sunny.UI.UILabel();
            uiTableLayoutPanel6 = new Sunny.UI.UITableLayoutPanel();
            lblNamaCustomer = new Sunny.UI.UILabel();
            lblPhone = new Sunny.UI.UILabel();
            lblEmail = new Sunny.UI.UILabel();
            lblAdrress = new Sunny.UI.UILabel();
            txtNameCustomer = new Sunny.UI.UITextBox();
            uiTextBox5 = new Sunny.UI.UITextBox();
            uiTextBox6 = new Sunny.UI.UITextBox();
            uiTextBox7 = new Sunny.UI.UITextBox();
            uiTableLayoutPanel5 = new Sunny.UI.UITableLayoutPanel();
            lblInfor = new Sunny.UI.UILabel();
            (uiSplitContainer1).BeginInit();
            uiSplitContainer1.Panel1.SuspendLayout();
            uiSplitContainer1.Panel2.SuspendLayout();
            uiSplitContainer1.SuspendLayout();
            uiTableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            uiTableLayoutPanel4.SuspendLayout();
            uiTableLayoutPanel9.SuspendLayout();
            uiTableLayoutPanel2.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            uiTableLayoutPanel8.SuspendLayout();
            uiTableLayoutPanel7.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiTableLayoutPanel6.SuspendLayout();
            uiTableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            uiSplitContainer1.BarColor = Color.FromArgb(80, 160, 255);
            uiSplitContainer1.Dock = DockStyle.Fill;
            uiSplitContainer1.HandleColor = SystemColors.HotTrack;
            uiSplitContainer1.HandleHoverColor = SystemColors.MenuHighlight;
            uiSplitContainer1.Location = new Point(0, 0);
            uiSplitContainer1.MinimumSize = new Size(20, 20);
            uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            uiSplitContainer1.Panel1.Controls.Add(uiTableLayoutPanel3);
            uiSplitContainer1.Panel1.Controls.Add(uiTableLayoutPanel2);
            uiSplitContainer1.Panel1.Controls.Add(uiTableLayoutPanel1);
            // 
            // uiSplitContainer1.Panel2
            // 
            uiSplitContainer1.Panel2.Controls.Add(uiTableLayoutPanel8);
            uiSplitContainer1.Panel2.Controls.Add(uiTableLayoutPanel7);
            uiSplitContainer1.Panel2.Controls.Add(uiPanel3);
            uiSplitContainer1.Panel2.Controls.Add(uiPanel2);
            uiSplitContainer1.Panel2.Controls.Add(uiTableLayoutPanel6);
            uiSplitContainer1.Panel2.Controls.Add(uiTableLayoutPanel5);
            uiSplitContainer1.Size = new Size(1076, 800);
            uiSplitContainer1.SplitterDistance = 542;
            uiSplitContainer1.SplitterWidth = 11;
            uiSplitContainer1.TabIndex = 0;
            // 
            // uiTableLayoutPanel3
            // 
            uiTableLayoutPanel3.ColumnCount = 1;
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel3.Controls.Add(dgvCart, 0, 2);
            uiTableLayoutPanel3.Controls.Add(uiTableLayoutPanel4, 0, 1);
            uiTableLayoutPanel3.Controls.Add(lblTotalAmount, 0, 3);
            uiTableLayoutPanel3.Controls.Add(uiTableLayoutPanel9, 0, 0);
            uiTableLayoutPanel3.Dock = DockStyle.Fill;
            uiTableLayoutPanel3.Location = new Point(0, 250);
            uiTableLayoutPanel3.Margin = new Padding(0);
            uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            uiTableLayoutPanel3.RowCount = 4;
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            uiTableLayoutPanel3.Size = new Size(542, 550);
            uiTableLayoutPanel3.TabIndex = 2;
            uiTableLayoutPanel3.TagString = null;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCart.ColumnHeadersHeight = 32;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { dataGridViewCheckBoxColumn1, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, cUnitPrice, cCount, cLineTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCart.Dock = DockStyle.Fill;
            dgvCart.EnableHeadersVisualStyles = false;
            dgvCart.Font = new Font("Microsoft Sans Serif", 12F);
            dgvCart.GridColor = Color.FromArgb(80, 160, 255);
            dgvCart.Location = new Point(0, 110);
            dgvCart.Margin = new Padding(0);
            dgvCart.Name = "dgvCart";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvCart.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCart.SelectedIndex = -1;
            dgvCart.Size = new Size(542, 385);
            dgvCart.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvCart.TabIndex = 2;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.HeaderText = "";
            dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "STT";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // cUnitPrice
            // 
            cUnitPrice.HeaderText = "Đơn giá";
            cUnitPrice.MinimumWidth = 6;
            cUnitPrice.Name = "cUnitPrice";
            // 
            // cCount
            // 
            cCount.HeaderText = "SL";
            cCount.MinimumWidth = 6;
            cCount.Name = "cCount";
            // 
            // cLineTotal
            // 
            cLineTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cLineTotal.HeaderText = "Thành tiền";
            cLineTotal.MinimumWidth = 6;
            cLineTotal.Name = "cLineTotal";
            // 
            // uiTableLayoutPanel4
            // 
            uiTableLayoutPanel4.BackColor = Color.White;
            uiTableLayoutPanel4.ColumnCount = 1;
            uiTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel4.Controls.Add(uiLabel1, 0, 0);
            uiTableLayoutPanel4.Dock = DockStyle.Fill;
            uiTableLayoutPanel4.Location = new Point(0, 55);
            uiTableLayoutPanel4.Margin = new Padding(0);
            uiTableLayoutPanel4.Name = "uiTableLayoutPanel4";
            uiTableLayoutPanel4.RowCount = 1;
            uiTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel4.Size = new Size(542, 55);
            uiTableLayoutPanel4.TabIndex = 3;
            uiTableLayoutPanel4.TagString = null;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.White;
            uiLabel1.Dock = DockStyle.Fill;
            uiLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(0, 0);
            uiLabel1.Margin = new Padding(0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(542, 55);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Giỏ Hàng";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Dock = DockStyle.Fill;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.FromArgb(48, 48, 48);
            lblTotalAmount.Location = new Point(3, 495);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(536, 55);
            lblTotalAmount.TabIndex = 4;
            lblTotalAmount.Text = "Tổng tiền: ";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel9
            // 
            uiTableLayoutPanel9.BackColor = Color.White;
            uiTableLayoutPanel9.ColumnCount = 2;
            uiTableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel9.Controls.Add(btnAdd, 0, 0);
            uiTableLayoutPanel9.Controls.Add(btnDelete, 1, 0);
            uiTableLayoutPanel9.Dock = DockStyle.Fill;
            uiTableLayoutPanel9.Location = new Point(0, 0);
            uiTableLayoutPanel9.Margin = new Padding(0);
            uiTableLayoutPanel9.Name = "uiTableLayoutPanel9";
            uiTableLayoutPanel9.RowCount = 1;
            uiTableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel9.Size = new Size(542, 55);
            uiTableLayoutPanel9.TabIndex = 5;
            uiTableLayoutPanel9.TagString = null;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F);
            btnAdd.Location = new Point(73, 5);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F);
            btnDelete.Location = new Point(344, 5);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 44);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel2.ColumnCount = 2;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            uiTableLayoutPanel2.Controls.Add(txtUnitPrice, 1, 2);
            uiTableLayoutPanel2.Controls.Add(txtProduct, 0, 0);
            uiTableLayoutPanel2.Controls.Add(cboProduct1, 1, 0);
            uiTableLayoutPanel2.Controls.Add(lblCategory, 0, 1);
            uiTableLayoutPanel2.Controls.Add(lblPrice, 0, 2);
            uiTableLayoutPanel2.Controls.Add(lblCount, 0, 3);
            uiTableLayoutPanel2.Controls.Add(cboCategory, 1, 1);
            uiTableLayoutPanel2.Controls.Add(txtCount, 1, 3);
            uiTableLayoutPanel2.Dock = DockStyle.Top;
            uiTableLayoutPanel2.Location = new Point(0, 64);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 4;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel2.Size = new Size(542, 186);
            uiTableLayoutPanel2.TabIndex = 1;
            uiTableLayoutPanel2.TagString = null;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUnitPrice.Location = new Point(124, 97);
            txtUnitPrice.Margin = new Padding(4, 5, 20, 5);
            txtUnitPrice.MinimumSize = new Size(1, 16);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Padding = new Padding(5);
            txtUnitPrice.ShowText = false;
            txtUnitPrice.Size = new Size(398, 36);
            txtUnitPrice.TabIndex = 1;
            txtUnitPrice.TextAlignment = ContentAlignment.MiddleLeft;
            txtUnitPrice.Watermark = "";
            // 
            // txtProduct
            // 
            txtProduct.Dock = DockStyle.Fill;
            txtProduct.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProduct.ForeColor = Color.FromArgb(48, 48, 48);
            txtProduct.Location = new Point(3, 0);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(114, 46);
            txtProduct.TabIndex = 0;
            txtProduct.Text = "Sản phẩm:";
            txtProduct.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboProduct1
            // 
            cboProduct1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboProduct1.DataSource = null;
            cboProduct1.FillColor = Color.White;
            cboProduct1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProduct1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboProduct1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboProduct1.Location = new Point(124, 5);
            cboProduct1.Margin = new Padding(4, 5, 20, 5);
            cboProduct1.MinimumSize = new Size(63, 0);
            cboProduct1.Name = "cboProduct1";
            cboProduct1.Padding = new Padding(5, 5, 30, 5);
            cboProduct1.Size = new Size(398, 36);
            cboProduct1.SymbolSize = 24;
            cboProduct1.TabIndex = 8;
            cboProduct1.Text = "Sản Phẩm";
            cboProduct1.TextAlignment = ContentAlignment.MiddleLeft;
            cboProduct1.Watermark = "";
            cboProduct1.SelectedIndexChanged += cboProduct1_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(48, 48, 48);
            lblCategory.Location = new Point(3, 46);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(114, 46);
            lblCategory.TabIndex = 9;
            lblCategory.Text = "Danh mục:";
            lblCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            lblPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(48, 48, 48);
            lblPrice.Location = new Point(3, 92);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 29);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Đơn giá:";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            lblCount.Dock = DockStyle.Fill;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.FromArgb(48, 48, 48);
            lblCount.Location = new Point(3, 138);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(114, 48);
            lblCount.TabIndex = 11;
            lblCount.Text = "Số lượng: ";
            lblCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboCategory
            // 
            cboCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboCategory.DataSource = null;
            cboCategory.FillColor = Color.White;
            cboCategory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboCategory.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboCategory.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboCategory.Location = new Point(124, 51);
            cboCategory.Margin = new Padding(4, 5, 20, 5);
            cboCategory.MinimumSize = new Size(63, 0);
            cboCategory.Name = "cboCategory";
            cboCategory.Padding = new Padding(0, 0, 30, 2);
            cboCategory.Size = new Size(398, 36);
            cboCategory.SymbolSize = 24;
            cboCategory.TabIndex = 12;
            cboCategory.Text = "Danh mục";
            cboCategory.TextAlignment = ContentAlignment.MiddleLeft;
            cboCategory.Watermark = "";
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            // 
            // txtCount
            // 
            txtCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCount.Location = new Point(124, 143);
            txtCount.Margin = new Padding(4, 5, 20, 5);
            txtCount.MinimumSize = new Size(1, 16);
            txtCount.Name = "txtCount";
            txtCount.Padding = new Padding(5);
            txtCount.ShowText = false;
            txtCount.Size = new Size(398, 38);
            txtCount.TabIndex = 13;
            txtCount.TextAlignment = ContentAlignment.MiddleLeft;
            txtCount.Watermark = "";
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Controls.Add(lblChose, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Top;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(542, 64);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lblChose
            // 
            lblChose.Dock = DockStyle.Fill;
            lblChose.Font = new Font("Microsoft Sans Serif", 12F);
            lblChose.ForeColor = Color.FromArgb(48, 48, 48);
            lblChose.Location = new Point(3, 0);
            lblChose.Name = "lblChose";
            lblChose.Size = new Size(536, 64);
            lblChose.TabIndex = 0;
            lblChose.Text = "Chọn sản phẩm";
            lblChose.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel8
            // 
            uiTableLayoutPanel8.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel8.ColumnCount = 3;
            uiTableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            uiTableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            uiTableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            uiTableLayoutPanel8.Controls.Add(btnConfirm, 0, 0);
            uiTableLayoutPanel8.Controls.Add(btnExit, 1, 0);
            uiTableLayoutPanel8.Controls.Add(lblTotal, 2, 0);
            uiTableLayoutPanel8.Dock = DockStyle.Fill;
            uiTableLayoutPanel8.Location = new Point(0, 691);
            uiTableLayoutPanel8.Name = "uiTableLayoutPanel8";
            uiTableLayoutPanel8.RowCount = 1;
            uiTableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel8.Size = new Size(523, 109);
            uiTableLayoutPanel8.TabIndex = 5;
            uiTableLayoutPanel8.TagString = null;
            // 
            // btnConfirm
            // 
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Font = new Font("Microsoft Sans Serif", 12F);
            btnConfirm.Location = new Point(26, 32);
            btnConfirm.MinimumSize = new Size(1, 1);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(121, 44);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Đặt hàng";
            btnConfirm.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F);
            btnExit.Location = new Point(200, 32);
            btnExit.MinimumSize = new Size(1, 1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(121, 44);
            btnExit.TabIndex = 1;
            btnExit.Text = "Thoát";
            btnExit.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(48, 48, 48);
            lblTotal.Location = new Point(351, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(169, 109);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Tổng tiền:";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel7
            // 
            uiTableLayoutPanel7.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel7.ColumnCount = 1;
            uiTableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            uiTableLayoutPanel7.Controls.Add(rdoCash, 0, 0);
            uiTableLayoutPanel7.Controls.Add(uiRadioButton1, 0, 1);
            uiTableLayoutPanel7.Dock = DockStyle.Top;
            uiTableLayoutPanel7.Location = new Point(0, 491);
            uiTableLayoutPanel7.Name = "uiTableLayoutPanel7";
            uiTableLayoutPanel7.RowCount = 3;
            uiTableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uiTableLayoutPanel7.Size = new Size(523, 200);
            uiTableLayoutPanel7.TabIndex = 4;
            uiTableLayoutPanel7.TagString = null;
            // 
            // rdoCash
            // 
            rdoCash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rdoCash.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoCash.Location = new Point(3, 3);
            rdoCash.MinimumSize = new Size(1, 1);
            rdoCash.Name = "rdoCash";
            rdoCash.Size = new Size(517, 60);
            rdoCash.TabIndex = 0;
            rdoCash.Text = "Thanh toán khi nhận hàng";
            // 
            // uiRadioButton1
            // 
            uiRadioButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiRadioButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiRadioButton1.Location = new Point(3, 69);
            uiRadioButton1.MinimumSize = new Size(1, 1);
            uiRadioButton1.Name = "uiRadioButton1";
            uiRadioButton1.Size = new Size(517, 60);
            uiRadioButton1.TabIndex = 1;
            uiRadioButton1.Text = "Thẻ ngân hàng / tín dụng";
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(lblCard);
            uiPanel3.Dock = DockStyle.Top;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(0, 451);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(523, 40);
            uiPanel3.TabIndex = 3;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblCard
            // 
            lblCard.BackColor = SystemColors.GradientInactiveCaption;
            lblCard.Dock = DockStyle.Fill;
            lblCard.Font = new Font("Microsoft Sans Serif", 12F);
            lblCard.ForeColor = Color.FromArgb(48, 48, 48);
            lblCard.Location = new Point(0, 0);
            lblCard.Name = "lblCard";
            lblCard.Size = new Size(523, 40);
            lblCard.TabIndex = 0;
            lblCard.Text = "Hình thức thanh toán";
            lblCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(lblBill);
            uiPanel2.Dock = DockStyle.Top;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 396);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(523, 55);
            uiPanel2.TabIndex = 2;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblBill
            // 
            lblBill.BackColor = Color.LightSkyBlue;
            lblBill.Dock = DockStyle.Fill;
            lblBill.Font = new Font("Microsoft Sans Serif", 12F);
            lblBill.ForeColor = Color.FromArgb(48, 48, 48);
            lblBill.Location = new Point(0, 0);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(523, 55);
            lblBill.TabIndex = 0;
            lblBill.Text = "Thông tin hóa đơn";
            lblBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel6
            // 
            uiTableLayoutPanel6.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel6.ColumnCount = 2;
            uiTableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            uiTableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            uiTableLayoutPanel6.Controls.Add(lblNamaCustomer, 0, 0);
            uiTableLayoutPanel6.Controls.Add(lblPhone, 0, 1);
            uiTableLayoutPanel6.Controls.Add(lblEmail, 0, 2);
            uiTableLayoutPanel6.Controls.Add(lblAdrress, 0, 3);
            uiTableLayoutPanel6.Controls.Add(txtNameCustomer, 1, 0);
            uiTableLayoutPanel6.Controls.Add(uiTextBox5, 1, 1);
            uiTableLayoutPanel6.Controls.Add(uiTextBox6, 1, 2);
            uiTableLayoutPanel6.Controls.Add(uiTextBox7, 1, 3);
            uiTableLayoutPanel6.Dock = DockStyle.Top;
            uiTableLayoutPanel6.Location = new Point(0, 64);
            uiTableLayoutPanel6.Name = "uiTableLayoutPanel6";
            uiTableLayoutPanel6.RowCount = 4;
            uiTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel6.Size = new Size(523, 332);
            uiTableLayoutPanel6.TabIndex = 1;
            uiTableLayoutPanel6.TagString = null;
            // 
            // lblNamaCustomer
            // 
            lblNamaCustomer.Dock = DockStyle.Fill;
            lblNamaCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaCustomer.ForeColor = Color.FromArgb(48, 48, 48);
            lblNamaCustomer.Location = new Point(3, 0);
            lblNamaCustomer.Name = "lblNamaCustomer";
            lblNamaCustomer.Size = new Size(144, 83);
            lblNamaCustomer.TabIndex = 0;
            lblNamaCustomer.Text = "Tên khách hàng:";
            lblNamaCustomer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(48, 48, 48);
            lblPhone.Location = new Point(3, 83);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(144, 83);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Số điện thoại:";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(48, 48, 48);
            lblEmail.Location = new Point(3, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(144, 83);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdrress
            // 
            lblAdrress.Dock = DockStyle.Fill;
            lblAdrress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdrress.ForeColor = Color.FromArgb(48, 48, 48);
            lblAdrress.Location = new Point(3, 249);
            lblAdrress.Name = "lblAdrress";
            lblAdrress.Size = new Size(144, 83);
            lblAdrress.TabIndex = 3;
            lblAdrress.Text = "Địa chỉ:";
            lblAdrress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtNameCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNameCustomer.Location = new Point(154, 14);
            txtNameCustomer.Margin = new Padding(4, 5, 80, 5);
            txtNameCustomer.MinimumSize = new Size(1, 16);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.Padding = new Padding(5);
            txtNameCustomer.ShowText = false;
            txtNameCustomer.Size = new Size(289, 55);
            txtNameCustomer.TabIndex = 4;
            txtNameCustomer.TextAlignment = ContentAlignment.MiddleLeft;
            txtNameCustomer.Watermark = "";
            // 
            // uiTextBox5
            // 
            uiTextBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiTextBox5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox5.Location = new Point(154, 97);
            uiTextBox5.Margin = new Padding(4, 5, 80, 5);
            uiTextBox5.MinimumSize = new Size(1, 16);
            uiTextBox5.Name = "uiTextBox5";
            uiTextBox5.Padding = new Padding(5);
            uiTextBox5.ShowText = false;
            uiTextBox5.Size = new Size(289, 55);
            uiTextBox5.TabIndex = 5;
            uiTextBox5.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox5.Watermark = "";
            // 
            // uiTextBox6
            // 
            uiTextBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiTextBox6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox6.Location = new Point(154, 180);
            uiTextBox6.Margin = new Padding(4, 5, 80, 5);
            uiTextBox6.MinimumSize = new Size(1, 16);
            uiTextBox6.Name = "uiTextBox6";
            uiTextBox6.Padding = new Padding(5);
            uiTextBox6.ShowText = false;
            uiTextBox6.Size = new Size(289, 55);
            uiTextBox6.TabIndex = 6;
            uiTextBox6.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox6.Watermark = "";
            // 
            // uiTextBox7
            // 
            uiTextBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uiTextBox7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uiTextBox7.Location = new Point(154, 263);
            uiTextBox7.Margin = new Padding(4, 5, 80, 5);
            uiTextBox7.MinimumSize = new Size(1, 16);
            uiTextBox7.Name = "uiTextBox7";
            uiTextBox7.Padding = new Padding(5);
            uiTextBox7.ShowText = false;
            uiTextBox7.Size = new Size(289, 55);
            uiTextBox7.TabIndex = 7;
            uiTextBox7.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox7.Watermark = "";
            // 
            // uiTableLayoutPanel5
            // 
            uiTableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel5.ColumnCount = 1;
            uiTableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel5.Controls.Add(lblInfor, 0, 0);
            uiTableLayoutPanel5.Dock = DockStyle.Top;
            uiTableLayoutPanel5.Location = new Point(0, 0);
            uiTableLayoutPanel5.Name = "uiTableLayoutPanel5";
            uiTableLayoutPanel5.RowCount = 1;
            uiTableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel5.Size = new Size(523, 64);
            uiTableLayoutPanel5.TabIndex = 0;
            uiTableLayoutPanel5.TagString = null;
            // 
            // lblInfor
            // 
            lblInfor.Dock = DockStyle.Fill;
            lblInfor.Font = new Font("Microsoft Sans Serif", 12F);
            lblInfor.ForeColor = Color.FromArgb(48, 48, 48);
            lblInfor.Location = new Point(3, 0);
            lblInfor.Name = "lblInfor";
            lblInfor.Size = new Size(517, 64);
            lblInfor.TabIndex = 0;
            lblInfor.Text = "Thông tin khách hàng";
            lblInfor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 800);
            Controls.Add(uiSplitContainer1);
            Name = "FormSale";
            Text = "FormSale";
            Load += FormSale_Load;
            uiSplitContainer1.Panel1.ResumeLayout(false);
            uiSplitContainer1.Panel2.ResumeLayout(false);
            (uiSplitContainer1).EndInit();
            uiSplitContainer1.ResumeLayout(false);
            uiTableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            uiTableLayoutPanel4.ResumeLayout(false);
            uiTableLayoutPanel9.ResumeLayout(false);
            uiTableLayoutPanel2.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            uiTableLayoutPanel8.ResumeLayout(false);
            uiTableLayoutPanel7.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiTableLayoutPanel6.ResumeLayout(false);
            uiTableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UISplitContainer uiSplitContainer1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UILabel lblChose;
        private Sunny.UI.UILabel txtProduct;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel6;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel5;
        private Sunny.UI.UILabel lblInfor;
        private Sunny.UI.UILabel lblNamaCustomer;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UILabel lblEmail;
        private Sunny.UI.UILabel lblAdrress;
        private Sunny.UI.UITextBox txtNameCustomer;
        private Sunny.UI.UITextBox uiTextBox5;
        private Sunny.UI.UITextBox uiTextBox6;
        private Sunny.UI.UITextBox uiTextBox7;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel lblBill;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILabel lblCard;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel7;
        private Sunny.UI.UIRadioButton rdoCash;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel8;
        private Sunny.UI.UIButton btnConfirm;
        private Sunny.UI.UITextBox txtUnitPrice;
        private Sunny.UI.UIComboBox cboProduct1;
        private Sunny.UI.UILabel lblCategory;
        private Sunny.UI.UILabel lblPrice;
        private Sunny.UI.UILabel lblCount;
        private Sunny.UI.UIComboBox cboCategory;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UITextBox txtCount;
        private Sunny.UI.UIButton btnExit;
        private Sunny.UI.UILabel lblTotal;
        private Sunny.UI.UIDataGridView dgvCart;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private Sunny.UI.UILabel lblTotalAmount;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel9;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnDelete;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn cUnitPrice;
        private DataGridViewTextBoxColumn cCount;
        private DataGridViewTextBoxColumn cLineTotal;
    }
}