

using System.Data;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void LoadStudents()
        {
            dgvStudent.Rows.Clear();
            string query = @"SELECT * FROM Student";
            SQLiteUtils sQLiteUtils = new SQLiteUtils();
            DataTable dt = sQLiteUtils.ExecuteQuery(query);

            foreach (DataRow dr in dt.Rows)
            {
                DateTime birth = Convert.ToDateTime(dr["Birthdate"]);
                string birthStr = birth.ToString("dd/MM/yyyy");   

                dgvStudent.Rows.Add(
                    false,
                    dgvStudent.Rows.Count + 1,
                    dr["StudentID"].ToString(),
                    dr["FullName"],
                    birthStr,                 
                    dr["Gender"],
                    dr["ClassName"],
                    dr["CourseName"]
                );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string name = txtName.Text;
            //    string studentID = txtStudentID.Text;
            //    string className = txtClass.Text;
            //    string course = cboCourse.Text;
            //    string birthdate = dtpBirthdate.Value.ToString();
            //    string gender = rdoMan.Checked ? "Nam" : "Nữ";

            //    //dgvStudent.Rows.Add(false, dgvStudent.Rows.Count+1 , name, studentID, birthdate, gender, className, course);
            //    SQLiteUtils sQLiteUtils = new SQLiteUtils();
            //    sQLiteUtils.ExecuteQuery($"INSERT INTO Student(FullName, StudentID, Birthdate, Gender, ClassName, CourseName) VALUES ('{name}','{studentID}','{birthdate}','{gender}','{className}','{course}')");
            //    MessageBox.Show("Đã thêm vào database");
            //    LoadStudents();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    Utils.Log("Add Students ", ex);

            //}

            using (var f = new formAddStudent())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoadStudents();
                }
            }

        }
        //
        private void Form1_Shown(object? sender, EventArgs e)
        {
            dgvStudent.ClearSelection();
            dgvStudent.CurrentCell = null;
        }
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInputs())
                    return;
                if (dgvStudent.CurrentRow == null)
                {
                    MessageBox.Show("Hãy chọn một dòng để sửa");
                    return;
                }
                DataGridViewRow row = dgvStudent.CurrentRow;

                string oldStudentID = row.Cells[2].Value.ToString();

                string name = txtName.Text.Trim();
                DateTime birthdate = dtpBirthdate.Value.Date;
                string gender = rdoMan.Checked ? "Nam" : "Nữ";
                string className = txtClass.Text.Trim();
                string course = cboCourse.Text.Trim();

                string birthStr = birthdate.ToString("yyyy-MM-dd");

                SQLiteUtils sQL = new SQLiteUtils();
                sQL.ExecuteQuery($"UPDATE Student Set FullName ='{name}', Birthdate = '{birthStr}',Gender='{gender}',ClassName='{className}',CourseName='{course}'  WHERE StudentID ='{oldStudentID}' ");

                MessageBox.Show("Đã update thành công");
                LoadStudents();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Update Student", ex);

            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                txtName.Text = row.Cells["cName"].Value?.ToString();
                txtStudentID.Text = row.Cells["cStudentID"].Value?.ToString();
                txtClass.Text = row.Cells["cClass"].Value?.ToString();
                dtpBirthdate.Text = row.Cells["cBirthdate"].Value?.ToString();
                cboCourse.Text = row.Cells["cCourse"].Value?.ToString();
                string gender = row.Cells["cGender"].Value?.ToString();
                rdoMan.Checked = gender == "Nam";
                rdoFemale.Checked = gender == "Nữ";
            }
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
            if (string.IsNullOrEmpty(txtClass.Text))
            {
                MessageBox.Show("Lớp học không được bỏ trống");
                txtClass.Focus();
                return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool hasChecked = false;

                SQLiteUtils sQL = new SQLiteUtils();
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    bool isChecked = row.Cells[0].Value != null
                            && Convert.ToBoolean(row.Cells[0].Value);
                    if (isChecked)
                    {
                        hasChecked = true;
                        String studentID = row.Cells[2].Value.ToString();
                        sQL.ExecuteQuery($"DELETE FROM Student WHERE StudentID = '{studentID}'");
                    }

                }
                if (!hasChecked)
                {
                    MessageBox.Show("Vui lòng tick chọn ô để xóa");
                    return;
                }


                //if (dgvStudent.CurrentRow == null)
                //{
                //    MessageBox.Show("Hãy chọn 1 dòng để xóa");
                //    return;
                //}
                //DataGridViewRow row = dgvStudent.CurrentRow;

                //string studentID = row.Cells[2].Value.ToString();

                //SQLiteUtils sQL = new SQLiteUtils();
                //sQL.ExecuteQuery($"DELETE from Student WHERE StudentID = '{studentID}' ");

                MessageBox.Show("Đã xóa thành công");
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Delete Student", ex);
            }
        }

        private void SearchStudent()
        {
            try
            {
                string keyword = txtSearch.Text.Trim();
                dgvStudent.Rows.Clear();

                SQLiteUtils sQL = new SQLiteUtils();

                string query = $@" 
                    SELECT FullName, StudentID, Birthdate, Gender, ClassName, CourseName
                    FROM Student
                    WHERE FullName   LIKE '%{keyword}%'
                       OR Gender     LIKE '%{keyword}%'
                       OR ClassName  LIKE '%{keyword}%'
                       OR CourseName LIKE '%{keyword}%';
                ";

                DataTable dt = sQL.ExecuteQuery(query);

                foreach (DataRow dr in dt.Rows)
                {
                    DateTime birth = Convert.ToDateTime(dr["Birthdate"]);
                    string birthStr = birth.ToString("dd/MM/yyyy");

                    dgvStudent.Rows.Add(
                        false,
                        dgvStudent.Rows.Count + 1,
                        dr["StudentID"].ToString(),
                        dr["FullName"].ToString(),
                        birthStr,                  
                        dr["Gender"].ToString(),
                        dr["ClassName"].ToString(),
                        dr["CourseName"].ToString()
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Search Student", ex);
            }
            dgvStudent.ClearSelection();
            dgvStudent.CurrentCell = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                LoadStudents();
            }
            else
            {
                SearchStudent();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                LoadStudents();
            }
            else
            {
                SearchStudent();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtStudentID.Clear();
            txtClass.Clear();
            dtpBirthdate.Value = DateTime.Now;
            rdoMan.Checked = false;
            rdoFemale.Checked = false;
            cboCourse.SelectedIndex = -1;

        }
        //lấy đúng dòng khi click chuột phải
        private void dgvStudent_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvStudent.HitTest(e.X, e.Y);

            if (hit.RowIndex < 0)
            {
                dgvStudent.ClearSelection();
                dgvStudent.CurrentCell = null;
                return;
            }

            if (!dgvStudent.Rows[hit.RowIndex].Selected)
            {
                dgvStudent.ClearSelection();
                dgvStudent.Rows[hit.RowIndex].Selected = true;

                int colIndex = hit.ColumnIndex >= 0 ? hit.ColumnIndex : 1;
                dgvStudent.CurrentCell = dgvStudent.Rows[hit.RowIndex].Cells[colIndex];
            }
        }



        private void selectAllMenuItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void unSelectMenuItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void selectMenuItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.SelectedRows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void deleteMenuItems_Click(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
                return; 
            }
            SQLiteUtils sQL = new SQLiteUtils();
            foreach (DataGridViewRow row in dgvStudent.SelectedRows)
            {
                string studentID = row.Cells[2].Value.ToString(); 
                sQL.ExecuteQuery($"DELETE FROM Student WHERE StudentID = '{studentID}'");
            }
            MessageBox.Show("Đã xóa thành công");
            LoadStudents();
        }


    }
}
