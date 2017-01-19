using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Data;
using PizzeriaClassLibrary.Logic;

namespace PizzeriaClassLibrary.Models
{
    public class Customer
    {
        private CustomerRepository _customerRepo = new CustomerRepository(new CustomerMsSqlContext());

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public int Phonenumber { get; set; }
        public Adress Adress { get; set; }

        /// <inheritdoc />
        public Customer(int id, string lastName, string firstName, string email, int phonenumber, Adress adress)
        {
            ID = id;
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Phonenumber = phonenumber;
            Adress = adress;
        }

        /// <inheritdoc />
        public Customer(string lastName, string firstName, string email, int phonenumber, Adress adress)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
            Phonenumber = phonenumber;
            Adress = adress;
        }

        public void AddToDatabase()
        {
            _customerRepo.AddCustomer(this);
        }

        public void UpdateCustomer()
        {
            _customerRepo.UpdateCustomer(this);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return FirstName + " " +  LastName;
        }
    }
}
