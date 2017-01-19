using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Enums;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Data
{
    public class ProductMsSqlContext : IProductContext
    {
        private readonly string _connectionString;

        public ProductMsSqlContext()
        {
            Connection conn = new Connection();
            _connectionString = conn.ConnectionString;
        }

        /// <inheritdoc />
        public void Addproduct(Product product)
        {
            var QueryString = "INSERT INTO Product (Name, Description, PurchasePrice, SellPrice, ProductCategory) VALUES (@name, @description, @purchasePrice, @sellPrice, @category)";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("name", product.Name);
                    cmd.Parameters.AddWithValue("description", product.Description);
                    cmd.Parameters.AddWithValue("purchasePrice", product.PurchasePrice);
                    cmd.Parameters.AddWithValue("sellPrice", product.SellPrice);
                    cmd.Parameters.AddWithValue("category", product.ProductCategory);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /// <inheritdoc />
        public void RemoveProduct(Product product)
        {
            var QueryString = "DELETE FROM Product WHERE ID = @id";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("id", product.ID);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /// <inheritdoc />
        public void UpdateProduct(Product product)
        {
            var QueryString = "UPDATE Product SET Name=@name, Description=@description, PurchasePrice=@purchasePrice, SellPrice=@sellPrice, ProductCategory=@productCategory WHERE ID=@id";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("name", product.Name);
                    cmd.Parameters.AddWithValue("description", product.Description);
                    cmd.Parameters.AddWithValue("purchasePrice", product.PurchasePrice);
                    cmd.Parameters.AddWithValue("sellPrice", product.SellPrice);
                    cmd.Parameters.AddWithValue("productCategory", product.ProductCategory);
                    cmd.Parameters.AddWithValue("id", product.ID);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /// <inheritdoc />
        public List<Product> GetAllProducts()
        {
            var QueryString = "SELECT * FROM Product";
            var result = new List<Product>();
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            result.Add(CreateProductFromReader(reader));
                    }
                }
            }
            return result;
        }

        /// <inheritdoc />
        public Product GetProductbyId(int id)
        {
            var QueryString = "SELECT * FROM Product WHERE ID=@id";
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                             return (CreateProductFromReader(reader));
                    }
                }
            }
            return null;
        }

        private Product CreateProductFromReader(SqlDataReader reader)
        {
            return new Product(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Name"]),
                Convert.ToString(reader["Description"]),
                Convert.ToDecimal(reader["PurchasePrice"]),
                Convert.ToDecimal(reader["SellPrice"]),
                (ProductCategory)Convert.ToInt32(reader["ProductCategory"]));
        }
    }
}
