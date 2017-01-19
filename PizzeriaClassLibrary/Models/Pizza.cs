using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PizzeriaClassLibrary.Models
{
    public class Pizza
    {
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

        public decimal CalculatePrice()
        {
            if (Shape == "Round")
            {
                
            }
        }

        public void PlaceInOven(DateTime time)
        {
            throw new NotImplementedException();
        }
    }
}
