using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Logic
{
    class CustomerRepository : ICustomerContext
    {
        private ICustomerContext _context;

        CustomerRepository(ICustomerContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public void AddCustomer(Customer customer)
        {
            _context.AddCustomer(customer);
        }

        /// <inheritdoc />
        public void DeleteCustomer(Customer customer)
        {
            _context.DeleteCustomer(customer);
        }

        /// <inheritdoc />
        public void AddAdress(Adress adress)
        {
            _context.AddAdress(adress);
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
