using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PizzeriaClassLibrary.Data;
using PizzeriaClassLibrary.Logic;

namespace PizzeriaClassLibrary.Models
{
    public class Pizza
    {
        private PizzaRepository _pizzaRepo = new PizzaRepository(new PizzaMsSqlContext());

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsStandard { get; set; }
        public DateTime PlacemetnInOven { get; set; }
        public string Shape { get; set; }
        public int Size1 { get; set; }
        public int Size2 { get; set; }
        public int Size3 { get; set; }
        public List<Product> Products { get; set; }
        public Pizzacrust Crust { get; set; }

        /// <inheritdoc />
        public Pizza(int id, string name, bool isStandard, DateTime placemetnInOven, string shape, int size1, int size2, int size3, List<Product> products, Pizzacrust crust)
        {
            ID = id;
            Name = name;
            IsStandard = isStandard;
            PlacemetnInOven = placemetnInOven;
            Shape = shape;
            Size1 = size1;
            Size2 = size2;
            Size3 = size3;
            Products = products;
            Crust = crust;
        }

        /// <inheritdoc />
        public Pizza(string name, bool isStandard, DateTime placemetnInOven, string shape, int size1, int size2, int size3, List<Product> products, Pizzacrust crust)
        {
            Name = name;
            IsStandard = isStandard;
            PlacemetnInOven = placemetnInOven;
            Shape = shape;
            Size1 = size1;
            Size2 = size2;
            Size3 = size3;
            Products = products;
            Crust = crust;

        }

        public void AddTopping(Product product)
        {
           Products.Add(product);
        }

        public void RemoveTopping(Product product)
        {
            Products.Remove(product);
        }

        /// <summary>
        /// Calculates the total price in euros.
        /// </summary>
        /// <returns>Returns the total price of the pizza in euros</returns>
        public decimal CalculateTotalPrice()
        {
            var surface = CalculateSurface();

            decimal priceOfIngriedients = 0;
            priceOfIngriedients += Crust.PricePerCentimeter;
            foreach (var product in Products)
            {
                priceOfIngriedients += product.SellPrice;
            }

            return Math.Round((priceOfIngriedients*surface) / 100);
        }

        public decimal CalculateSurface()
        {
            if (Shape == "Round")
            {
                return Math.Round(Convert.ToDecimal(Convert.ToDouble(0.25m) * Math.PI*(Size1*Size1)), 2);
            }
            else if (Shape == "Square")
            {
                return Size1*Size2;
            }
            else if (Shape == "Triangle")
            {
                var s = (Size1 + Size2 + Size3)/2;

                var rootThis = s * (s - Size1) * (s - Size2) *(s - Size3);
                return Math.Round(Convert.ToDecimal(Math.Sqrt(rootThis)), 2);
            }
            else
            {
                return -1;
            }
        }

        public void AddToDatabse()
        {
            _pizzaRepo.AddPizza(this);
        }

        public void PlaceInOven(DateTime time)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public override string ToString()
        {
            var value = "";
            foreach (var product in Products)
            {
                value = value + " " + product.ToString();
            }

            return Name +", " + value;
        }
    }
}
