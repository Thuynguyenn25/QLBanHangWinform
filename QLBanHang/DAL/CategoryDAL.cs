using QLBanHang.DTO;
using QLBanHang.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace QLBanHang.DAL
{
    public class CategoryDAL
    {
        public List<CategoryDTO> GetAll()
        {
            var list = new List<CategoryDTO>();
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT * FROM Categories");
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new CategoryDTO
                    {
                        CategoryID = Convert.ToInt32(dr["CategoryID"]),
                        Name = dr["Name"].ToString() ?? "",
                        Description = dr["Description"].ToString() ?? ""
                    });
                }
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.GetAll", ex); }
            return list;
        }

        public DataTable GetAllForComboBox()
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                return sql.ExecuteQuery("SELECT CategoryID, Name FROM Categories ORDER BY Name");
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.GetAllForComboBox", ex); return new DataTable(); }
        }

        public DataTable GetAllForSaleComboBox()
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT CategoryID, Name FROM Categories");
                DataRow allRow = dt.NewRow();
                allRow["CategoryID"] = 0;
                allRow["Name"] = "Tất cả";
                dt.Rows.InsertAt(allRow, 0);
                return dt;
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.GetAllForSaleComboBox", ex); return new DataTable(); }
        }

        public List<CategoryDTO> Search(string keyword)
        {
            var list = new List<CategoryDTO>();
            try
            {
                string kw = "%" + keyword + "%";
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery(
                    "SELECT * FROM Categories WHERE Name LIKE @kw OR Description LIKE @kw",
                    new SQLiteParameter("@kw", kw));
                foreach (DataRow dr in dt.Rows)
                {
                    list.Add(new CategoryDTO
                    {
                        CategoryID = Convert.ToInt32(dr["CategoryID"]),
                        Name = dr["Name"].ToString() ?? "",
                        Description = dr["Description"].ToString() ?? ""
                    });
                }
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.Search", ex); }
            return list;
        }

        public bool ExistsByName(string name)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT * FROM Categories WHERE Name=@name", new SQLiteParameter("@name", name));
                return dt.Rows.Count > 0;
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.ExistsByName", ex); return false; }
        }

        public bool Insert(CategoryDTO category)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery("INSERT INTO Categories(Name, Description) VALUES (@name, @desc)",
                    new SQLiteParameter("@name", category.Name), new SQLiteParameter("@desc", category.Description));
                return true;
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.Insert", ex); return false; }
        }

        public bool Update(CategoryDTO category)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery("UPDATE Categories SET Name=@name, Description=@desc WHERE CategoryID=@id",
                    new SQLiteParameter("@name", category.Name), new SQLiteParameter("@desc", category.Description),
                    new SQLiteParameter("@id", category.CategoryID));
                return true;
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.Update", ex); return false; }
        }

        public bool Delete(int categoryId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                sql.ExecuteQuery("DELETE FROM Categories WHERE CategoryID = @id", new SQLiteParameter("@id", categoryId));
                return true;
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.Delete", ex); return false; }
        }

        public bool HasProducts(int categoryId)
        {
            try
            {
                var sql = new Data.SQLiteUtils();
                DataTable dt = sql.ExecuteQuery("SELECT 1 FROM Products WHERE CategoryID = @id LIMIT 1;", new SQLiteParameter("@id", categoryId));
                return dt.Rows.Count > 0;
            }
            catch (Exception ex) { Utils.Log("CategoryDAL.HasProducts", ex); return true; }
        }
    }
}
