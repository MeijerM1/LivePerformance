using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Logic
{
    class OrderRepository : IOrderContext
    {

        private IOrderContext _context;

        public OrderRepository(IOrderContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public void AddOrder(Order order)
        {
            _context.AddOrder(order);
        }

        /// <inheritdoc />
        public void DeleteOrder(Order order)
        {
            _context.DeleteOrder(order);
        }

        /// <inheritdoc />
        public void UpdateOrder(Order order)
        {
            _context.UpdateOrder(order);
        }

        /// <inheritdoc />
        public List<Order> GetAllOrders()
        {
            return _context.GetAllOrders();
        }

        /// <inheritdoc />
        public Order GetOrderById(int id)
        {
            return _context.GetOrderById(id);
        }
    }
}
