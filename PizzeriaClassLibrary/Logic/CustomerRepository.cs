using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Logic
{
    public class CustomerRepository : ICustomerContext
    {
        private ICustomerContext _context;

        public CustomerRepository(ICustomerContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public void AddCustomer(Customer customer)
        {
            _context.AddCustomer(customer);
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.UpdateCustomer(customer);
        }

        /// <inheritdoc />
        public void DeleteCustomer(Customer customer)
        {
            _context.DeleteCustomer(customer);
        }

        /// <inheritdoc />
        public int AddAdress(Adress adress)
        {
          return  _context.AddAdress(adress);
        }

        /// <inheritdoc />
        public List<Customer> GetAllCustomers()
        {
            return _context.GetAllCustomers();
        }

        /// <inheritdoc />
        public Customer GetCustomerById(int id)
        {
            return _context.GetCustomerById(id);
        }
    }
}
