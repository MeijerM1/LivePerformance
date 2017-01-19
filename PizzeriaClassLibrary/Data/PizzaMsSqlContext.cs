using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Enums;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Data
{
    public class PizzaMsSqlContext : IPizzaContext
    {
        private readonly string _connectionString;

        public PizzaMsSqlContext()
        {
            Connection connection = new Connection();
            _connectionString = connection.ConnectionString;
        }

        /// <inheritdoc />
        public void AddPizza(Pizza pizza)
        {
            int formatID = AddFormat(pizza);
            int pizzaID = 0;

            var QueryString = "INSERT INTO Pizza (Name, IsStandard, PizzacrustID, FormatID) VALUES (@name, @isStandard, @pizzacrustID, @formatID)";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("name", pizza.Name);
                    cmd.Parameters.AddWithValue("isStandard",Convert.ToInt32( pizza.IsStandard));
                    cmd.Parameters.AddWithValue("pizzacrustID", pizza.Crust.ID);
                    cmd.Parameters.AddWithValue("formatID", formatID);
                    cmd.ExecuteNonQuery();
                }
            }

            var QueryString1 = "SELECT MAX(ID) as ID FROM Pizza";
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString1, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            pizzaID = Convert.ToInt32(reader["ID"]);
                    }
                }
            }

            AddToppings(pizza,  pizzaID);
        }

        private int AddFormat(Pizza pizza)
        {
            var QueryString = "INSERT INTO Format (Shape, Measure_1, Measure_2, Measure_3) VALUES (@shape, @1, @2, @3)";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("shape", pizza.Shape);
                    cmd.Parameters.AddWithValue("1", pizza.Size1);
                    cmd.Parameters.AddWithValue("2", pizza.Size2);
                    cmd.Parameters.AddWithValue("3", pizza.Size3);
                    cmd.ExecuteNonQuery();
                }

            }


            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("GetLastFormat", conn);

                cmd.CommandType = CommandType.StoredProcedure;             // execute the command
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // iterate through results, printing each to console
                    while (rdr.Read())
                    {
                        return Convert.ToInt32(rdr["ID"]);
                    }
                }
            }
            return -1;
        }


        private void AddToppings(Pizza pizza, int id)
        {
            foreach (var pizzaProduct in pizza.Products)
            {
                var QueryString = "INSERT INTO Pizza_Topping (PizzaID, ProductID) VALUES (@pizzaID, @productID)";
                using (var conn = new SqlConnection(_connectionString))
                {

                    using (var cmd = new SqlCommand(QueryString, conn))
                    {
                        conn.Open();

                        cmd.Parameters.AddWithValue("pizzaID", id);
                        cmd.Parameters.AddWithValue("@productID", pizzaProduct.ID);
                        cmd.ExecuteNonQuery();

                    }
                }
            }
        }

        /// <inheritdoc />
        public void RemovePizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void UpdatePizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public List<Pizza> GetAllPizzas()
        {
            var QueryString = "SELECT p.ID, p.Name, p.IsStandard, pc.ID as crustID, pc.Desciption, pc.PricePerCentimeter, f.ID as formatID, f.Shape, f.Measure_1, f.Measure_2, f.Measure_3 FROM Pizza p JOIN Pizzacrust pc ON pc.ID = p.PizzacrustID JOIN Format f on f.ID = p.FormatID";
            var result = new List<Pizza>();
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            result.Add(CreatePizzaFromReader(reader));
                    }
                }
            }
            return result;
        }

        /// <inheritdoc />
        public Pizza GetPizzaById(int id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void PutInOven(Pizza pizza, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        private List<Product> GetToppingByPizza(int id )
        {

            var QueryString = "SELECT p.ID, p.Name, p.Description, p.PurchasePrice, p.SellPrice, p.ProductCategory FROM Product p JOIN Pizza_Topping pt ON pt.ProductID = p.ID WHERE pt.PizzaID = @id";
            var result = new List<Product>();
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            result.Add(CreateProductFromReader(reader));
                    }
                }
            }
            return result;
        }

        private Pizza CreatePizzaFromReader(SqlDataReader reader)
        {
            var products = GetToppingByPizza(Convert.ToInt32(reader["ID"]));

            Pizzacrust crust = new Pizzacrust(
                Convert.ToInt32(reader["crustID"]),
                Convert.ToString(reader["Desciption"]),
                Convert.ToDecimal(reader["PricePerCentimeter"]));

            return new Pizza(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Name"]),
                Convert.ToBoolean(reader["IsStandard"]),
                DateTime.Now,
                Convert.ToString(reader["Shape"]),
                Convert.ToInt32(reader["Measure_1"]),
                Convert.ToInt32(reader["Measure_2"]),
                Convert.ToInt32(reader["Measure_3"]),                
                products,
                crust);
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
