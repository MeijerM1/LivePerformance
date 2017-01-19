using System;
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

        public Form1()
        {
            InitializeComponent();
            UpdateCustomerControls();
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
                AddProduct();
            else
                UpdateProduct();

            MessageBox.Show("Done");
        }

        // Fill the product tab with data
        private void UpdateProductControle()
        {
            cbCategorie.Items.Clear();
            foreach (var item in Enum.GetValues(typeof(ProductCategory)))
                cbCategorie.Items.Add(item);

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
                    // TODO
                    break;
                case 2:
                    UpdateProductControle();
                    break;
                case 3:
                    // TODO
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
        }

        private void UpdateProduct()
        {
            var productToEdit = (Product) lbProducts.SelectedItem;

            productToEdit.Name = tbName.Text;
            productToEdit.Description = tbDescription.Text;
            productToEdit.PurchasePrice = nudPurchasePrice.Value;
            productToEdit.SellPrice = nudSellPrice.Value;
            productToEdit.ProductCategory = (ProductCategory) Enum.Parse(typeof(ProductCategory), cbCategorie.Text);

            productToEdit.UpdateProducts();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (lbCustomers.SelectedIndex < 0)
            {
                AddNewCustomer();
            }
            else
            {
                UpdateCustomer();
            }

            MessageBox.Show("Done");
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

            var customerToEdit = (Customer)lbCustomers.SelectedItem;
            ShowCustomerDetails(customerToEdit);
        }
    }
}