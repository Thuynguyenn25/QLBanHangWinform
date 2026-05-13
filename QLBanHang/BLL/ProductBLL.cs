using QLBanHang.DAL;
using QLBanHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QLBanHang.BLL
{
    public class ProductBLL
    {
        private readonly ProductDAL _dal = new ProductDAL();

        public List<ProductDTO> GetAll() => _dal.GetAll();

        public List<ProductDTO> Search(string keyword) => _dal.SearchByName(keyword);

        public int CountActive() => _dal.CountActive();

        public DataTable GetActiveProducts(int categoryId = 0) => _dal.GetActiveProducts(categoryId);

        public ProductDTO? GetActiveProductInfo(string productId) => _dal.GetActiveProductInfo(productId);

        public int GetStock(string productId)
        {
            var info = _dal.GetActiveProductInfo(productId);
            return info?.Stock ?? 0;
        }

        public decimal GetPrice(string productId)
        {
            var info = _dal.GetActiveProductInfo(productId);
            return info?.Price ?? 0;
        }

        /// <summary>
        /// Sinh mã sản phẩm tự động dựa trên CategoryID
        /// </summary>
        public string GenerateProductID(int categoryId)
        {
            string cateName = _dal.GetCategoryName(categoryId);
            if (string.IsNullOrEmpty(cateName)) return "";

            string[] words = cateName.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string prefix = words.Length >= 2
                ? $"{char.ToUpper(words[0][0])}{char.ToUpper(words[1][0])}"
                : $"{char.ToUpper(words[0][0])}X";

            string? lastId = _dal.GetMaxProductIdByPrefix(prefix);
            int nextNumber = 1;
            if (lastId != null && lastId.Length > 2)
            {
                string numPart = lastId.Substring(2);
                if (int.TryParse(numPart, out int n))
                    nextNumber = n + 1;
            }
            return $"{prefix}{nextNumber:00}";
        }

        /// <summary>
        /// Thêm sản phẩm mới, trả về (thành công, thông báo)
        /// </summary>
        public (bool success, string message) Add(ProductDTO product)
        {
            if (_dal.Exists(product.ProductID))
                return (false, "Mã sản phẩm đã tồn tại. Thử lại!");

            bool ok = _dal.Insert(product);
            return ok
                ? (true, $"Đã thêm sản phẩm thành công: {product.ProductID}")
                : (false, "Thêm sản phẩm thất bại!");
        }

        /// <summary>
        /// Cập nhật sản phẩm
        /// </summary>
        public (bool success, string message) Update(ProductDTO product)
        {
            bool ok = _dal.Update(product);
            return ok ? (true, "Đã sửa thành công") : (false, "Cập nhật sản phẩm thất bại!");
        }

        /// <summary>
        /// Xóa sản phẩm: nếu đã có trong đơn hàng thì chuyển ngừng bán
        /// </summary>
        public (bool success, string message) Delete(string productId)
        {
            if (_dal.IsUsedInOrders(productId))
            {
                _dal.Deactivate(productId);
                return (true, "Sản phẩm đã có trong đơn hàng nên không thể xóa. Đã chuyển sang Ngừng bán.");
            }
            else
            {
                bool ok = _dal.Delete(productId);
                return ok ? (true, "Đã xóa sản phẩm.") : (false, "Xóa sản phẩm thất bại!");
            }
        }

        /// <summary>
        /// Xóa nhiều sản phẩm, trả về (đã xóa, đã ngừng bán)
        /// </summary>
        public (int deleted, int disabled) DeleteMultiple(List<string> productIds)
        {
            int deleted = 0, disabled = 0;
            foreach (var id in productIds)
            {
                if (_dal.IsUsedInOrders(id))
                {
                    _dal.Deactivate(id);
                    disabled++;
                }
                else
                {
                    _dal.Delete(id);
                    deleted++;
                }
            }
            return (deleted, disabled);
        }

        /// <summary>
        /// Import sản phẩm từ dữ liệu CSV đã parse
        /// </summary>
        public (int inserted, int updated, int skipped) ImportProducts(List<ProductDTO> products)
        {
            int inserted = 0, updated = 0, skipped = 0;
            foreach (var p in products)
            {
                if (string.IsNullOrWhiteSpace(p.ProductID) || string.IsNullOrWhiteSpace(p.Name))
                {
                    skipped++;
                    continue;
                }
                if (_dal.Exists(p.ProductID))
                {
                    _dal.Update(p);
                    updated++;
                }
                else
                {
                    _dal.Insert(p);
                    inserted++;
                }
            }
            return (inserted, updated, skipped);
        }

        public bool ReduceStock(string productId, int quantity) => _dal.ReduceStock(productId, quantity);
    }
}
