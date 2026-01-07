using QLBanHang.Data;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            this.Shown += FormCategory_Shown;
                
        }

        private void FormCategory_Shown(object sender, EventArgs e)
        {
            dgvCategory.ClearSelection();
            dgvCategory.CurrentCell = null;
        }
        private void SetButtonState(bool isEditing)
        {
            btnAddCate.Enabled = !isEditing;
            btnUpdateCate.Enabled = isEditing;
            btnDeleteCate.Enabled = isEditing;
          
        }
        public void Clear()
        {
            txtIDCategory.Clear();
            txtName.Clear();
            txtDescription.Clear();
            errorProvider2.Clear();
            errorProvider1.Clear();

            SetButtonState(false);
        }
        private void LoadCategory()
        {
            try
            {
                dgvCategory.Rows.Clear();

                string query = $"SELECT * FROM Categories ";
                SQLiteUtils sQL = new SQLiteUtils();
                DataTable dt = sQL.ExecuteQuery(query);

                foreach (DataRow dr in dt.Rows)
                {
                    dgvCategory.Rows.Add(
                        false,
                        dr["CategoryID"],
                        dr["Name"],
                        dr["Description"]
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("LoadData: ", ex);
            }
        }
        private void FormCategory_Load(object sender, EventArgs e)
        {
            LoadCategory();
            SetButtonState(false);
        }
       

        private bool ValidateInput()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider1.SetError(txtDescription, "");
            errorProvider2.SetError(txtName, "");
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Mô tả danh mục không được để trống");
                return false;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider2.SetError(txtName, "Tên danh mục không được để trống");
                return false;
            }
            return true;
        }
        private void btnClearCate_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //-----
        private void btnAddCate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                string name = txtName.Text;
                string description = txtDescription.Text;
                string query = $"INSERT INTO Categories(Name, Description) " +
                    $"VALUES ('{name}', '{description}')";
                SQLiteUtils sQL = new SQLiteUtils();

                DataTable dtCheck = sQL.ExecuteQuery($"SELECT * FROM Categories WHERE Name='{name}'");
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Danh mục đã tồn tại");
                    return;
                }
                sQL.ExecuteQuery(query);
                MessageBox.Show("Đã thêm danh mục thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Category: ", ex);
            }
            LoadCategory();
            Clear();
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];

                txtIDCategory.Text = row.Cells["cIDCategory"].Value.ToString();
                txtName.Text = row.Cells["cName"].Value.ToString();
                txtDescription.Text = row.Cells["cDescription"].Value.ToString();

            }
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                string name = txtName.Text;
                string description = txtDescription.Text;
                int idCategory = Convert.ToInt32(txtIDCategory.Text);

                string query = $"UPDATE categories SET Name ='{name}', Description='{description}' WHERE CategoryID='{idCategory}'";
                SQLiteUtils sQLiteUtils = new SQLiteUtils();
                sQLiteUtils.ExecuteQuery(query);

                MessageBox.Show("Đã cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Update Category: ", ex);
            }
            LoadCategory();
            Clear();
        }



        //---------
        private void SearchCategory()
        {
            string keyword = txtSearchCate.Text;
            string kw = "%" + keyword + "%";
            dgvCategory.Rows.Clear();

            string query = $@"SELECT * FROM Categories 
                                    WHERE Name LIKE '{kw}' 
                                        OR Description LIKE '{kw}'";
            SQLiteUtils sQL = new SQLiteUtils();
            DataTable dt = sQL.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                dgvCategory.Rows.Add(
                    false,
                    dr["CategoryID"],
                    dr["Name"],
                    dr["Description"]
                    );
            }
        }
        private void txtSearchCate_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchCate.Text))
            {
                LoadCategory();
            }
            else
            {
                SearchCategory();
            }

        }
        private void btnSearchCate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchCate.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm");
                return;
            }
            SearchCategory();
        }

        private void btnDeleteCate_Click(object sender, EventArgs e)
        {
            int idCategory = int.Parse(txtIDCategory.Text);

            DialogResult result = MessageBox.Show(
             $"Bạn có chắc chắn muốn xóa danh mục số {idCategory} không?",
            "Xác nhận xóa",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );
            if (result != DialogResult.Yes) return;

            SQLiteUtils sQL = new SQLiteUtils();
            string query = $"DELETE FROM Products WHERE ProductID = {idCategory}";
            sQL.ExecuteQuery(query);

            LoadCategory();
        }

        //--------------
        private void dgvCategory_MouseDown(object sender, MouseEventArgs e)
        {
            var hit = dgvCategory.HitTest(e.X, e.Y);
            if (hit.RowIndex < 0)
            {
                dgvCategory.ClearSelection();
                dgvCategory.CurrentCell = null;
                return;
            }
            if (!dgvCategory.Rows[hit.RowIndex].Selected)
            {
                dgvCategory.ClearSelection();
                dgvCategory.Rows[hit.RowIndex].Selected = true;
                int colIndex = hit.ColumnIndex >= 0 ? hit.ColumnIndex : 1;
                dgvCategory.CurrentCell = dgvCategory.Rows[hit.RowIndex].Cells[colIndex];
            }
            SetButtonState(true);
        }
        private void tsmiSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.SelectedRows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void tsmiSelectItemAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                row.Cells[0].Value = true;
            }
        }
        private void tsmiUnSelectItem_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                row.Cells[0].Value = false;
            }
        }
        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            dgvCategory.EndEdit();

            int countChecked = 0;
            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                bool isChecked = row.Cells["cChose"].Value != null &&
                                 Convert.ToBoolean(row.Cells["cChose"].Value);
                if (isChecked) countChecked++;
            }

            if (countChecked == 0)
            {
                MessageBox.Show("Vui lòng tick chọn ô để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa {countChecked} danh mục đã chọn không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            SQLiteUtils sql = new SQLiteUtils();

            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                bool isChecked = row.Cells["cChose"].Value != null &&
                                 Convert.ToBoolean(row.Cells["cChose"].Value);
                if (isChecked)
                {
                    int idCategory = Convert.ToInt32(row.Cells["cIDCategory"].Value);
                    string query = $"DELETE FROM Categories WHERE CategoryID = {idCategory}";
                    sql.ExecuteQuery(query);
                }
            }

            LoadCategory();
        }






    }
}
