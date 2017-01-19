using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Data
{
    public class OrderMsSqlContext : IOrderContext
    {
        private readonly string _connectionString;

        public OrderMsSqlContext()
        {
            Connection connection = new Connection();
            _connectionString = connection.ConnectionString;
        }

        /// <inheritdoc />
        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Order GetOrderById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
