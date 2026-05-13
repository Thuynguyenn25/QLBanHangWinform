using QLBanHang.DAL;
using QLBanHang.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBanHang.BLL
{
    public class CategoryBLL
    {
        private readonly CategoryDAL _dal = new CategoryDAL();

        public List<CategoryDTO> GetAll() => _dal.GetAll();

        public DataTable GetAllForComboBox() => _dal.GetAllForComboBox();

        public DataTable GetAllForSaleComboBox() => _dal.GetAllForSaleComboBox();

        public List<CategoryDTO> Search(string keyword) => _dal.Search(keyword);

        public (bool success, string message) Add(CategoryDTO category)
        {
            if (_dal.ExistsByName(category.Name))
                return (false, "Danh mục đã tồn tại");

            bool ok = _dal.Insert(category);
            return ok ? (true, "Đã thêm danh mục thành công!") : (false, "Thêm danh mục thất bại!");
        }

        public (bool success, string message) Update(CategoryDTO category)
        {
            bool ok = _dal.Update(category);
            return ok ? (true, "Đã cập nhật thành công!") : (false, "Cập nhật danh mục thất bại!");
        }

        public (bool success, string message) Delete(int categoryId)
        {
            if (_dal.HasProducts(categoryId))
                return (false, "Không thể xóa! Danh mục này vẫn còn sản phẩm.");

            bool ok = _dal.Delete(categoryId);
            return ok ? (true, "Đã xóa danh mục.") : (false, "Xóa danh mục thất bại!");
        }

        public (bool canDelete, string message) CanDelete(int categoryId)
        {
            if (_dal.HasProducts(categoryId))
                return (false, $"Không thể xóa danh mục ID={categoryId} vì vẫn còn sản phẩm.");
            return (true, "");
        }
    }
}
