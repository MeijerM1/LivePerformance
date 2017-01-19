using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Data;
using PizzeriaClassLibrary.Enums;
using PizzeriaClassLibrary.Logic;

namespace PizzeriaClassLibrary.Models
{
    public class Product
    {
        private ProductRepository _productRepo = new ProductRepository(new ProductMsSqlContext());

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

        public void AddToDatabase()
        {
            _productRepo.Addproduct(this);
        }

        public void UpdateProduct()
        {
            _productRepo.UpdateProduct(this);
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Name;
        }
    }
}
