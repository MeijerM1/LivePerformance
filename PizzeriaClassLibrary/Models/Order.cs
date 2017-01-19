using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Enums;

namespace PizzeriaClassLibrary.Models
{
    public class Order
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
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public void AddPizza(Pizza pizza)
        {
           Pizzas.Add(pizza);
        }

        public void RemovePizza(Pizza pizza)
        {
            Pizzas.Remove(pizza);
        }

        public decimal CalculatePrice()
        {
            decimal pizzaPrice = 0;

            foreach (var pizza in Pizzas)
            {
                pizzaPrice += pizza.CalculateTotalPrice();
            }

            decimal productPrice = 0;
            foreach (var product in Products)
            {
                productPrice += product.SellPrice;
            }

            return (pizzaPrice + (productPrice/100));
        }

        public bool ExportTicket(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine("Pizzeria La Crosta Isapore");
                sw.WriteLine("Klantbon voor : " + this.Buyer.ToString());

                foreach (var pizza in Pizzas)
                {
                    sw.WriteLine(pizza.Name + "    " + pizza.CalculateTotalPrice());
                }

                foreach (var product in Products)
                {
                    sw.WriteLine(product.Name + "    " + product.SellPrice);
                }

                sw.WriteLine("Prijs exclusief BTW: " + ((CalculatePrice() / 106) * 100));
                sw.WriteLine("BTW bedrag: " + ((CalculatePrice() / 106) * 6));
                sw.WriteLine("Te betalen bedrag: " + CalculatePrice());

                return true;
            }
        }
    }
}
