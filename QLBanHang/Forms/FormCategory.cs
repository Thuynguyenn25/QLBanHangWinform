using QLBanHang.BLL;
using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class FormCategory : Form
    {
        private readonly CategoryBLL _categoryBLL = new CategoryBLL();

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
                var categories = _categoryBLL.GetAll();

                foreach (var c in categories)
                {
                    dgvCategory.Rows.Add(false, c.CategoryID, c.Name, c.Description);
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

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var category = new CategoryDTO
                {
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };

                var (success, message) = _categoryBLL.Add(category);
                MessageBox.Show(message);
                if (!success) return;
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
                SetButtonState(true);
            }
        }

        private void btnUpdateCate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                var category = new CategoryDTO
                {
                    CategoryID = Convert.ToInt32(txtIDCategory.Text),
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };

                var (success, message) = _categoryBLL.Update(category);
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Update Category: ", ex);
            }
            LoadCategory();
            Clear();
        }

        private void SearchCategory()
        {
            string keyword = txtSearchCate.Text;
            dgvCategory.Rows.Clear();

            var categories = _categoryBLL.Search(keyword);
            foreach (var c in categories)
            {
                dgvCategory.Rows.Add(false, c.CategoryID, c.Name, c.Description);
            }
        }

        private void txtSearchCate_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchCate.Text))
                LoadCategory();
            else
                SearchCategory();
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
            if (string.IsNullOrEmpty(txtIDCategory.Text)) return;
            int idCategory = int.Parse(txtIDCategory.Text);

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa danh mục số {idCategory} không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            var (success, message) = _categoryBLL.Delete(idCategory);
            if (!success)
            {
                MessageBox.Show(message);
                return;
            }

            LoadCategory();
            Clear();
        }

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
                row.Cells[0].Value = true;
        }

        private void tsmiSelectItemAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.Rows)
                row.Cells[0].Value = true;
        }

        private void tsmiUnSelectItem_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCategory.Rows)
                row.Cells[0].Value = false;
        }

        private void tsmiDeleteItem_Click(object sender, EventArgs e)
        {
            dgvCategory.EndEdit();

            int countChecked = 0;
            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                bool isChecked = row.Cells["cChose"].Value != null && Convert.ToBoolean(row.Cells["cChose"].Value);
                if (isChecked) countChecked++;
            }

            if (countChecked == 0)
            {
                MessageBox.Show("Vui lòng tick chọn ô để xóa!");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa {countChecked} danh mục đã chọn không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            foreach (DataGridViewRow row in dgvCategory.Rows)
            {
                bool isChecked = row.Cells["cChose"].Value != null && Convert.ToBoolean(row.Cells["cChose"].Value);
                if (!isChecked) continue;

                int idCategory = Convert.ToInt32(row.Cells["cIDCategory"].Value);

                var (canDelete, msg) = _categoryBLL.CanDelete(idCategory);
                if (!canDelete)
                {
                    MessageBox.Show(msg);
                    continue;
                }

                _categoryBLL.Delete(idCategory);
            }

            LoadCategory();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvCategory.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV file (*.csv)|*.csv";
                sfd.FileName = "Categories.csv";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    StringBuilder sb = new StringBuilder();
                    string[] columnNames = new string[dgvCategory.Columns.Count];
                    for (int i = 0; i < dgvCategory.Columns.Count; i++)
                        columnNames[i] = dgvCategory.Columns[i].HeaderText;
                    sb.AppendLine(string.Join(",", columnNames));

                    foreach (DataGridViewRow row in dgvCategory.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string[] cells = new string[dgvCategory.Columns.Count];
                            for (int i = 0; i < dgvCategory.Columns.Count; i++)
                            {
                                var value = row.Cells[i].Value;
                                string cellText = value != null ? value.ToString() : "";
                                if (cellText.Contains(","))
                                    cellText = "\"" + cellText + "\"";
                                cells[i] = cellText;
                            }
                            sb.AppendLine(string.Join(",", cells));
                        }
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất dữ liệu thất bại: " + ex.Message);
                }
            }
        }
    }
}
