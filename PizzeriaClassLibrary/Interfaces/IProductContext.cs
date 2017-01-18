using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Interfaces
{
    interface IProductContext
    {
        void Addproduct(Product product);

        void RemoveProduct(Product product);

        void UpdateProduct(Product product);

        List<Product> GetAllProducts();

        Product GetProductbyId(int id);
    }
}
