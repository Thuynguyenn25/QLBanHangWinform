namespace QLBanHang.Forms
{
    partial class FormHoaDon
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
            tlpBill = new Sunny.UI.UITableLayoutPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            uiPanel10 = new Sunny.UI.UIPanel();
            lblOrderDate = new Sunny.UI.UILabel();
            uiPanel9 = new Sunny.UI.UIPanel();
            uiPanel8 = new Sunny.UI.UIPanel();
            uiPanel7 = new Sunny.UI.UIPanel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiPanel6 = new Sunny.UI.UIPanel();
            txtPhone = new Sunny.UI.UITextBox();
            uiPanel5 = new Sunny.UI.UIPanel();
            lblPhone = new Sunny.UI.UILabel();
            uiPanel4 = new Sunny.UI.UIPanel();
            txtNameCustomer = new Sunny.UI.UITextBox();
            uiPanel3 = new Sunny.UI.UIPanel();
            lblName = new Sunny.UI.UILabel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lblBill = new Sunny.UI.UILabel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            uiLabel17 = new Sunny.UI.UILabel();
            uiLabel18 = new Sunny.UI.UILabel();
            uiPanel13 = new Sunny.UI.UIPanel();
            dgvBill = new Sunny.UI.UIDataGridView();
            cChose = new DataGridViewCheckBoxColumn();
            cSTT = new DataGridViewTextBoxColumn();
            cIDProduct = new DataGridViewTextBoxColumn();
            cNameProduct = new DataGridViewTextBoxColumn();
            cCount = new DataGridViewTextBoxColumn();
            cPrice = new DataGridViewTextBoxColumn();
            cLineTotal = new DataGridViewTextBoxColumn();
            uiPanel14 = new Sunny.UI.UIPanel();
            btnExport = new Sunny.UI.UIButton();
            lblTotalAmount = new Sunny.UI.UILabel();
            tlpBill.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiTableLayoutPanel2.SuspendLayout();
            uiPanel10.SuspendLayout();
            uiPanel7.SuspendLayout();
            uiPanel6.SuspendLayout();
            uiPanel5.SuspendLayout();
            uiPanel4.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiTableLayoutPanel3.SuspendLayout();
            uiPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBill).BeginInit();
            uiPanel14.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBill
            // 
            tlpBill.ColumnCount = 1;
            tlpBill.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBill.Controls.Add(uiPanel2, 0, 1);
            tlpBill.Controls.Add(uiPanel1, 0, 0);
            tlpBill.Controls.Add(uiPanel13, 0, 2);
            tlpBill.Controls.Add(uiPanel14, 0, 3);
            tlpBill.Dock = DockStyle.Fill;
            tlpBill.Location = new Point(0, 0);
            tlpBill.Margin = new Padding(0);
            tlpBill.Name = "tlpBill";
            tlpBill.RowCount = 4;
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4935808F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Percent, 35.9954643F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Percent, 40.480732F));
            tlpBill.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0302248F));
            tlpBill.Size = new Size(990, 590);
            tlpBill.TabIndex = 0;
            tlpBill.TagString = null;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(uiTableLayoutPanel2);
            uiPanel2.Controls.Add(uiTableLayoutPanel1);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel2.Location = new Point(0, 79);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(990, 212);
            uiPanel2.TabIndex = 1;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel2
            // 
            uiTableLayoutPanel2.BackColor = Color.Transparent;
            uiTableLayoutPanel2.ColumnCount = 2;
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38F));
            uiTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62F));
            uiTableLayoutPanel2.Controls.Add(uiPanel10, 1, 3);
            uiTableLayoutPanel2.Controls.Add(uiPanel9, 0, 3);
            uiTableLayoutPanel2.Controls.Add(uiPanel8, 1, 2);
            uiTableLayoutPanel2.Controls.Add(uiPanel7, 0, 2);
            uiTableLayoutPanel2.Controls.Add(uiPanel6, 1, 1);
            uiTableLayoutPanel2.Controls.Add(uiPanel5, 0, 1);
            uiTableLayoutPanel2.Controls.Add(uiPanel4, 1, 0);
            uiTableLayoutPanel2.Controls.Add(uiPanel3, 0, 0);
            uiTableLayoutPanel2.Dock = DockStyle.Fill;
            uiTableLayoutPanel2.Location = new Point(0, 52);
            uiTableLayoutPanel2.Margin = new Padding(0);
            uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            uiTableLayoutPanel2.RowCount = 4;
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            uiTableLayoutPanel2.Size = new Size(990, 160);
            uiTableLayoutPanel2.TabIndex = 1;
            uiTableLayoutPanel2.TagString = null;
            // 
            // uiPanel10
            // 
            uiPanel10.Controls.Add(lblOrderDate);
            uiPanel10.Dock = DockStyle.Fill;
            uiPanel10.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel10.Location = new Point(376, 120);
            uiPanel10.Margin = new Padding(0);
            uiPanel10.MinimumSize = new Size(1, 1);
            uiPanel10.Name = "uiPanel10";
            uiPanel10.RectColor = Color.Transparent;
            uiPanel10.Size = new Size(614, 40);
            uiPanel10.TabIndex = 7;
            uiPanel10.Text = null;
            uiPanel10.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // lblOrderDate
            // 
            lblOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblOrderDate.ForeColor = Color.FromArgb(48, 48, 48);
            lblOrderDate.Location = new Point(4, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(320, 40);
            lblOrderDate.TabIndex = 0;
            // 
            // uiPanel9
            // 
            uiPanel9.Dock = DockStyle.Fill;
            uiPanel9.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel9.Location = new Point(0, 120);
            uiPanel9.Margin = new Padding(0);
            uiPanel9.MinimumSize = new Size(1, 1);
            uiPanel9.Name = "uiPanel9";
            uiPanel9.RectColor = Color.Transparent;
            uiPanel9.Size = new Size(376, 40);
            uiPanel9.TabIndex = 6;
            uiPanel9.Text = null;
            uiPanel9.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // uiPanel8
            // 
            uiPanel8.Dock = DockStyle.Fill;
            uiPanel8.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel8.Location = new Point(376, 80);
            uiPanel8.Margin = new Padding(0);
            uiPanel8.MinimumSize = new Size(1, 1);
            uiPanel8.Name = "uiPanel8";
            uiPanel8.RectColor = Color.Transparent;
            uiPanel8.Size = new Size(614, 40);
            uiPanel8.TabIndex = 5;
            uiPanel8.Text = null;
            uiPanel8.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // uiPanel7
            // 
            uiPanel7.Controls.Add(uiLabel1);
            uiPanel7.Dock = DockStyle.Fill;
            uiPanel7.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel7.Location = new Point(0, 80);
            uiPanel7.Margin = new Padding(0);
            uiPanel7.MinimumSize = new Size(1, 1);
            uiPanel7.Name = "uiPanel7";
            uiPanel7.RectColor = Color.Transparent;
            uiPanel7.Size = new Size(376, 40);
            uiPanel7.TabIndex = 4;
            uiPanel7.Text = null;
            uiPanel7.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(173, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(156, 38);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "Địa chỉ:";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiPanel6
            // 
            uiPanel6.Controls.Add(txtPhone);
            uiPanel6.Dock = DockStyle.Fill;
            uiPanel6.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel6.Location = new Point(376, 40);
            uiPanel6.Margin = new Padding(0);
            uiPanel6.MinimumSize = new Size(1, 1);
            uiPanel6.Name = "uiPanel6";
            uiPanel6.RectColor = Color.Transparent;
            uiPanel6.Size = new Size(614, 40);
            uiPanel6.TabIndex = 3;
            uiPanel6.Text = null;
            uiPanel6.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtPhone.Location = new Point(4, 3);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MinimumSize = new Size(1, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(5);
            txtPhone.ShowText = false;
            txtPhone.Size = new Size(320, 35);
            txtPhone.TabIndex = 2;
            txtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            txtPhone.Watermark = "";
            // 
            // uiPanel5
            // 
            uiPanel5.Controls.Add(lblPhone);
            uiPanel5.Dock = DockStyle.Fill;
            uiPanel5.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel5.Location = new Point(0, 40);
            uiPanel5.Margin = new Padding(0);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.RectColor = Color.Transparent;
            uiPanel5.Size = new Size(376, 40);
            uiPanel5.TabIndex = 2;
            uiPanel5.Text = null;
            uiPanel5.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblPhone.ForeColor = Color.FromArgb(48, 48, 48);
            lblPhone.Location = new Point(173, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(156, 38);
            lblPhone.TabIndex = 0;
            lblPhone.Text = "Số điện thoại:";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiPanel4
            // 
            uiPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel4.Controls.Add(txtNameCustomer);
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel4.Location = new Point(376, 0);
            uiPanel4.Margin = new Padding(0);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.RectColor = Color.Transparent;
            uiPanel4.Size = new Size(614, 40);
            uiPanel4.TabIndex = 1;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // txtNameCustomer
            // 
            txtNameCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtNameCustomer.Location = new Point(4, 4);
            txtNameCustomer.Margin = new Padding(4, 5, 4, 5);
            txtNameCustomer.MinimumSize = new Size(1, 16);
            txtNameCustomer.Name = "txtNameCustomer";
            txtNameCustomer.Padding = new Padding(5);
            txtNameCustomer.ShowText = false;
            txtNameCustomer.Size = new Size(320, 35);
            txtNameCustomer.TabIndex = 1;
            txtNameCustomer.TextAlignment = ContentAlignment.MiddleLeft;
            txtNameCustomer.Watermark = "";
            // 
            // uiPanel3
            // 
            uiPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uiPanel3.Controls.Add(lblName);
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel3.Location = new Point(0, 0);
            uiPanel3.Margin = new Padding(0);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.RectColor = Color.Transparent;
            uiPanel3.Size = new Size(376, 40);
            uiPanel3.TabIndex = 0;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblName.ForeColor = Color.FromArgb(48, 48, 48);
            lblName.Location = new Point(173, 2);
            lblName.Name = "lblName";
            lblName.Size = new Size(156, 38);
            lblName.TabIndex = 0;
            lblName.Text = "Tên khách hàng:";
            lblName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Controls.Add(lblBill, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Top;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Margin = new Padding(0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel1.Size = new Size(990, 52);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lblBill
            // 
            lblBill.Dock = DockStyle.Fill;
            lblBill.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBill.ForeColor = Color.FromArgb(48, 48, 48);
            lblBill.Location = new Point(0, 0);
            lblBill.Margin = new Padding(0);
            lblBill.Name = "lblBill";
            lblBill.Size = new Size(990, 52);
            lblBill.TabIndex = 0;
            lblBill.Text = "ĐƠN ĐẶT HÀNG";
            lblBill.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiTableLayoutPanel3);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(0);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(990, 79);
            uiPanel1.TabIndex = 3;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel3
            // 
            uiTableLayoutPanel3.ColumnCount = 1;
            uiTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel3.Controls.Add(uiLabel17, 0, 0);
            uiTableLayoutPanel3.Controls.Add(uiLabel18, 0, 1);
            uiTableLayoutPanel3.Dock = DockStyle.Fill;
            uiTableLayoutPanel3.Location = new Point(0, 0);
            uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            uiTableLayoutPanel3.RowCount = 2;
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            uiTableLayoutPanel3.Size = new Size(990, 79);
            uiTableLayoutPanel3.TabIndex = 0;
            uiTableLayoutPanel3.TagString = null;
            // 
            // uiLabel17
            // 
            uiLabel17.BackColor = Color.GhostWhite;
            uiLabel17.Dock = DockStyle.Fill;
            uiLabel17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel17.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel17.Location = new Point(0, 0);
            uiLabel17.Margin = new Padding(0);
            uiLabel17.Name = "uiLabel17";
            uiLabel17.Size = new Size(990, 39);
            uiLabel17.TabIndex = 0;
            // 
            // uiLabel18
            // 
            uiLabel18.BackColor = Color.GhostWhite;
            uiLabel18.Dock = DockStyle.Fill;
            uiLabel18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiLabel18.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel18.Location = new Point(0, 39);
            uiLabel18.Margin = new Padding(0);
            uiLabel18.Name = "uiLabel18";
            uiLabel18.Size = new Size(990, 40);
            uiLabel18.TabIndex = 1;
            uiLabel18.Text = " Địa chỉ: ";
            // 
            // uiPanel13
            // 
            uiPanel13.Controls.Add(dgvBill);
            uiPanel13.Dock = DockStyle.Fill;
            uiPanel13.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel13.Location = new Point(0, 291);
            uiPanel13.Margin = new Padding(0);
            uiPanel13.MinimumSize = new Size(1, 1);
            uiPanel13.Name = "uiPanel13";
            uiPanel13.Size = new Size(990, 238);
            uiPanel13.TabIndex = 4;
            uiPanel13.Text = null;
            uiPanel13.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvBill
            // 
            dgvBill.AllowUserToAddRows = false;
            dgvBill.AllowUserToDeleteRows = false;
            dgvBill.AllowUserToOrderColumns = true;
            dgvBill.AllowUserToResizeColumns = false;
            dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.BackgroundColor = Color.White;
            dgvBill.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBill.ColumnHeadersHeight = 32;
            dgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvBill.Columns.AddRange(new DataGridViewColumn[] { cChose, cSTT, cIDProduct, cNameProduct, cCount, cPrice, cLineTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBill.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBill.Dock = DockStyle.Fill;
            dgvBill.EnableHeadersVisualStyles = false;
            dgvBill.Font = new Font("Microsoft Sans Serif", 12F);
            dgvBill.GridColor = SystemColors.MenuHighlight;
            dgvBill.Location = new Point(0, 0);
            dgvBill.Margin = new Padding(0);
            dgvBill.Name = "dgvBill";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBill.RowHeadersVisible = false;
            dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F);
            dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBill.SelectedIndex = -1;
            dgvBill.Size = new Size(990, 238);
            dgvBill.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvBill.TabIndex = 0;
            // 
            // cChose
            // 
            cChose.FillWeight = 5F;
            cChose.HeaderText = "";
            cChose.MinimumWidth = 6;
            cChose.Name = "cChose";
            cChose.Resizable = DataGridViewTriState.True;
            cChose.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // cSTT
            // 
            cSTT.FillWeight = 6F;
            cSTT.HeaderText = "STT";
            cSTT.MinimumWidth = 6;
            cSTT.Name = "cSTT";
            cSTT.ReadOnly = true;
            // 
            // cIDProduct
            // 
            cIDProduct.FillWeight = 14F;
            cIDProduct.HeaderText = "Mã hàng";
            cIDProduct.MinimumWidth = 6;
            cIDProduct.Name = "cIDProduct";
            cIDProduct.ReadOnly = true;
            // 
            // cNameProduct
            // 
            cNameProduct.FillWeight = 30F;
            cNameProduct.HeaderText = "Tên hàng";
            cNameProduct.MinimumWidth = 6;
            cNameProduct.Name = "cNameProduct";
            cNameProduct.ReadOnly = true;
            // 
            // cCount
            // 
            cCount.FillWeight = 10F;
            cCount.HeaderText = "Số lượng";
            cCount.MinimumWidth = 6;
            cCount.Name = "cCount";
            cCount.ReadOnly = true;
            // 
            // cPrice
            // 
            cPrice.FillWeight = 15F;
            cPrice.HeaderText = "Đơn giá";
            cPrice.MinimumWidth = 6;
            cPrice.Name = "cPrice";
            cPrice.ReadOnly = true;
            // 
            // cLineTotal
            // 
            cLineTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cLineTotal.FillWeight = 20F;
            cLineTotal.HeaderText = "Thành tiền";
            cLineTotal.MinimumWidth = 6;
            cLineTotal.Name = "cLineTotal";
            cLineTotal.ReadOnly = true;
            // 
            // uiPanel14
            // 
            uiPanel14.BackColor = Color.Transparent;
            uiPanel14.Controls.Add(btnExport);
            uiPanel14.Controls.Add(lblTotalAmount);
            uiPanel14.Dock = DockStyle.Fill;
            uiPanel14.Font = new Font("Microsoft Sans Serif", 12F);
            uiPanel14.Location = new Point(0, 529);
            uiPanel14.Margin = new Padding(0);
            uiPanel14.MinimumSize = new Size(1, 1);
            uiPanel14.Name = "uiPanel14";
            uiPanel14.Size = new Size(990, 61);
            uiPanel14.TabIndex = 5;
            uiPanel14.Text = null;
            uiPanel14.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            btnExport.Anchor = AnchorStyles.None;
            btnExport.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnExport.Location = new Point(686, 9);
            btnExport.Margin = new Padding(0);
            btnExport.MinimumSize = new Size(1, 1);
            btnExport.Name = "btnExport";
            btnExport.Radius = 1;
            btnExport.Size = new Size(137, 41);
            btnExport.TabIndex = 0;
            btnExport.Text = "Xuất hóa đơn";
            btnExport.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnExport.Click += btnExport_Click;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Dock = DockStyle.Left;
            lblTotalAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblTotalAmount.ForeColor = Color.FromArgb(48, 48, 48);
            lblTotalAmount.Location = new Point(0, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(491, 61);
            lblTotalAmount.TabIndex = 5;
            lblTotalAmount.Text = "Tổng tiền: ";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 590);
            Controls.Add(tlpBill);
            MinimumSize = new Size(800, 500);
            Name = "FormHoaDon";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hóa Đơn";
            Load += FormHoaDon_Load;
            tlpBill.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiTableLayoutPanel2.ResumeLayout(false);
            uiPanel10.ResumeLayout(false);
            uiPanel7.ResumeLayout(false);
            uiPanel6.ResumeLayout(false);
            uiPanel5.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiTableLayoutPanel3.ResumeLayout(false);
            uiPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBill).EndInit();
            uiPanel14.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel tlpBill;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel lblBill;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UILabel uiLabel18;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIPanel uiPanel12;
        private Sunny.UI.UIPanel uiPanel11;
        private Sunny.UI.UIPanel uiPanel10;
        private Sunny.UI.UIPanel uiPanel9;
        private Sunny.UI.UIPanel uiPanel8;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UILabel lblPhone;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UIPanel uiPanel13;
        private Sunny.UI.UIDataGridView dgvBill;
        private Sunny.UI.UIPanel uiPanel14;
        private Sunny.UI.UIButton btnImport;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lblTotalAmount;
        private Sunny.UI.UITextBox txtNameCustomer;
        private Sunny.UI.UITextBox txtPhone;
        private Sunny.UI.UILabel lblOrderDate;
        private DataGridViewCheckBoxColumn cChose;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cIDProduct;
        private DataGridViewTextBoxColumn cNameProduct;
        private DataGridViewTextBoxColumn cCount;
        private DataGridViewTextBoxColumn cPrice;
        private DataGridViewTextBoxColumn cLineTotal;
        private Sunny.UI.UIButton btnExport;
    }
}