using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Logic
{
    public class ProductRepository : IProductContext
    {
        private IProductContext _context;

        public ProductRepository(IProductContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public void Addproduct(Product product)
        {
           _context.Addproduct(product);
        }

        /// <inheritdoc />
        public void RemoveProduct(Product product)
        {
            _context.RemoveProduct(product);
        }

        /// <inheritdoc />
        public void UpdateProduct(Product product)
        {
            _context.UpdateProduct(product);
        }

        /// <inheritdoc />
        public List<Product> GetAllProducts()
        {
            return _context.GetAllProducts();
        }

        /// <inheritdoc />
        public Product GetProductbyId(int id)
        {
            return _context.GetProductbyId(id);
        }
    }
}
