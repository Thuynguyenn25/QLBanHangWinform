namespace WinFormsApp1
{
    partial class formAddStudent
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
            tblFormAdd = new Sunny.UI.UITableLayoutPanel();
            uiPanel4 = new Sunny.UI.UIPanel();
            btnCancel = new Sunny.UI.UIButton();
            uiPanel3 = new Sunny.UI.UIPanel();
            btnSave = new Sunny.UI.UIButton();
            uiPanel2 = new Sunny.UI.UIPanel();
            cboCourse = new Sunny.UI.UIComboBox();
            rdoFemale = new Sunny.UI.UIRadioButton();
            rdoMan = new Sunny.UI.UIRadioButton();
            dtpBirthdate = new Sunny.UI.UIDatePicker();
            lblCourse = new Sunny.UI.UILabel();
            lblGender = new Sunny.UI.UILabel();
            lblBirthdate = new Sunny.UI.UILabel();
            pnlFrmAdd1 = new Sunny.UI.UIPanel();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel5 = new Sunny.UI.UIPanel();
            uiPanel6 = new Sunny.UI.UIPanel();
            uiPanel7 = new Sunny.UI.UIPanel();
            txtClass = new Sunny.UI.UITextBox();
            lblClass = new Sunny.UI.UILabel();
            txtStudentID = new Sunny.UI.UITextBox();
            lblStudentID = new Sunny.UI.UILabel();
            txtName = new Sunny.UI.UITextBox();
            lblName = new Sunny.UI.UILabel();
            tblFormAdd.SuspendLayout();
            uiPanel4.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel2.SuspendLayout();
            pnlFrmAdd1.SuspendLayout();
            uiPanel1.SuspendLayout();
            uiPanel5.SuspendLayout();
            uiPanel6.SuspendLayout();
            uiPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tblFormAdd
            // 
            tblFormAdd.ColumnCount = 2;
            tblFormAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblFormAdd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblFormAdd.Controls.Add(uiPanel4, 1, 1);
            tblFormAdd.Controls.Add(uiPanel3, 0, 1);
            tblFormAdd.Controls.Add(uiPanel2, 1, 0);
            tblFormAdd.Controls.Add(pnlFrmAdd1, 0, 0);
            tblFormAdd.Dock = DockStyle.Fill;
            tblFormAdd.Location = new Point(0, 0);
            tblFormAdd.Name = "tblFormAdd";
            tblFormAdd.RowCount = 2;
            tblFormAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 81.26464F));
            tblFormAdd.RowStyles.Add(new RowStyle(SizeType.Percent, 18.735363F));
            tblFormAdd.Size = new Size(788, 427);
            tblFormAdd.TabIndex = 0;
            tblFormAdd.TagString = null;
            // 
            // uiPanel4
            // 
            uiPanel4.Controls.Add(btnCancel);
            uiPanel4.Dock = DockStyle.Fill;
            uiPanel4.FillColor = SystemColors.Info;
            uiPanel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel4.Location = new Point(394, 347);
            uiPanel4.Margin = new Padding(0);
            uiPanel4.MinimumSize = new Size(1, 1);
            uiPanel4.Name = "uiPanel4";
            uiPanel4.RectColor = SystemColors.Info;
            uiPanel4.Size = new Size(394, 80);
            uiPanel4.TabIndex = 4;
            uiPanel4.Text = null;
            uiPanel4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.FillColor = Color.SteelBlue;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.Location = new Point(135, 18);
            btnCancel.MinimumSize = new Size(1, 1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 44);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Hủy";
            btnCancel.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnCancel.Click += btnCancel_Click;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(btnSave);
            uiPanel3.Dock = DockStyle.Fill;
            uiPanel3.FillColor = SystemColors.Info;
            uiPanel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel3.Location = new Point(0, 347);
            uiPanel3.Margin = new Padding(0);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.RectColor = SystemColors.Info;
            uiPanel3.Size = new Size(394, 80);
            uiPanel3.TabIndex = 3;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.FillColor = Color.SteelBlue;
            btnSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.Location = new Point(135, 18);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 163);
            btnSave.Click += btnSave_Click;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(cboCourse);
            uiPanel2.Controls.Add(rdoFemale);
            uiPanel2.Controls.Add(rdoMan);
            uiPanel2.Controls.Add(dtpBirthdate);
            uiPanel2.Controls.Add(lblCourse);
            uiPanel2.Controls.Add(lblGender);
            uiPanel2.Controls.Add(lblBirthdate);
            uiPanel2.Dock = DockStyle.Fill;
            uiPanel2.FillColor = SystemColors.Info;
            uiPanel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel2.Location = new Point(394, 0);
            uiPanel2.Margin = new Padding(0);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.RectColor = SystemColors.Info;
            uiPanel2.Size = new Size(394, 347);
            uiPanel2.TabIndex = 2;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
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
            cboCourse.Location = new Point(146, 197);
            cboCourse.Margin = new Padding(4, 5, 4, 5);
            cboCourse.MinimumSize = new Size(63, 0);
            cboCourse.Name = "cboCourse";
            cboCourse.Padding = new Padding(0, 0, 30, 2);
            cboCourse.Size = new Size(200, 36);
            cboCourse.StyleDropDown = Sunny.UI.UIStyle.LayuiRed;
            cboCourse.SymbolSize = 24;
            cboCourse.TabIndex = 12;
            cboCourse.TextAlignment = ContentAlignment.MiddleLeft;
            cboCourse.Watermark = "";
            // 
            // rdoFemale
            // 
            rdoFemale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdoFemale.BackColor = SystemColors.Info;
            rdoFemale.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdoFemale.Location = new Point(235, 119);
            rdoFemale.MinimumSize = new Size(1, 1);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(111, 36);
            rdoFemale.TabIndex = 11;
            rdoFemale.Text = "Nữ";
            // 
            // rdoMan
            // 
            rdoMan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdoMan.BackColor = SystemColors.Info;
            rdoMan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            rdoMan.Location = new Point(129, 119);
            rdoMan.MinimumSize = new Size(1, 1);
            rdoMan.Name = "rdoMan";
            rdoMan.Size = new Size(111, 36);
            rdoMan.TabIndex = 10;
            rdoMan.Text = "Nam";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpBirthdate.DateCultureInfo = new System.Globalization.CultureInfo("");
            dtpBirthdate.FillColor = Color.White;
            dtpBirthdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dtpBirthdate.Location = new Point(141, 33);
            dtpBirthdate.Margin = new Padding(4, 5, 4, 5);
            dtpBirthdate.MaxLength = 10;
            dtpBirthdate.MinimumSize = new Size(63, 0);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Padding = new Padding(0, 0, 30, 2);
            dtpBirthdate.Size = new Size(205, 44);
            dtpBirthdate.SymbolDropDown = 61555;
            dtpBirthdate.SymbolNormal = 61555;
            dtpBirthdate.SymbolSize = 24;
            dtpBirthdate.TabIndex = 9;
            dtpBirthdate.Text = "2025-12-03";
            dtpBirthdate.TextAlignment = ContentAlignment.MiddleLeft;
            dtpBirthdate.Value = new DateTime(2025, 12, 3, 10, 40, 38, 367);
            dtpBirthdate.Watermark = "";
            // 
            // lblCourse
            // 
            lblCourse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCourse.BackColor = SystemColors.Info;
            lblCourse.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblCourse.ForeColor = Color.FromArgb(48, 48, 48);
            lblCourse.Location = new Point(21, 202);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(142, 29);
            lblCourse.TabIndex = 8;
            lblCourse.Text = "Khóa học: ";
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblGender.BackColor = SystemColors.Info;
            lblGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblGender.ForeColor = Color.FromArgb(48, 48, 48);
            lblGender.Location = new Point(21, 124);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(142, 29);
            lblGender.TabIndex = 7;
            lblGender.Text = "Giới tính:";
            // 
            // lblBirthdate
            // 
            lblBirthdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBirthdate.BackColor = SystemColors.Info;
            lblBirthdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblBirthdate.ForeColor = Color.FromArgb(48, 48, 48);
            lblBirthdate.Location = new Point(21, 43);
            lblBirthdate.Name = "lblBirthdate";
            lblBirthdate.Size = new Size(142, 29);
            lblBirthdate.TabIndex = 6;
            lblBirthdate.Text = "Ngày Sinh: ";
            // 
            // pnlFrmAdd1
            // 
            pnlFrmAdd1.Controls.Add(uiPanel1);
            pnlFrmAdd1.Dock = DockStyle.Fill;
            pnlFrmAdd1.FillColor = SystemColors.Info;
            pnlFrmAdd1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            pnlFrmAdd1.Location = new Point(0, 0);
            pnlFrmAdd1.Margin = new Padding(0);
            pnlFrmAdd1.MinimumSize = new Size(1, 1);
            pnlFrmAdd1.Name = "pnlFrmAdd1";
            pnlFrmAdd1.RectColor = SystemColors.Info;
            pnlFrmAdd1.Size = new Size(394, 347);
            pnlFrmAdd1.TabIndex = 0;
            pnlFrmAdd1.Text = null;
            pnlFrmAdd1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiPanel5);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.FillColor = SystemColors.Info;
            uiPanel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = SystemColors.Info;
            uiPanel1.Size = new Size(394, 347);
            uiPanel1.TabIndex = 1;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel5
            // 
            uiPanel5.Controls.Add(uiPanel6);
            uiPanel5.Dock = DockStyle.Fill;
            uiPanel5.FillColor = SystemColors.Info;
            uiPanel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel5.Location = new Point(0, 0);
            uiPanel5.Margin = new Padding(4, 5, 4, 5);
            uiPanel5.MinimumSize = new Size(1, 1);
            uiPanel5.Name = "uiPanel5";
            uiPanel5.RectColor = SystemColors.Info;
            uiPanel5.Size = new Size(394, 347);
            uiPanel5.TabIndex = 2;
            uiPanel5.Text = null;
            uiPanel5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel6
            // 
            uiPanel6.Controls.Add(uiPanel7);
            uiPanel6.Dock = DockStyle.Fill;
            uiPanel6.FillColor = SystemColors.Info;
            uiPanel6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel6.Location = new Point(0, 0);
            uiPanel6.Margin = new Padding(4, 5, 4, 5);
            uiPanel6.MinimumSize = new Size(1, 1);
            uiPanel6.Name = "uiPanel6";
            uiPanel6.RectColor = SystemColors.Info;
            uiPanel6.Size = new Size(394, 347);
            uiPanel6.TabIndex = 2;
            uiPanel6.Text = null;
            uiPanel6.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel7
            // 
            uiPanel7.BackColor = SystemColors.Info;
            uiPanel7.Controls.Add(txtClass);
            uiPanel7.Controls.Add(lblClass);
            uiPanel7.Controls.Add(txtStudentID);
            uiPanel7.Controls.Add(lblStudentID);
            uiPanel7.Controls.Add(txtName);
            uiPanel7.Controls.Add(lblName);
            uiPanel7.Dock = DockStyle.Fill;
            uiPanel7.FillColor = SystemColors.Info;
            uiPanel7.FillColor2 = SystemColors.Info;
            uiPanel7.FillDisableColor = SystemColors.Info;
            uiPanel7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            uiPanel7.Location = new Point(0, 0);
            uiPanel7.Margin = new Padding(0);
            uiPanel7.MinimumSize = new Size(1, 1);
            uiPanel7.Name = "uiPanel7";
            uiPanel7.Radius = 0;
            uiPanel7.RectColor = SystemColors.Info;
            uiPanel7.Size = new Size(394, 347);
            uiPanel7.TabIndex = 2;
            uiPanel7.Text = null;
            uiPanel7.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtClass
            // 
            txtClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtClass.Location = new Point(141, 197);
            txtClass.Margin = new Padding(4, 5, 4, 5);
            txtClass.MinimumSize = new Size(1, 16);
            txtClass.Name = "txtClass";
            txtClass.Padding = new Padding(5);
            txtClass.ShowText = false;
            txtClass.Size = new Size(208, 39);
            txtClass.TabIndex = 6;
            txtClass.TextAlignment = ContentAlignment.MiddleLeft;
            txtClass.Watermark = "";
            // 
            // lblClass
            // 
            lblClass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblClass.BackColor = SystemColors.Info;
            lblClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblClass.ForeColor = Color.FromArgb(48, 48, 48);
            lblClass.Location = new Point(23, 202);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(112, 29);
            lblClass.TabIndex = 5;
            lblClass.Text = "Lớp: ";
            // 
            // txtStudentID
            // 
            txtStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtStudentID.Location = new Point(141, 119);
            txtStudentID.Margin = new Padding(4, 5, 4, 5);
            txtStudentID.MinimumSize = new Size(1, 16);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Padding = new Padding(5);
            txtStudentID.ShowText = false;
            txtStudentID.Size = new Size(208, 39);
            txtStudentID.TabIndex = 4;
            txtStudentID.TextAlignment = ContentAlignment.MiddleLeft;
            txtStudentID.Watermark = "";
            // 
            // lblStudentID
            // 
            lblStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStudentID.BackColor = SystemColors.Info;
            lblStudentID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblStudentID.ForeColor = Color.FromArgb(48, 48, 48);
            lblStudentID.Location = new Point(23, 124);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(112, 29);
            lblStudentID.TabIndex = 3;
            lblStudentID.Text = "MSSV: ";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            txtName.Location = new Point(141, 38);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MinimumSize = new Size(1, 16);
            txtName.Name = "txtName";
            txtName.Padding = new Padding(5);
            txtName.ShowText = false;
            txtName.Size = new Size(208, 39);
            txtName.TabIndex = 2;
            txtName.TextAlignment = ContentAlignment.MiddleLeft;
            txtName.Watermark = "";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblName.BackColor = SystemColors.Info;
            lblName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblName.ForeColor = Color.FromArgb(48, 48, 48);
            lblName.Location = new Point(23, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(112, 29);
            lblName.TabIndex = 1;
            lblName.Text = "Họ Tên:";
            // 
            // formAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 427);
            Controls.Add(tblFormAdd);
            Name = "formAddStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "formAddStudent";
            tblFormAdd.ResumeLayout(false);
            uiPanel4.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            pnlFrmAdd1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            uiPanel5.ResumeLayout(false);
            uiPanel6.ResumeLayout(false);
            uiPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel tblFormAdd;
        private Sunny.UI.UIPanel uiPanel4;
        private Sunny.UI.UIPanel uiPanel3;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UIPanel pnlFrmAdd1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel5;
        private Sunny.UI.UIPanel uiPanel6;
        private Sunny.UI.UIPanel uiPanel7;
        private Sunny.UI.UILabel lblName;
        private Sunny.UI.UITextBox txtName;
        private Sunny.UI.UITextBox txtClass;
        private Sunny.UI.UILabel lblClass;
        private Sunny.UI.UITextBox txtStudentID;
        private Sunny.UI.UILabel lblStudentID;
        private Sunny.UI.UIComboBox cboCourse;
        private Sunny.UI.UIRadioButton rdoFemale;
        private Sunny.UI.UIRadioButton rdoMan;
        private Sunny.UI.UIDatePicker dtpBirthdate;
        private Sunny.UI.UILabel lblCourse;
        private Sunny.UI.UILabel lblGender;
        private Sunny.UI.UILabel lblBirthdate;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSave;
    }
}