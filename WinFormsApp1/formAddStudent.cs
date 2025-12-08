using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formAddStudent : Form
    {
        public formAddStudent()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private bool CheckInputs()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Họ tên không được bỏ trống");
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtStudentID.Text))
            {
                MessageBox.Show("Mã số sinh viên không được bỏ trống");
                txtStudentID.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboCourse.Text))
            {
                MessageBox.Show("Khóa học không được bỏ trống");
                cboCourse.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputs())
                    return;

                string name = txtName.Text;
                string studentID = txtStudentID.Text;
                string className = txtClass.Text;
                string course = cboCourse.Text;
                string birthdate = dtpBirthdate.Value.ToString();
                string gender = rdoMan.Checked ? "Nam" : "Nữ";

                SQLiteUtils sQLiteUtils = new SQLiteUtils();

                DataTable dtCheck = sQLiteUtils.ExecuteQuery($"SELECT StudentID FROM Student WHERE StudentID = '{studentID}'");
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("MSSV đã tồn tại, vui lòng nhập MSSV khác!");
                    txtStudentID.Focus();
                    return;
                }

                sQLiteUtils.ExecuteQuery($"INSERT INTO Student(FullName, StudentID, Birthdate, Gender, ClassName, CourseName) VALUES ('{name}','{studentID}','{birthdate}','{gender}','{className}','{course}')");
               
                MessageBox.Show("Đã thêm vào database");
               
                // báo cho form cha biết là đã thêm ok
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Students ", ex);

            }
        }
    }
}
