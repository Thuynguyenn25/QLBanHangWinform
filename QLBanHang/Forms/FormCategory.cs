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
        }

        private void btnAddCate_Click(object sender, EventArgs e)
        {
            try
            {
                string IDCategory = txtIDCategory.Text;
                string name = txtName.Text;
                string description = txtDescription.Text;

                string query = $"INSERT INTO Categories(Name, Description)" +
                    $" VALUES('{name}','{description}')";
                SQLiteUtils sQL = new SQLiteUtils();

                DataTable dtCheck = sQL.ExecuteQuery($"SELECT * FROM Categories WHERE Name='{name}'");
                if (dtCheck.Rows.Count > 0)
                {
                    MessageBox.Show("Danh mục này đã tồn tại. Vui lòng thêm cái khác");
                    return;
                }

                sQL.ExecuteQuery(query);

                MessageBox.Show("Đã thêm danh mục sản phẩm mới!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Utils.Log("Add Category: ", ex);
            }

            LoadCategory();
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
        private void CheckInput()
        {

        }

        private void txtSearchCate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCate_Click(object sender, EventArgs e)
        {

        }

        private void txtName_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnClearCate_Click(object sender, EventArgs e)
        {
            txtIDCategory.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }
    }
}
