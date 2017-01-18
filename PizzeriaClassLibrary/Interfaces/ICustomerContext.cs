using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Interfaces
{
    interface ICustomerContext
    {

        void AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        void AddAdress(Adress adress);

        List<Customer> GetAllCustomers();

        Customer GetCustomerById(int id);
    }
}
