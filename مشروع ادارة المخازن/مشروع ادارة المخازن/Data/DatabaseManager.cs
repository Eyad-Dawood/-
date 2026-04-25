using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.Sqlite;
using InventoryManagement.Models;

namespace InventoryManagement.Data
{
    public class DatabaseManager
    {
        private static readonly string ConnectionString =
            "Data Source=inventory.db";

        public static void InitializeDatabase()
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                string createProducts = @"
                    CREATE TABLE IF NOT EXISTS Products (
                        Product_ID      TEXT PRIMARY KEY,
                        Product_Name    TEXT NOT NULL,
                        Quantity        INTEGER NOT NULL DEFAULT 0,
                        Minimum_Limit   INTEGER NOT NULL DEFAULT 5,
                        Price           REAL    NOT NULL DEFAULT 0
                    );";
                string createSales = @"
                    CREATE TABLE IF NOT EXISTS Sales (
                        Sale_ID         INTEGER PRIMARY KEY AUTOINCREMENT,
                        Sale_Date       TEXT    NOT NULL,
                        Total_Amount    REAL    NOT NULL
                    );";
                string createSaleItems = @"
                    CREATE TABLE IF NOT EXISTS SaleItems (
                        Item_ID         INTEGER PRIMARY KEY AUTOINCREMENT,
                        Sale_ID         INTEGER NOT NULL,
                        Product_ID      TEXT    NOT NULL,
                        Quantity        INTEGER NOT NULL,
                        Unit_Price      REAL    NOT NULL
                    );";
                new SqliteCommand(createProducts, conn).ExecuteNonQuery();
                new SqliteCommand(createSales, conn).ExecuteNonQuery();
                new SqliteCommand(createSaleItems, conn).ExecuteNonQuery();
            }
        }

        public static List<Product> GetAllProducts()
        {
            var list = new List<Product>();
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT * FROM Products ORDER BY Product_Name", conn);
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        list.Add(ReadProduct(reader));
            }
            return list;
        }

        public static Product GetProductById(string id)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand("SELECT * FROM Products WHERE Product_ID = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read()) return ReadProduct(reader);
            }
            return null;
        }

        public static bool AddProduct(Product p)
        {
            try
            {
                using (var conn = new SqliteConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqliteCommand(@"
                        INSERT INTO Products (Product_ID, Product_Name, Quantity, Minimum_Limit, Price)
                        VALUES (@id, @name, @qty, @min, @price)", conn);
                    cmd.Parameters.AddWithValue("@id", p.Product_ID);
                    cmd.Parameters.AddWithValue("@name", p.Product_Name);
                    cmd.Parameters.AddWithValue("@qty", p.Quantity);
                    cmd.Parameters.AddWithValue("@min", p.Minimum_Limit);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        public static bool UpdateProduct(Product p)
        {
            try
            {
                using (var conn = new SqliteConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqliteCommand(@"
                        UPDATE Products
                        SET Product_Name  = @name,
                            Quantity      = @qty,
                            Minimum_Limit = @min,
                            Price         = @price
                        WHERE Product_ID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", p.Product_ID);
                    cmd.Parameters.AddWithValue("@name", p.Product_Name);
                    cmd.Parameters.AddWithValue("@qty", p.Quantity);
                    cmd.Parameters.AddWithValue("@min", p.Minimum_Limit);
                    cmd.Parameters.AddWithValue("@price", p.Price);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        public static bool DeleteProduct(string id)
        {
            try
            {
                using (var conn = new SqliteConnection(ConnectionString))
                {
                    conn.Open();
                    var cmd = new SqliteCommand("DELETE FROM Products WHERE Product_ID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch { return false; }
        }

        public static List<Product> GetLowStockProducts()
        {
            var list = new List<Product>();
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand(
                    "SELECT * FROM Products WHERE Quantity <= Minimum_Limit ORDER BY Quantity", conn);
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        list.Add(ReadProduct(reader));
            }
            return list;
        }

        public static bool SaveSale(List<SaleItem> items, decimal total)
        {
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        var saleCmd = new SqliteCommand(@"
                            INSERT INTO Sales (Sale_Date, Total_Amount)
                            VALUES (@date, @total);
                            SELECT last_insert_rowid();", conn, tx);
                        saleCmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        saleCmd.Parameters.AddWithValue("@total", total);
                        long saleId = (long)saleCmd.ExecuteScalar();

                        foreach (var item in items)
                        {
                            var itemCmd = new SqliteCommand(@"
                                INSERT INTO SaleItems (Sale_ID, Product_ID, Quantity, Unit_Price)
                                VALUES (@sid, @pid, @qty, @price)", conn, tx);
                            itemCmd.Parameters.AddWithValue("@sid", saleId);
                            itemCmd.Parameters.AddWithValue("@pid", item.Product_ID);
                            itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            itemCmd.Parameters.AddWithValue("@price", item.UnitPrice);
                            itemCmd.ExecuteNonQuery();

                            var deductCmd = new SqliteCommand(@"
                                UPDATE Products SET Quantity = Quantity - @qty
                                WHERE Product_ID = @pid", conn, tx);
                            deductCmd.Parameters.AddWithValue("@qty", item.Quantity);
                            deductCmd.Parameters.AddWithValue("@pid", item.Product_ID);
                            deductCmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                        return true;
                    }
                    catch { tx.Rollback(); return false; }
                }
            }
        }

        public static DataTable GetSalesReport(DateTime from, DateTime to)
        {
            var dt = new DataTable();
            using (var conn = new SqliteConnection(ConnectionString))
            {
                conn.Open();
                var cmd = new SqliteCommand(@"
                    SELECT s.Sale_ID        AS 'رقم الفاتورة',
                           s.Sale_Date      AS 'التاريخ',
                           p.Product_Name   AS 'السلعة',
                           si.Quantity      AS 'الكمية',
                           si.Unit_Price    AS 'سعر الوحدة',
                           (si.Quantity * si.Unit_Price) AS 'الإجمالي'
                    FROM   Sales s
                    JOIN   SaleItems si ON s.Sale_ID     = si.Sale_ID
                    JOIN   Products  p  ON si.Product_ID = p.Product_ID
                    WHERE  s.Sale_Date BETWEEN @from AND @to
                    ORDER  BY s.Sale_Date DESC", conn);
                cmd.Parameters.AddWithValue("@from", from.ToString("yyyy-MM-dd 00:00:00"));
                cmd.Parameters.AddWithValue("@to", to.ToString("yyyy-MM-dd 23:59:59"));

                using (var reader = cmd.ExecuteReader())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                        dt.Columns.Add(reader.GetName(i));
                    while (reader.Read())
                    {
                        var row = dt.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++)
                            row[i] = reader[i];
                        dt.Rows.Add(row);
                    }
                }
            }
            return dt;
        }

        private static Product ReadProduct(SqliteDataReader r) => new Product
        {
            Product_ID = r["Product_ID"].ToString(),
            Product_Name = r["Product_Name"].ToString(),
            Quantity = Convert.ToInt32(r["Quantity"]),
            Minimum_Limit = Convert.ToInt32(r["Minimum_Limit"]),
            Price = Convert.ToDecimal(r["Price"])
        };
    }
}