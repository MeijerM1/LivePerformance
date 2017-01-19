using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using PizzeriaClassLibrary.Data;
using PizzeriaClassLibrary.Enums;
using PizzeriaClassLibrary.Logic;
using PizzeriaClassLibrary.Models;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        private readonly CustomerRepository _customerRepo = new CustomerRepository(new CustomerMsSqlContext());
        private readonly ProductRepository _productRepo = new ProductRepository(new ProductMsSqlContext());
        private readonly PizzaRepository _pizzaRepo = new PizzaRepository(new PizzaMsSqlContext());
        private readonly PizzacrustRepository _pizzacrustRepo = new PizzacrustRepository(new PizzacrustMsSqlContext());

        public Form1()
        {
            InitializeComponent();
            UpdateCustomerControls();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
           var textBoxes = groupBox3.Controls.OfType<TextBox>();
            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text == "")
                {
                    MessageBox.Show("One or more fields are empty");
                    return;
                }
            }

            try
            {
                if (lbProducts.SelectedIndex < 0)
                {
                    AddProduct();
                }
                else
                {
                    UpdateProduct();
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (Exception exc1)
            {
                MessageBox.Show(exc1.Message);
            }


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
            var products = _productRepo.GetAllProducts();
            foreach (var product in products)
                lbProducts.Items.Add(product);
        }

        // Fill the customer tab with data
        private void UpdateCustomerControls()
        {
            lbCustomers.Items.Clear();
            var customers = _customerRepo.GetAllCustomers();

            foreach (var customer in customers)
                lbCustomers.Items.Add(customer);
        }

        // Fill the pizza tab with data
        private void UpdatepizzaControls()
        {
            lbPizza.Items.Clear();
            var pizzas = _pizzaRepo.GetAllPizzas();
            foreach (var pizza in pizzas)
            {
                lbPizza.Items.Add(pizza);
            }

            cbCrust.Items.Clear();
            var crusts = _pizzacrustRepo.GetAllPizzaCrusts();
            foreach (var pizzacrust in crusts)
            {
                cbCrust.Items.Add(pizzacrust);
            }
            cbShape.Items.Clear();
            cbShape.Items.Add("Round");
            cbShape.Items.Add("Square");
            cbShape.Items.Add("Triangle");

            clbToppings.Items.Clear();
            var allProducts = _productRepo.GetAllProducts();
            var topping = allProducts.Where(a => a.ProductCategory == ProductCategory.Topping);
            foreach (var product in topping)
            {
                clbToppings.Items.Add(product);
            }
        }

        // Fill the order tab with data
        private void UpdateOrderCOntrols()
        {
            cbCustomer.Items.Clear();
            var customers = _customerRepo.GetAllCustomers();
            foreach (var c in customers)
            {
                cbCustomer.Items.Add(c);
            }

            cbDeliveryMethod.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(DeliveryMethod)))
            {
                cbDeliveryMethod.Items.Add(item);
            }

            clbPizza.Items.Clear();
            var pizzas = _pizzaRepo.GetAllPizzas();
            foreach (var pizza in pizzas)
            {
                clbPizza.Items.Add(pizza);
            }

            clbProduct.Items.Clear();
            var allProducts = _productRepo.GetAllProducts();
            var sellables = allProducts.Where(a => a.ProductCategory == ProductCategory.AlcoholicDrink || a.ProductCategory == ProductCategory.Drink || a.ProductCategory == ProductCategory.Sellable);
            foreach (var sellable in sellables)
            {
                clbProduct.Items.Add(sellable);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only load data for the selected page for performance
            var index = tabControl1.SelectedIndex;
            switch (index)
            {
                case 0:
                    UpdateCustomerControls();
                    break;
                case 1:
                    UpdateOrderCOntrols();
                    break;
                case 2:
                    UpdateProductControle();
                    break;
                case 3:
                    UpdatepizzaControls();
                    break;
            }
        }

        private void btEditProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Select a product first");
                return;
            }

            var productToEdit = (Product) lbProducts.SelectedItem;
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
            var name = tbName.Text;
            var description = tbDescription.Text;
            var purchaPrice = nudPurchasePrice.Value;
            var sellPrice = nudSellPrice.Value;
            var category = (ProductCategory) Enum.Parse(typeof(ProductCategory), cbCategorie.Text);

            var productToAdd = new Product(name, description, purchaPrice, sellPrice, category);
            productToAdd.AddToDatabase();

            MessageBox.Show("Done");
        }

        private void UpdateProduct()
        {
            var productToEdit = (Product) lbProducts.SelectedItem;

            productToEdit.Name = tbName.Text;
            productToEdit.Description = tbDescription.Text;
            productToEdit.PurchasePrice = nudPurchasePrice.Value;
            productToEdit.SellPrice = nudSellPrice.Value;
            productToEdit.ProductCategory = (ProductCategory) Enum.Parse(typeof(ProductCategory), cbCategorie.Text);

            productToEdit.UpdateProduct();

            MessageBox.Show("Done");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbCustomers.SelectedIndex < 0)
                {
                    AddNewCustomer();
                }
                else
                {
                    UpdateCustomer();
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("One or more fields are empty");
            }
            catch (Exception exc1)
            {
                MessageBox.Show(exc1.Message);
            }
        }

        private void AddNewCustomer()
        {
            var textBoxes = groupBox1.Controls.OfType<TextBox>();
            foreach (TextBox tb in textBoxes)
            {
                if (tb.Text == "")
                {
                    MessageBox.Show("One or more fields are empty");
                    return;
                }
            }

            var lastName = tbLastName.Text;
            var firstName = tbFirstName.Text;
            var email = tbEmail.Text;
            var phoneNumber = Convert.ToInt32(tbPhone.Text);

            var street = tbStreet.Text;
            var houseNumber = Convert.ToInt32(tbHouseNumber.Text);
            var postal = tbPostal.Text;

            var adress = new Adress(street, houseNumber, postal);

            var customerToAdd = new Customer(lastName, firstName, email, phoneNumber, adress);
            customerToAdd.AddToDatabase();

            MessageBox.Show("Done");
        }

        private void UpdateCustomer()
        {
            Customer customerToEdit = (Customer) lbCustomers.SelectedItem;
            customerToEdit.LastName = tbLastName.Text;
            customerToEdit.FirstName = tbFirstName.Text;
            customerToEdit.Email = tbEmail.Text;
            customerToEdit.Phonenumber = Convert.ToInt32(tbPhone.Text);

            customerToEdit.Adress.Streetname = tbStreet.Text;
            customerToEdit.Adress.HouseNumber = Convert.ToInt32(tbHouseNumber.Text);
            customerToEdit.Adress.Postalcode = tbPostal.Text;

            customerToEdit.UpdateCustomer();

            MessageBox.Show("Done");
        }

        private void ShowCustomerDetails(Customer customerToEdit)
        {
            tbLastName.Text = customerToEdit.LastName;
            tbFirstName.Text = customerToEdit.FirstName;
            tbEmail.Text = customerToEdit.Email;
            tbPhone.Text = customerToEdit.Phonenumber.ToString();

            tbStreet.Text = customerToEdit.Adress.Streetname;
            tbHouseNumber.Text = customerToEdit.Adress.HouseNumber.ToString();
            tbPostal.Text = customerToEdit.Adress.Postalcode;
        }

        private void btEditCustomer_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex < 0)
            {
                MessageBox.Show("Select a customer first");
                return;
            }

            var customerToEdit = (Customer) lbCustomers.SelectedItem;
            ShowCustomerDetails(customerToEdit);
        }

        private void btAddPizza_Click(object sender, EventArgs e)
        {
            try
            {
                AddPizza();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("One or more fields are empty");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void AddPizza()
        {
            Pizzacrust crust = (Pizzacrust)cbCrust.SelectedItem;
            string shape = cbShape.Text;
            string name = tbPizzaName.Text;
            List<Product> toppings = new List<Product>();
            int size1 = Convert.ToInt32(nudValue1.Value);
            int size2 = Convert.ToInt32(nudValue2.Value);
            int size3 = Convert.ToInt32(nudValue3.Value);

            foreach (var selected in clbToppings.CheckedItems)
            {
                toppings.Add((Product)selected);
            }

            Pizza pizzaToAdd = new Pizza(name, false, DateTime.Now, shape, size1, size2, size3, toppings, crust);
            pizzaToAdd.AddToDatabse();

            MessageBox.Show("Done");
        }

        private void btAddCustomer_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btAddNewPizza_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void nudValue1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShape.Text == "Round")
            {
                nudValue1.Enabled = true;
                nudValue2.Enabled = false;
                nudValue3.Enabled = false;
            }
            else if (cbShape.Text == "Square")
            {
                nudValue1.Enabled = true;
                nudValue2.Enabled = true;
                nudValue3.Enabled = false;
            }
            else if (cbShape.Text == "Triangle")
            {
                nudValue1.Enabled = true;
                nudValue2.Enabled = true;
                nudValue3.Enabled = true;
            }
            else
            {
                nudValue1.Enabled = true;
                nudValue2.Enabled = true;
                nudValue3.Enabled = true;
            }
        }
    }
}