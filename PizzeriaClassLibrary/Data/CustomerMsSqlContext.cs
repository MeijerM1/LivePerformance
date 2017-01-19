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
    public class CustomerMsSqlContext : ICustomerContext
    {
        private readonly string _connectionString;

        public CustomerMsSqlContext()
        {
            Connection connection = new Connection();
            _connectionString = connection.ConnectionString;
        }

        /// <inheritdoc />
        public void AddCustomer(Customer customer)
        {
            int adressId = AddAdress(customer.Adress);

            var QueryString = "INSERT INTO Customer (LastName, FirstName, Email, Phonenumber, AdressID) VALUES (@lastName, @firstName, @email, @phoneNumber, @adressId)";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("lastName", customer.LastName);
                    cmd.Parameters.AddWithValue("firstName", customer.FirstName);
                    cmd.Parameters.AddWithValue("email", customer.Email);
                    cmd.Parameters.AddWithValue("phoneNumber", customer.Phonenumber);
                    cmd.Parameters.AddWithValue("adressId", adressId);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /// <inheritdoc />
        public void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public int AddAdress(Adress adress)
        {
            var QueryString = "INSERT INTO Adress (Streetname, HouseNumber, Postalcode) VALUES (@streetName, @houseNumber, @postalCode)";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("streetName", adress.Streetname);
                    cmd.Parameters.AddWithValue("houseNumber", adress.HouseNumber);
                    cmd.Parameters.AddWithValue("postalCode", adress.Postalcode);
                    cmd.ExecuteNonQuery();
                }
            }

            var IdqueryString = "SELECT MAX(ID) as ID FROM Adress";
            using (var conn = new SqlConnection(_connectionString))
            {

                using (var cmd1 = new SqlCommand(IdqueryString, conn))
                {
                    conn.Open();
                    using (var reader = cmd1.ExecuteReader())
                    {
                        while (reader.Read())
                            return Convert.ToInt32(reader["ID"]);
                    }
                }
            }
            return -1;
        }

        /// <inheritdoc />
        public List<Customer> GetAllCustomers()
        {
            var QueryString = "SELECT c.ID, c.LastName, c.FirstName, c.Email, c.PhoneNumber, a.ID, a.Streetname, a.HouseNumber, a.PostalCode FROM Customer c JOIN Adress a on a.ID = c.AdressID ";
            var result = new List<Customer>();
            using (var conn = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand(QueryString, conn))
                {
                    conn.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            result.Add(CreateCustomerFromReader(reader));
                    }
                }
            }
            return result;
        }

        /// <inheritdoc />
        public Customer GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }
        

        private Customer CreateCustomerFromReader(SqlDataReader reader)
        {
            Adress adress = new Adress(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Streetname"]),
                Convert.ToInt32(reader["HouseNumber"]),
                Convert.ToString(reader["PostalCode"]));

            return new Customer(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["LastName"]),
                Convert.ToString(reader["FirstName"]),
                Convert.ToString(reader["Email"]),
                Convert.ToInt32(reader["PhoneNumber"]),
                adress);
        }
    }
}
