using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Interfaces
{
    public interface IOrderContext
    {
        void AddOrder(Order order);

        void DeleteOrder(Order order);

        void UpdateOrder(Order order);

        List<Order> GetAllOrders();

        Order GetOrderById(int id);
    }
}
