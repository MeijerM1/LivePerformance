using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Enums;

namespace PizzeriaClassLibrary.Models
{
    class Order
    {
        public int ID { get; set; }
        public DateTime TimeOfPlacement { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public Customer Buyer{ get; set; }
        public List<Product> Products { get; set; }
        public List<Pizza> Pizzas { get; set; }

        /// <inheritdoc />
        public Order(int id, DateTime timeOfPlacement, DeliveryMethod deliveryMethod, Customer buyer, List<Product> products, List<Pizza> pizzas)
        {
            ID = id;
            TimeOfPlacement = timeOfPlacement;
            DeliveryMethod = deliveryMethod;
            Buyer = buyer;
            Products = products;
            Pizzas = pizzas;
        }

        /// <inheritdoc />
        public Order(DateTime timeOfPlacement, DeliveryMethod deliveryMethod, Customer buyer, List<Product> products, List<Pizza> pizzas)
        {
            TimeOfPlacement = timeOfPlacement;
            DeliveryMethod = deliveryMethod;
            Buyer = buyer;
            Products = products;
            Pizzas = pizzas;
        }

        /// <inheritdoc />
        public Order(DateTime timeOfPlacement, DeliveryMethod deliveryMethod, Customer buyer)
        {
            TimeOfPlacement = timeOfPlacement;
            DeliveryMethod = deliveryMethod;
            Buyer = buyer;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddPizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void RemovePizza(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePrice()
        {
            throw new NotImplementedException();
        }

        public bool ExportTicket()
        {
            throw new NotImplementedException();
        }
    }
}
