using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClassLibrary.Models
{
    class Customer
    {
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
    }
}
