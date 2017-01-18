using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Enums;

namespace PizzeriaClassLibrary.Models
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellPrice { get; set; }
        public ProductCategory ProductCategory { get; set; }

        /// <inheritdoc />
        public Product(string name, string description, decimal purchasePrice, decimal sellPrice, ProductCategory productCategory)
        {
            Name = name;
            Description = description;
            PurchasePrice = purchasePrice;
            SellPrice = sellPrice;
            ProductCategory = productCategory;
        }

        /// <inheritdoc />
        public Product(int id, string name, string description, decimal purchasePrice, decimal sellPrice, ProductCategory productCategory)
        {
            ID = id;
            Name = name;
            Description = description;
            PurchasePrice = purchasePrice;
            SellPrice = sellPrice;
            ProductCategory = productCategory;
        }

        public void ChangePrice(decimal price)
        {
            throw new NotImplementedException();
        }
            
    }
}
