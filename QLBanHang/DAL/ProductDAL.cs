using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace QLBanHang.DAL
{
    public class ProductDAL
    {
        /// <summary>
        /// Lấy tất cả sản phẩm
        /// </summary>
        public List<ProductDTO> GetAll()
        {
            var list = new List<ProductDTO>();
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT * FROM Products");

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new ProductDTO
                    {
                        ProductID = dr["ProductID"].ToString() ?? "",
                        Name = dr["Name"].ToString() ?? "",
                        CategoryID = Convert.ToInt32(dr["CategoryID"]),
                        Price = Convert.ToDecimal(dr["Price"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        IsActive = Convert.ToInt32(dr["IsActive"])
                    });
                }
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.GetAll", ex);
            }
            return list;
        }

        /// <summary>
        /// Tìm kiếm sản phẩm theo tên
        /// </summary>
        public List<ProductDTO> SearchByName(string keyword)
        {
            var list = new List<ProductDTO>();
            try
            {
                string kw = "%" + keyword + "%";
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT * FROM Products WHERE Name LIKE @kw",
                    new SQLiteParameter("@kw", kw)
                );

                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new ProductDTO
                    {
                        ProductID = dr["ProductID"].ToString() ?? "",
                        Name = dr["Name"].ToString() ?? "",
                        CategoryID = Convert.ToInt32(dr["CategoryID"]),
                        Price = Convert.ToDecimal(dr["Price"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        IsActive = Convert.ToInt32(dr["IsActive"])
                    });
                }
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.SearchByName", ex);
            }
            return list;
        }

        /// <summary>
        /// Kiểm tra sản phẩm đã tồn tại chưa
        /// </summary>
        public bool Exists(string productId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT 1 FROM Products WHERE ProductID = @id LIMIT 1;",
                    new SQLiteParameter("@id", productId)
                );
                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.Exists", ex);
                return false;
            }
        }

        /// <summary>
        /// Thêm sản phẩm mới
        /// </summary>
        public bool Insert(ProductDTO product)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                string query =
                    "INSERT INTO Products(ProductID, Name, CategoryID, Price, Stock, IsActive) " +
                    "VALUES(@id, @name, @catId, @price, @stock, @isActive);";

                sql.ExecuteQuery(query,
                    new SQLiteParameter("@id", product.ProductID),
                    new SQLiteParameter("@name", product.Name),
                    new SQLiteParameter("@catId", product.CategoryID),
                    new SQLiteParameter("@price", product.Price),
                    new SQLiteParameter("@stock", product.Stock),
                    new SQLiteParameter("@isActive", product.IsActive)
                );
                return true;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.Insert", ex);
                return false;
            }
        }

        /// <summary>
        /// Cập nhật sản phẩm
        /// </summary>
        public bool Update(ProductDTO product)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                string query =
                    "UPDATE Products SET Name=@name, CategoryID=@catId, Price=@price, " +
                    "Stock=@stock, IsActive=@isActive WHERE ProductID=@id;";

                sql.ExecuteQuery(query,
                    new SQLiteParameter("@name", product.Name),
                    new SQLiteParameter("@catId", product.CategoryID),
                    new SQLiteParameter("@price", product.Price),
                    new SQLiteParameter("@stock", product.Stock),
                    new SQLiteParameter("@isActive", product.IsActive),
                    new SQLiteParameter("@id", product.ProductID)
                );
                return true;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.Update", ex);
                return false;
            }
        }

        /// <summary>
        /// Xóa sản phẩm (xóa thật)
        /// </summary>
        public bool Delete(string productId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery(
                    "DELETE FROM Products WHERE ProductID = @id;",
                    new SQLiteParameter("@id", productId)
                );
                return true;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.Delete", ex);
                return false;
            }
        }

        /// <summary>
        /// Chuyển sản phẩm sang trạng thái ngừng bán (IsActive = 0)
        /// </summary>
        public bool Deactivate(string productId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery(
                    "UPDATE Products SET IsActive = 0 WHERE ProductID = @id;",
                    new SQLiteParameter("@id", productId)
                );
                return true;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.Deactivate", ex);
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra sản phẩm đã được sử dụng trong đơn hàng chưa
        /// </summary>
        public bool IsUsedInOrders(string productId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT 1 FROM OrderDetails WHERE ProductID = @id LIMIT 1;",
                    new SQLiteParameter("@id", productId)
                );
                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.IsUsedInOrders", ex);
                return false;
            }
        }

        /// <summary>
        /// Đếm số sản phẩm đang bán
        /// </summary>
        public int CountActive()
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT COUNT(*) AS Total FROM Products WHERE IsActive = 1");
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["Total"]);
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.CountActive", ex);
            }
            return 0;
        }

        /// <summary>
        /// Lấy tên danh mục theo ID
        /// </summary>
        public string GetCategoryName(int categoryId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT Name FROM Categories WHERE CategoryID = @id",
                    new SQLiteParameter("@id", categoryId)
                );
                if (dt.Rows.Count > 0)
                    return dt.Rows[0]["Name"].ToString() ?? "";
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.GetCategoryName", ex);
            }
            return "";
        }

        /// <summary>
        /// Lấy ProductID lớn nhất theo prefix
        /// </summary>
        public string? GetMaxProductIdByPrefix(string prefix)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT ProductID FROM Products WHERE ProductID LIKE @prefix ORDER BY ProductID DESC LIMIT 1",
                    new SQLiteParameter("@prefix", prefix + "%")
                );
                if (dt.Rows.Count > 0)
                    return dt.Rows[0]["ProductID"].ToString();
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.GetMaxProductIdByPrefix", ex);
            }
            return null;
        }

        /// <summary>
        /// Lấy giá và tồn kho của sản phẩm đang bán
        /// </summary>
        public ProductDTO? GetActiveProductInfo(string productId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT Price, Stock FROM Products WHERE ProductId = @id AND IsActive = 1 LIMIT 1;",
                    new SQLiteParameter("@id", productId)
                );
                if (dt.Rows.Count > 0)
                {
                    return new ProductDTO
                    {
                        ProductID = productId,
                        Price = Convert.ToDecimal(dt.Rows[0]["Price"]),
                        Stock = Convert.ToInt32(dt.Rows[0]["Stock"])
                    };
                }
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.GetActiveProductInfo", ex);
            }
            return null;
        }

        /// <summary>
        /// Lấy danh sách sản phẩm đang bán (cho ComboBox bán hàng)
        /// </summary>
        public DataTable GetActiveProducts(int categoryId = 0)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                if (categoryId == 0)
                {
                    return sql.ExecuteQuery("SELECT ProductId, Name FROM Products WHERE IsActive = 1");
                }
                else
                {
                    return sql.ExecuteQuery(
                        "SELECT ProductId, Name FROM Products WHERE IsActive = 1 AND CategoryId = @catId",
                        new SQLiteParameter("@catId", categoryId)
                    );
                }
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.GetActiveProducts", ex);
                return new DataTable();
            }
        }

        /// <summary>
        /// Trừ tồn kho khi bán hàng
        /// </summary>
        public bool ReduceStock(string productId, int quantity)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery(
                    "UPDATE Products SET Stock = Stock - @qty WHERE ProductId = @id;",
                    new SQLiteParameter("@qty", quantity),
                    new SQLiteParameter("@id", productId)
                );
                return true;
            }
            catch (Exception ex)
            {
                Utils.Log("ProductDAL.ReduceStock", ex);
                return false;
            }
        }
    }
}
