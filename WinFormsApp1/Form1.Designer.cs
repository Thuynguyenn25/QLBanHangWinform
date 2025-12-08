namespace WinFormsApp1
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tblMain = new Sunny.UI.UITableLayoutPanel();
            pnlPanel1 = new Sunny.UI.UIPanel();
            dgvStudent = new Sunny.UI.UIDataGridView();
            cCheckbox = new DataGridViewCheckBoxColumn();
            cSTT = new DataGridViewTextBoxColumn();
            cStudentID = new DataGridViewTextBoxColumn();
            cName = new DataGridViewTextBoxColumn();
            cBirthdate = new DataGridViewTextBoxColumn();
            cGender = new DataGridViewTextBoxColumn();
            cClass = new DataGridViewTextBoxColumn();
            cCourse = new DataGridViewTextBoxColumn();
            cmsStudent = new Sunny.UI.UIContextMenuStrip();
            selectMenuItems = new ToolStripMenuItem();
            selectAllMenuItems = new ToolStripMenuItem();
            unSelectMenuItems = new ToolStripMenuItem();
            deleteMenuItems = new ToolStripMenuItem();
            pnlPanel2 = new Sunny.UI.UIPanel();
            lblTitle = new Sunny.UI.UILabel();
            pnlPanel3 = new Sunny.UI.UIPanel();
            tblInfo = new Sunny.UI.UITableLayoutPanel();
            pnlPanel11 = new Sunny.UI.UIPanel();
            btnDelete = new Sunny.UI.UIButton();
            pnlPanel10 = new Sunny.UI.UIPanel();
            btnUpdate = new Sunny.UI.UIButton();
            pnlPanel9 = new Sunny.UI.UIPanel();
            btnReset = new Sunny.UI.UIButton();
            btnAdd = new Sunny.UI.UIButton();
            pnlPanel8 = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            btnSearch = new Sunny.UI.UIButton();
            txtSearch = new Sunny.UI.UITextBox();
            pnlPanel6 = new Sunny.UI.UIPanel();
            txtClass = new Sunny.UI.UITextBox();
            lblClass = new Sunny.UI.UILabel();
            txtStudentID = new Sunny.UI.UITextBox();
            txtName = new Sunny.UI.UITextBox();
            lblStudentID = new Sunny.UI.UILabel();
            lblName = new Sunny.UI.UILabel();
            pnlPanel7 = new Sunny.UI.UIPanel();
            rdoFemale = new Sunny.UI.UIRadioButton();
            rdoMan = new Sunny.UI.UIRadioButton();
            cboCourse = new Sunny.UI.UIComboBox();
            lblCourse = new Sunny.UI.UILabel();
            lblGender = new Sunny.UI.UILabel();
            dtpBirthdate = new Sunny.UI.UIDatePicker();
            txtBirthdate = new Sunny.UI.UILabel();
            tblMain.SuspendLayout();
            pnlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            cmsStudent.SuspendLayout();
            pnlPanel2.SuspendLayout();
            pnlPanel3.SuspendLayout();
            tblInfo.SuspendLayout();
            pnlPanel11.SuspendLayout();
            pnlPanel10.SuspendLayout();
            pnlPanel9.SuspendLayout();
            pnlPanel8.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            pnlPanel6.SuspendLayout();
            pnlPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(pnlPanel1, 0, 2);
            tblMain.Controls.Add(pnlPanel2, 0, 0);
            tblMain.Controls.Add(pnlPanel3, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(1078, 572);
            tblMain.TabIndex = 0;
            tblMain.TagString = null;
            // 
            // pnlPanel1
            // 
            pnlPanel1.Controls.Add(dgvStudent);
            pnlPanel1.Dock = DockStyle.Fill;
            pnlPanel1.FillColor = SystemColors.ActiveCaption;
            pnlPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel1.Location = new Point(3, 316);
            pnlPanel1.Margin = new Padding(3, 0, 3, 0);
            pnlPanel1.MinimumSize = new Size(1, 1);
            pnlPanel1.Name = "pnlPanel1";
            pnlPanel1.Size = new Size(1072, 256);
            pnlPanel1.TabIndex = 0;
            pnlPanel1.Text = null;
            pnlPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.AllowUserToResizeColumns = false;
            dgvStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudent.BackgroundColor = Color.White;
            dgvStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStudent.ColumnHeadersHeight = 32;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudent.Columns.AddRange(new DataGridViewColumn[] { cCheckbox, cSTT, cStudentID, cName, cBirthdate, cGender, cClass, cCourse });
            dgvStudent.ContextMenuStrip = cmsStudent;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvStudent.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStudent.Dock = DockStyle.Fill;
            dgvStudent.EnableHeadersVisualStyles = false;
            dgvStudent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvStudent.GridColor = Color.Black;
            dgvStudent.Location = new Point(0, 0);
            dgvStudent.Name = "dgvStudent";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvStudent.SelectedIndex = -1;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudent.Size = new Size(1072, 256);
            dgvStudent.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellClick += dgvStudent_CellClick;
            dgvStudent.MouseDown += dgvStudent_MouseDown;
            // 
            // cCheckbox
            // 
            cCheckbox.HeaderText = "";
            cCheckbox.MinimumWidth = 6;
            cCheckbox.Name = "cCheckbox";
            cCheckbox.Width = 50;
            // 
            // cSTT
            // 
            cSTT.HeaderText = "STT";
            cSTT.MinimumWidth = 6;
            cSTT.Name = "cSTT";
            cSTT.ReadOnly = true;
            cSTT.Width = 50;
            // 
            // cStudentID
            // 
            cStudentID.HeaderText = "MSSV";
            cStudentID.MinimumWidth = 6;
            cStudentID.Name = "cStudentID";
            cStudentID.ReadOnly = true;
            cStudentID.Width = 125;
            // 
            // cName
            // 
            cName.HeaderText = "Họ tên";
            cName.MinimumWidth = 6;
            cName.Name = "cName";
            cName.ReadOnly = true;
            cName.Width = 200;
            // 
            // cBirthdate
            // 
            cBirthdate.HeaderText = "Ngày sinh";
            cBirthdate.MinimumWidth = 6;
            cBirthdate.Name = "cBirthdate";
            cBirthdate.ReadOnly = true;
            cBirthdate.Width = 125;
            // 
            // cGender
            // 
            cGender.HeaderText = "Giới tính";
            cGender.MinimumWidth = 6;
            cGender.Name = "cGender";
            cGender.ReadOnly = true;
            cGender.Width = 125;
            // 
            // cClass
            // 
            cClass.HeaderText = "Lớp";
            cClass.MinimumWidth = 6;
            cClass.Name = "cClass";
            cClass.ReadOnly = true;
            cClass.Width = 125;
            // 
            // cCourse
            // 
            cCourse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cCourse.HeaderText = "Khóa học";
            cCourse.MinimumWidth = 6;
            cCourse.Name = "cCourse";
            cCourse.ReadOnly = true;
            // 
            // cmsStudent
            // 
            cmsStudent.BackColor = Color.FromArgb(243, 249, 255);
            cmsStudent.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cmsStudent.ImageScalingSize = new Size(20, 20);
            cmsStudent.Items.AddRange(new ToolStripItem[] { selectMenuItems, selectAllMenuItems, unSelectMenuItems, deleteMenuItems });
            cmsStudent.Name = "uiContextMenuStrip1";
            cmsStudent.Size = new Size(209, 124);
            // 
            // selectMenuItems
            // 
            selectMenuItems.Name = "selectMenuItems";
            selectMenuItems.Size = new Size(208, 30);
            selectMenuItems.Text = "Chọn";
            selectMenuItems.Click += selectMenuItems_Click;
            // 
            // selectAllMenuItems
            // 
            selectAllMenuItems.Name = "selectAllMenuItems";
            selectAllMenuItems.Size = new Size(208, 30);
            selectAllMenuItems.Text = "Chọn tất cả";
            selectAllMenuItems.Click += selectAllMenuItems_Click;
            // 
            // unSelectMenuItems
            // 
            unSelectMenuItems.Name = "unSelectMenuItems";
            unSelectMenuItems.Size = new Size(208, 30);
            unSelectMenuItems.Text = "Bỏ chọn tất cả";
            unSelectMenuItems.Click += unSelectMenuItems_Click;
            // 
            // deleteMenuItems
            // 
            deleteMenuItems.Name = "deleteMenuItems";
            deleteMenuItems.Size = new Size(208, 30);
            deleteMenuItems.Text = "Xóa";
            deleteMenuItems.Click += deleteMenuItems_Click;
            // 
            // pnlPanel2
            // 
            pnlPanel2.Controls.Add(lblTitle);
            pnlPanel2.Dock = DockStyle.Fill;
            pnlPanel2.FillColor = SystemColors.ActiveCaption;
            pnlPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel2.Location = new Point(3, 0);
            pnlPanel2.Margin = new Padding(3, 0, 3, 0);
            pnlPanel2.MinimumSize = new Size(1, 1);
            pnlPanel2.Name = "pnlPanel2";
            pnlPanel2.Size = new Size(1072, 60);
            pnlPanel2.TabIndex = 1;
            pnlPanel2.Text = null;
            pnlPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = SystemColors.ActiveCaption;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1072, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lí sinh viên";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPanel3
            // 
            pnlPanel3.Controls.Add(tblInfo);
            pnlPanel3.Dock = DockStyle.Fill;
            pnlPanel3.FillColor = SystemColors.Info;
            pnlPanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel3.Location = new Point(3, 60);
            pnlPanel3.Margin = new Padding(3, 0, 3, 0);
            pnlPanel3.MinimumSize = new Size(1, 1);
            pnlPanel3.Name = "pnlPanel3";
            pnlPanel3.Size = new Size(1072, 256);
            pnlPanel3.TabIndex = 2;
            pnlPanel3.Text = null;
            pnlPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tblInfo
            // 
            tblInfo.BackColor = SystemColors.Info;
            tblInfo.ColumnCount = 3;
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblInfo.Controls.Add(pnlPanel11, 2, 1);
            tblInfo.Controls.Add(pnlPanel10, 1, 1);
            tblInfo.Controls.Add(pnlPanel9, 0, 1);
            tblInfo.Controls.Add(pnlPanel8, 2, 0);
            tblInfo.Controls.Add(pnlPanel6, 0, 0);
            tblInfo.Controls.Add(pnlPanel7, 1, 0);
            tblInfo.Dock = DockStyle.Fill;
            tblInfo.Location = new Point(0, 0);
            tblInfo.Name = "tblInfo";
            tblInfo.RowCount = 2;
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 76.5625F));
            tblInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4375F));
            tblInfo.Size = new Size(1072, 256);
            tblInfo.TabIndex = 0;
            tblInfo.TagString = null;
            // 
            // pnlPanel11
            // 
            pnlPanel11.Controls.Add(btnDelete);
            pnlPanel11.Dock = DockStyle.Fill;
            pnlPanel11.FillColor = SystemColors.Info;
            pnlPanel11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel11.Location = new Point(718, 201);
            pnlPanel11.Margin = new Padding(4, 5, 4, 5);
            pnlPanel11.MinimumSize = new Size(1, 1);
            pnlPanel11.Name = "pnlPanel11";
            pnlPanel11.RectColor = SystemColors.Info;
            pnlPanel11.Size = new Size(350, 50);
            pnlPanel11.TabIndex = 7;
            pnlPanel11.Text = null;
            pnlPanel11.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.FillColor = Color.SteelBlue;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDelete.Location = new Point(114, 3);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnDelete.Click += btnDelete_Click;
            // 
            // pnlPanel10
            // 
            pnlPanel10.Controls.Add(btnUpdate);
            pnlPanel10.Dock = DockStyle.Fill;
            pnlPanel10.FillColor = SystemColors.Info;
            pnlPanel10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel10.Location = new Point(361, 201);
            pnlPanel10.Margin = new Padding(4, 5, 4, 5);
            pnlPanel10.MinimumSize = new Size(1, 1);
            pnlPanel10.Name = "pnlPanel10";
            pnlPanel10.RectColor = SystemColors.Info;
            pnlPanel10.Size = new Size(349, 50);
            pnlPanel10.TabIndex = 6;
            pnlPanel10.Text = null;
            pnlPanel10.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.FillColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnUpdate.Location = new Point(122, 3);
            btnUpdate.MinimumSize = new Size(1, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 44);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnUpdate.Click += btnUpdate_Click;
            // 
            // pnlPanel9
            // 
            pnlPanel9.Controls.Add(btnReset);
            pnlPanel9.Controls.Add(btnAdd);
            pnlPanel9.Dock = DockStyle.Fill;
            pnlPanel9.FillColor = SystemColors.Info;
            pnlPanel9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel9.Location = new Point(4, 201);
            pnlPanel9.Margin = new Padding(4, 5, 4, 5);
            pnlPanel9.MinimumSize = new Size(1, 1);
            pnlPanel9.Name = "pnlPanel9";
            pnlPanel9.RectColor = SystemColors.Info;
            pnlPanel9.Size = new Size(349, 50);
            pnlPanel9.TabIndex = 5;
            pnlPanel9.Text = null;
            pnlPanel9.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.FillColor = Color.SteelBlue;
            btnReset.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnReset.Location = new Point(197, 3);
            btnReset.MinimumSize = new Size(1, 1);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 44);
            btnReset.TabIndex = 1;
            btnReset.Text = "Reset";
            btnReset.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnReset.Click += btnReset_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.FillColor = Color.SteelBlue;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnAdd.Location = new Point(22, 3);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlPanel8
            // 
            pnlPanel8.Controls.Add(uiPanel1);
            pnlPanel8.Dock = DockStyle.Fill;
            pnlPanel8.FillColor = SystemColors.Info;
            pnlPanel8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel8.Location = new Point(718, 5);
            pnlPanel8.Margin = new Padding(4, 5, 4, 5);
            pnlPanel8.MinimumSize = new Size(1, 1);
            pnlPanel8.Name = "pnlPanel8";
            pnlPanel8.RectColor = SystemColors.Info;
            pnlPanel8.Size = new Size(350, 186);
            pnlPanel8.TabIndex = 2;
            pnlPanel8.Text = null;
            pnlPanel8.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiPanel2);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.FillColor = SystemColors.Info;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = SystemColors.Info;
            uiPanel1.Size = new Size(350, 186);
            uiPanel1.TabIndex = 3;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(btnSearch);
            uiPanel2.Controls.Add(txtSearch);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.FillColor = SystemColors.Info;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel2.Location = new Point(0, 0);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = SystemColors.Info;
            uiPanel2.Size = new Size(350, 186);
            uiPanel2.TabIndex = 4;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top;
            btnSearch.FillColor = Color.SteelBlue;
            btnSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSearch.Location = new Point(222, 3);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 44);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtSearch.Location = new Point(22, 6);
            txtSearch.Margin = new Padding(4, 5, 4, 5);
            txtSearch.MinimumSize = new Size(1, 16);
            txtSearch.Name = "txtSearch";
            txtSearch.Padding = new Padding(5);
            txtSearch.ShowText = false;
            txtSearch.Size = new Size(188, 36);
            txtSearch.TabIndex = 0;
            txtSearch.TextAlignment = ContentAlignment.MiddleLeft;
            txtSearch.Watermark = "";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pnlPanel6
            // 
            pnlPanel6.Controls.Add(txtClass);
            pnlPanel6.Controls.Add(lblClass);
            pnlPanel6.Controls.Add(txtStudentID);
            pnlPanel6.Controls.Add(txtName);
            pnlPanel6.Controls.Add(lblStudentID);
            pnlPanel6.Controls.Add(lblName);
            pnlPanel6.Dock = DockStyle.Fill;
            pnlPanel6.FillColor = SystemColors.Info;
            pnlPanel6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel6.Location = new Point(4, 5);
            pnlPanel6.Margin = new Padding(4, 5, 4, 5);
            pnlPanel6.MinimumSize = new Size(1, 1);
            pnlPanel6.Name = "pnlPanel6";
            pnlPanel6.RectColor = SystemColors.Info;
            pnlPanel6.Size = new Size(349, 186);
            pnlPanel6.TabIndex = 0;
            pnlPanel6.Text = null;
            pnlPanel6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtClass
            // 
            txtClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtClass.Location = new Point(116, 130);
            txtClass.Margin = new Padding(4, 5, 4, 5);
            txtClass.MinimumSize = new Size(1, 16);
            txtClass.Name = "txtClass";
            txtClass.Padding = new Padding(5);
            txtClass.ShowText = false;
            txtClass.Size = new Size(193, 36);
            txtClass.TabIndex = 6;
            txtClass.TextAlignment = ContentAlignment.MiddleLeft;
            txtClass.Watermark = "";
            // 
            // lblClass
            // 
            lblClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblClass.ForeColor = Color.FromArgb(48, 48, 48);
            lblClass.Location = new Point(5, 134);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(104, 29);
            lblClass.TabIndex = 5;
            lblClass.Text = "Lớp: ";
            // 
            // txtStudentID
            // 
            txtStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtStudentID.Location = new Point(116, 69);
            txtStudentID.Margin = new Padding(4, 5, 4, 5);
            txtStudentID.MinimumSize = new Size(1, 16);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Padding = new Padding(5);
            txtStudentID.ReadOnly = true;
            txtStudentID.ShowText = false;
            txtStudentID.Size = new Size(193, 36);
            txtStudentID.TabIndex = 4;
            txtStudentID.TextAlignment = ContentAlignment.MiddleLeft;
            txtStudentID.Watermark = "";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(116, 6);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MinimumSize = new Size(1, 16);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(5);
            txtName.ShowText = false;
            txtName.Size = new Size(193, 36);
            txtName.TabIndex = 1;
            txtName.TextAlignment = ContentAlignment.MiddleLeft;
            txtName.Watermark = "";
            // 
            // lblStudentID
            // 
            lblStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStudentID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblStudentID.ForeColor = Color.FromArgb(48, 48, 48);
            lblStudentID.Location = new Point(5, 73);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(104, 29);
            lblStudentID.TabIndex = 3;
            lblStudentID.Text = "MSSV:";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblName.ForeColor = Color.FromArgb(48, 48, 48);
            lblName.Location = new Point(5, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 29);
            lblName.TabIndex = 0;
            lblName.Text = "Họ Tên:";
            // 
            // pnlPanel7
            // 
            pnlPanel7.Controls.Add(rdoFemale);
            pnlPanel7.Controls.Add(rdoMan);
            pnlPanel7.Controls.Add(cboCourse);
            pnlPanel7.Controls.Add(lblCourse);
            pnlPanel7.Controls.Add(lblGender);
            pnlPanel7.Controls.Add(dtpBirthdate);
            pnlPanel7.Controls.Add(txtBirthdate);
            pnlPanel7.Dock = DockStyle.Fill;
            pnlPanel7.FillColor = SystemColors.Info;
            pnlPanel7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlPanel7.Location = new Point(361, 5);
            pnlPanel7.Margin = new Padding(4, 5, 4, 5);
            pnlPanel7.MinimumSize = new Size(1, 1);
            pnlPanel7.Name = "pnlPanel7";
            pnlPanel7.RectColor = SystemColors.Info;
            pnlPanel7.Size = new Size(349, 186);
            pnlPanel7.TabIndex = 1;
            pnlPanel7.Text = null;
            pnlPanel7.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // rdoFemale
            // 
            rdoFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdoFemale.Location = new Point(245, 69);
            rdoFemale.MinimumSize = new Size(1, 1);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(105, 36);
            rdoFemale.TabIndex = 13;
            rdoFemale.Text = "Nữ";
            // 
            // rdoMan
            // 
            rdoMan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdoMan.Location = new Point(142, 69);
            rdoMan.MinimumSize = new Size(1, 1);
            rdoMan.Name = "rdoMan";
            rdoMan.Size = new Size(105, 36);
            rdoMan.TabIndex = 12;
            rdoMan.Text = "Nam";
            // 
            // cboCourse
            // 
            cboCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboCourse.DataSource = null;
            cboCourse.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboCourse.FillColor = Color.White;
            cboCourse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            cboCourse.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboCourse.Items.AddRange(new object[] { "C#", "C++", "Python", "SQL" });
            cboCourse.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboCourse.Location = new Point(148, 127);
            cboCourse.Margin = new Padding(4, 5, 4, 5);
            cboCourse.MinimumSize = new Size(63, 0);
            cboCourse.Name = "cboCourse";
            cboCourse.Padding = new Padding(0, 0, 30, 2);
            cboCourse.Size = new Size(176, 36);
            cboCourse.SymbolSize = 24;
            cboCourse.TabIndex = 11;
            cboCourse.TextAlignment = ContentAlignment.MiddleLeft;
            cboCourse.Watermark = "";
            // 
            // lblCourse
            // 
            lblCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCourse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblCourse.ForeColor = Color.FromArgb(48, 48, 48);
            lblCourse.Location = new Point(16, 134);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(125, 29);
            lblCourse.TabIndex = 10;
            lblCourse.Text = "Khóa học: ";
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblGender.ForeColor = Color.FromArgb(48, 48, 48);
            lblGender.Location = new Point(16, 73);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(125, 29);
            lblGender.TabIndex = 9;
            lblGender.Text = "Giới tính:";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthdate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpBirthdate.DateFormat = "dd/MM/yyyy";
            dtpBirthdate.FillColor = Color.White;
            dtpBirthdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdate.Location = new Point(148, 6);
            dtpBirthdate.Margin = new Padding(4, 5, 4, 5);
            dtpBirthdate.MaxLength = 10;
            dtpBirthdate.MinimumSize = new Size(63, 0);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Padding = new Padding(0, 0, 30, 2);
            dtpBirthdate.Size = new Size(176, 36);
            dtpBirthdate.SymbolDropDown = 61555;
            dtpBirthdate.SymbolNormal = 61555;
            dtpBirthdate.SymbolSize = 24;
            dtpBirthdate.TabIndex = 8;
            dtpBirthdate.Text = "02/12/2025";
            dtpBirthdate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpBirthdate.Value = new DateTime(2025, 12, 2, 0, 0, 0, 0);
            dtpBirthdate.Watermark = "";
            // 
            // txtBirthdate
            // 
            txtBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBirthdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtBirthdate.ForeColor = Color.FromArgb(48, 48, 48);
            txtBirthdate.Location = new Point(16, 10);
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.Size = new Size(125, 29);
            txtBirthdate.TabIndex = 7;
            txtBirthdate.Text = "Ngày sinh:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 572);
            Controls.Add(tblMain);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lí sinh viên";
            Load += Form1_Load;
            tblMain.ResumeLayout(false);
            pnlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            cmsStudent.ResumeLayout(false);
            pnlPanel2.ResumeLayout(false);
            pnlPanel3.ResumeLayout(false);
            tblInfo.ResumeLayout(false);
            pnlPanel11.ResumeLayout(false);
            pnlPanel10.ResumeLayout(false);
            pnlPanel9.ResumeLayout(false);
            pnlPanel8.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            pnlPanel6.ResumeLayout(false);
            pnlPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel tblMain;
        private Sunny.UI.UIPanel pnlPanel1;
        private Sunny.UI.UIPanel pnlPanel2;
        private Sunny.UI.UIPanel pnlPanel3;
        private Sunny.UI.UITableLayoutPanel tblInfo;
        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UIPanel pnlPanel11;
        private Sunny.UI.UIPanel pnlPanel10;
        private Sunny.UI.UIPanel pnlPanel9;
        private Sunny.UI.UIPanel pnlPanel8;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel pnlPanel6;
        private Sunny.UI.UIPanel pnlPanel7;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITextBox txtClass;
        private Sunny.UI.UILabel lblClass;
        private Sunny.UI.UITextBox txtStudentID;
        private Sunny.UI.UILabel lblStudentID;
        private Sunny.UI.UILabel lblGender;
        private Sunny.UI.UIDatePicker dtpBirthdate;
        private Sunny.UI.UILabel txtBirthdate;
        private Sunny.UI.UIRadioButton rdoFemale;
        private Sunny.UI.UIRadioButton rdoMan;
        private Sunny.UI.UIComboBox cboCourse;
        private Sunny.UI.UILabel lblCourse;
        private Sunny.UI.UIDataGridView dgvStudent;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnUpdate;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UITextBox txtSearch;
        private DataGridViewCheckBoxColumn cCheckbox;
        private DataGridViewTextBoxColumn cSTT;
        private DataGridViewTextBoxColumn cStudentID;
        private DataGridViewTextBoxColumn cName;
        private DataGridViewTextBoxColumn cBirthdate;
        private DataGridViewTextBoxColumn cGender;
        private DataGridViewTextBoxColumn cClass;
        private DataGridViewTextBoxColumn cCourse;
        private Sunny.UI.UIButton btnReset;
        private Sunny.UI.UIContextMenuStrip cmsStudent;
        private ToolStripMenuItem selectAllMenuItems;
        private ToolStripMenuItem deleteMenuItems;
        private ToolStripMenuItem unSelectMenuItems;
        private ToolStripMenuItem selectMenuItems;
    }
}
