using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PizzeriaClassLibrary.Enums;
using PizzeriaClassLibrary.Models;

namespace LP_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalculateSurfaceRound()
        {
            List<Product> products = new List<Product>();
            Pizzacrust crust = new Pizzacrust("test", Convert.ToDecimal(0.25));
            Pizza pizza = new Pizza("test", false, DateTime.Now,"Round", 10, 0 ,0, products, crust);

            var surface = pizza.CalculateSurface();

            Assert.AreEqual(Convert.ToDecimal(78.540), surface);
        }

        [TestMethod]
        public void TestCalculateSurfaceSquare()
        {
            List<Product> products = new List<Product>();
            Pizzacrust crust = new Pizzacrust("test", Convert.ToDecimal(0.25));
            Pizza pizza = new Pizza("test", false, DateTime.Now, "Square", 10, 15, 0, products, crust);

            var surface = pizza.CalculateSurface();

            Assert.AreEqual(Convert.ToDecimal(150), surface);
        }

        [TestMethod]
        public void TestCalculateSurfaceTriangle()
        {
            List<Product> products = new List<Product>();
            Pizzacrust crust = new Pizzacrust("test", Convert.ToDecimal(0.25));
            Pizza pizza = new Pizza("test", false, DateTime.Now, "Triangle", 10, 10, 10, products, crust);

            var surface = pizza.CalculateSurface();

            Assert.AreEqual(Convert.ToDecimal(43.30), surface);
        }

        [TestMethod]
        public void TestCalculatePizzaPrice()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Ham", "bal", 1.00m, 1.20m, ProductCategory.Topping));
            Pizzacrust crust = new Pizzacrust("Dunne bodem", Convert.ToDecimal(0.80));
            Pizza pizza = new Pizza("test", false, DateTime.Now, "Round", 20, 0, 0, products, crust);

            var price = pizza.CalculateTotalPrice();

            Assert.AreEqual(Convert.ToDecimal(6), price);
        }
    }
}
