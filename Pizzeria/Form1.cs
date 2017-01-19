using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzeriaClassLibrary.Enums;
using PizzeriaClassLibrary.Models;
using PizzeriaClassLibrary.Logic;
using PizzeriaClassLibrary.Data;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        ProductRepository _productRepo = new ProductRepository(new ProductMsSqlContext());
        CustomerRepository _customerRepo = new CustomerRepository(new CustomerMsSqlContext());

        public Form1()
        {
            InitializeComponent();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                AddProduct();
            }
            else
            {
                UpdateProduct();
            }

            MessageBox.Show("Done");
        }

        // Fill the product tab with data
        private void UpdateProductControle()
        {
            cbCategorie.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(ProductCategory)))
            {
                cbCategorie.Items.Add(item);
            }

            lbProducts.Items.Clear();
            List<Product> products = _productRepo.GetAllProducts();
            foreach (var product in products)
            {
                lbProducts.Items.Add(product);
            }
        }

        private void UpdateCustomerControls()
        {
            lbCustomers.Items.Clear();
            List<Customer> customers = _customerRepo.GetAllCustomers();

            foreach (var customer in customers)
            {
                lbCustomers.Items.Add(customer);
            }
        }

        // TODO Make content only load for right page
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = tabControl1.SelectedIndex;
            switch (index)
            {
                case 0:
                    UpdateCustomerControls();
                    break;
                case 1:
                    // TODO
                    break;
                case 2:
                    UpdateProductControle();
                    break;
                case 3:
                    // TODO
                    break;
            }
            UpdateProductControle();
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Select a product first");
                return;
            }

            Product productToEdit = (Product)lbProducts.SelectedItem;
            ShowProductDetails(productToEdit);
        }

        private void ShowProductDetails(Product productToEdit)
        {
            tbName.Text = productToEdit.Name;
            tbDescription.Text = productToEdit.Description;
            nudSellPrice.Value = productToEdit.SellPrice;
            nudPurchasePrice.Value = productToEdit.PurchasePrice;
            cbCategorie.Text = productToEdit.ProductCategory.ToString();
        }

        private void AddProduct()
        {
            string name = tbName.Text;
            string description = tbDescription.Text;
            decimal purchaPrice = nudPurchasePrice.Value;
            decimal sellPrice = nudSellPrice.Value;
            ProductCategory category = (ProductCategory)Enum.Parse(typeof(ProductCategory), cbCategorie.Text);

            Product productToAdd = new Product(name, description, purchaPrice, sellPrice, category);
            productToAdd.AddToDatabase();

            
        }

        private void UpdateProduct()
        {
            Product productToEdit = (Product)lbProducts.SelectedItem;

            productToEdit.Name = tbName.Text;
            productToEdit.Description = tbDescription.Text;
            productToEdit.PurchasePrice = nudPurchasePrice.Value;
            productToEdit.SellPrice = nudSellPrice.Value;
            productToEdit.ProductCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory), cbCategorie.Text);

            productToEdit.UpdateProducts();     
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string lastName = tbLastName.Text;
            string firstName = tbFirstName.Text;
            string email = tbEmail.Text;
            int phoneNumber = Convert.ToInt32(tbPhone.Text);

            string street = tbStreet.Text;
            int houseNumber = Convert.ToInt32(tbHouseNumber.Text);
            string postal = tbPostal.Text;

            Adress adress = new Adress(street, houseNumber, postal);

            Customer customerToAdd = new Customer(lastName, firstName, email, phoneNumber, adress);
            customerToAdd.AddToDatabase();
        }
    }
}
