using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Data
{
    public class PizzacrustMsSqlContext : IPizzacrustContext
    {
        private readonly string _connectionString;

        public PizzacrustMsSqlContext()
        {
            Connection connection = new Connection();
            _connectionString = connection.ConnectionString;
        }

        /// <inheritdoc />
        public void AddPizzacrust(Pizzacrust crust)
        {
            var QueryString =
                "INSERT INTO Pizzacrust (Desciption, PricePerCentimeter) VALUES (@desciption, @pricePerCentimeter)";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("desciption", crust.Description);
                    cmd.Parameters.AddWithValue("pricePerCentimeter", crust.PricePerCentimeter);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <inheritdoc />
        public List<Pizzacrust> GetAllPizzaCrusts()
        {
            var QueryString = "SELECT * FROM Pizzacrust";
            var result = new List<Pizzacrust>();
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            result.Add(CreateCrustFromReader(reader));
                    }
                }
            }
            return result;
        }

        /// <inheritdoc />
        public Pizzacrust GetPizzacrustById(int id)
        {
            var QueryString = "SELECT * FROM Pizzacrust WHERE ID= @id";
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    command.Parameters.AddWithValue("id", id);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            return CreateCrustFromReader(reader);
                    }
                }
            }
            return null;
        }

        private Pizzacrust CreateCrustFromReader(SqlDataReader reader)
        {
            return new Pizzacrust(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Desciption"]),
                Convert.ToDecimal(reader["PricePerCentimeter"]));
        }
            
    }
}
