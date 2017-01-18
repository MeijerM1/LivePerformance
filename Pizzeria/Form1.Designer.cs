namespace Pizzeria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.tpOrders = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbCustomers = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.cbDeliveryMethod = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clbPizza = new System.Windows.Forms.CheckedListBox();
            this.clbProduct = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btAddNewPizza = new System.Windows.Forms.Button();
            this.btPlaceOrder = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.nudSellPrice = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.tpPizza = new System.Windows.Forms.TabPage();
            this.lbPizza = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCrust = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbShape = new System.Windows.Forms.ComboBox();
            this.nudValue1 = new System.Windows.Forms.NumericUpDown();
            this.nudValue2 = new System.Windows.Forms.NumericUpDown();
            this.nudValue3 = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.clbToppings = new System.Windows.Forms.CheckedListBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btAddPizza = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCustomers.SuspendLayout();
            this.tpOrders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).BeginInit();
            this.tpPizza.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCustomers);
            this.tabControl1.Controls.Add(this.tpOrders);
            this.tabControl1.Controls.Add(this.tpProducts);
            this.tabControl1.Controls.Add(this.tpPizza);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // tpCustomers
            // 
            this.tpCustomers.Controls.Add(this.label8);
            this.tpCustomers.Controls.Add(this.lbCustomers);
            this.tpCustomers.Controls.Add(this.groupBox1);
            this.tpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(746, 334);
            this.tpCustomers.TabIndex = 0;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            // 
            // tpOrders
            // 
            this.tpOrders.Controls.Add(this.groupBox2);
            this.tpOrders.Controls.Add(this.label9);
            this.tpOrders.Controls.Add(this.listBox1);
            this.tpOrders.Location = new System.Drawing.Point(4, 22);
            this.tpOrders.Name = "tpOrders";
            this.tpOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tpOrders.Size = new System.Drawing.Size(746, 334);
            this.tpOrders.TabIndex = 1;
            this.tpOrders.Text = "Orders";
            this.tpOrders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbPostal);
            this.groupBox1.Controls.Add(this.tbHouseNumber);
            this.groupBox1.Controls.Add(this.tbStreet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Location = new System.Drawing.Point(24, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Customer";
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.groupBox3);
            this.tpProducts.Controls.Add(this.lbProducts);
            this.tpProducts.Controls.Add(this.label14);
            this.tpProducts.Location = new System.Drawing.Point(4, 22);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Size = new System.Drawing.Size(746, 334);
            this.tpProducts.TabIndex = 2;
            this.tpProducts.Text = "Products";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(110, 38);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(110, 64);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(110, 90);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 2;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(110, 116);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Postalcode: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "House number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Street:";
            // 
            // tbPostal
            // 
            this.tbPostal.Location = new System.Drawing.Point(110, 218);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(100, 20);
            this.tbPostal.TabIndex = 10;
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(110, 192);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(100, 20);
            this.tbHouseNumber.TabIndex = 9;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(110, 166);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(100, 20);
            this.tbStreet.TabIndex = 8;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(110, 257);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 23);
            this.btSave.TabIndex = 14;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // lbCustomers
            // 
            this.lbCustomers.FormattingEnabled = true;
            this.lbCustomers.Location = new System.Drawing.Point(374, 60);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(181, 238);
            this.lbCustomers.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Customers";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 251);
            this.listBox1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Orders";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btPlaceOrder);
            this.groupBox2.Controls.Add(this.btAddNewPizza);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.clbProduct);
            this.groupBox2.Controls.Add(this.clbPizza);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbDeliveryMethod);
            this.groupBox2.Controls.Add(this.btAddCustomer);
            this.groupBox2.Controls.Add(this.cbCustomer);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(281, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 277);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Order";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Customer: ";
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(119, 40);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cbCustomer.TabIndex = 1;
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Location = new System.Drawing.Point(279, 40);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(105, 23);
            this.btAddCustomer.TabIndex = 2;
            this.btAddCustomer.Text = "Add new customer";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            // 
            // cbDeliveryMethod
            // 
            this.cbDeliveryMethod.FormattingEnabled = true;
            this.cbDeliveryMethod.Location = new System.Drawing.Point(119, 76);
            this.cbDeliveryMethod.Name = "cbDeliveryMethod";
            this.cbDeliveryMethod.Size = new System.Drawing.Size(121, 21);
            this.cbDeliveryMethod.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Delivery method:";
            // 
            // clbPizza
            // 
            this.clbPizza.FormattingEnabled = true;
            this.clbPizza.Location = new System.Drawing.Point(19, 160);
            this.clbPizza.Name = "clbPizza";
            this.clbPizza.Size = new System.Drawing.Size(120, 94);
            this.clbPizza.TabIndex = 5;
            // 
            // clbProduct
            // 
            this.clbProduct.FormattingEnabled = true;
            this.clbProduct.Location = new System.Drawing.Point(161, 160);
            this.clbProduct.Name = "clbProduct";
            this.clbProduct.Size = new System.Drawing.Size(120, 94);
            this.clbProduct.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Select pizza\'s";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Select products";
            // 
            // btAddNewPizza
            // 
            this.btAddNewPizza.Location = new System.Drawing.Point(309, 173);
            this.btAddNewPizza.Name = "btAddNewPizza";
            this.btAddNewPizza.Size = new System.Drawing.Size(102, 23);
            this.btAddNewPizza.TabIndex = 9;
            this.btAddNewPizza.Text = "Custom pizza";
            this.btAddNewPizza.UseVisualStyleBackColor = true;
            // 
            // btPlaceOrder
            // 
            this.btPlaceOrder.Location = new System.Drawing.Point(309, 231);
            this.btPlaceOrder.Name = "btPlaceOrder";
            this.btPlaceOrder.Size = new System.Drawing.Size(102, 23);
            this.btPlaceOrder.TabIndex = 10;
            this.btPlaceOrder.Text = "Place order";
            this.btPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Products";
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.Location = new System.Drawing.Point(23, 59);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(146, 251);
            this.lbProducts.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btAddProduct);
            this.groupBox3.Controls.Add(this.cbCategorie);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.nudSellPrice);
            this.groupBox3.Controls.Add(this.nudPurchasePrice);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tbDescription);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbName);
            this.groupBox3.Location = new System.Drawing.Point(212, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add product";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(114, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(115, 20);
            this.tbName.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Name:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(114, 70);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(115, 20);
            this.tbDescription.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Purchase price";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Sell price:";
            // 
            // nudPurchasePrice
            // 
            this.nudPurchasePrice.DecimalPlaces = 2;
            this.nudPurchasePrice.Location = new System.Drawing.Point(114, 106);
            this.nudPurchasePrice.Name = "nudPurchasePrice";
            this.nudPurchasePrice.Size = new System.Drawing.Size(115, 20);
            this.nudPurchasePrice.TabIndex = 6;
            // 
            // nudSellPrice
            // 
            this.nudSellPrice.DecimalPlaces = 2;
            this.nudSellPrice.Location = new System.Drawing.Point(114, 132);
            this.nudSellPrice.Name = "nudSellPrice";
            this.nudSellPrice.Size = new System.Drawing.Size(115, 20);
            this.nudSellPrice.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(19, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Categorie:";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(114, 162);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(115, 21);
            this.cbCategorie.TabIndex = 9;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(154, 223);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btAddProduct.TabIndex = 10;
            this.btAddProduct.Text = "Add product";
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // tpPizza
            // 
            this.tpPizza.Controls.Add(this.groupBox4);
            this.tpPizza.Controls.Add(this.label20);
            this.tpPizza.Controls.Add(this.lbPizza);
            this.tpPizza.Location = new System.Drawing.Point(4, 22);
            this.tpPizza.Name = "tpPizza";
            this.tpPizza.Size = new System.Drawing.Size(746, 334);
            this.tpPizza.TabIndex = 3;
            this.tpPizza.Text = "Pizza";
            this.tpPizza.UseVisualStyleBackColor = true;
            // 
            // lbPizza
            // 
            this.lbPizza.FormattingEnabled = true;
            this.lbPizza.Location = new System.Drawing.Point(24, 66);
            this.lbPizza.Name = "lbPizza";
            this.lbPizza.Size = new System.Drawing.Size(152, 251);
            this.lbPizza.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Pizzas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btAddPizza);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.clbToppings);
            this.groupBox4.Controls.Add(this.tbTotalPrice);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.tbSize);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.nudValue3);
            this.groupBox4.Controls.Add(this.nudValue2);
            this.groupBox4.Controls.Add(this.nudValue1);
            this.groupBox4.Controls.Add(this.cbShape);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.cbCrust);
            this.groupBox4.Location = new System.Drawing.Point(307, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 287);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add custom pizza";
            // 
            // cbCrust
            // 
            this.cbCrust.FormattingEnabled = true;
            this.cbCrust.Location = new System.Drawing.Point(112, 47);
            this.cbCrust.Name = "cbCrust";
            this.cbCrust.Size = new System.Drawing.Size(121, 21);
            this.cbCrust.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(34, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Crust:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "Shape:";
            // 
            // cbShape
            // 
            this.cbShape.FormattingEnabled = true;
            this.cbShape.Location = new System.Drawing.Point(112, 74);
            this.cbShape.Name = "cbShape";
            this.cbShape.Size = new System.Drawing.Size(121, 21);
            this.cbShape.TabIndex = 7;
            // 
            // nudValue1
            // 
            this.nudValue1.Location = new System.Drawing.Point(113, 111);
            this.nudValue1.Name = "nudValue1";
            this.nudValue1.Size = new System.Drawing.Size(120, 20);
            this.nudValue1.TabIndex = 8;
            // 
            // nudValue2
            // 
            this.nudValue2.Location = new System.Drawing.Point(112, 137);
            this.nudValue2.Name = "nudValue2";
            this.nudValue2.Size = new System.Drawing.Size(120, 20);
            this.nudValue2.TabIndex = 9;
            // 
            // nudValue3
            // 
            this.nudValue3.Location = new System.Drawing.Point(112, 163);
            this.nudValue3.Name = "nudValue3";
            this.nudValue3.Size = new System.Drawing.Size(120, 20);
            this.nudValue3.TabIndex = 10;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 200);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Total size:";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(112, 200);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(120, 20);
            this.tbSize.TabIndex = 12;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 233);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 13;
            this.label24.Text = "Total price:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(113, 226);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(120, 20);
            this.tbTotalPrice.TabIndex = 14;
            // 
            // clbToppings
            // 
            this.clbToppings.FormattingEnabled = true;
            this.clbToppings.Location = new System.Drawing.Point(274, 77);
            this.clbToppings.Name = "clbToppings";
            this.clbToppings.Size = new System.Drawing.Size(120, 169);
            this.clbToppings.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(271, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Select toppings";
            // 
            // btAddPizza
            // 
            this.btAddPizza.Location = new System.Drawing.Point(113, 258);
            this.btAddPizza.Name = "btAddPizza";
            this.btAddPizza.Size = new System.Drawing.Size(75, 23);
            this.btAddPizza.TabIndex = 17;
            this.btAddPizza.Text = "Add pizza";
            this.btAddPizza.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpCustomers.ResumeLayout(false);
            this.tpCustomers.PerformLayout();
            this.tpOrders.ResumeLayout(false);
            this.tpOrders.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.tpProducts.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).EndInit();
            this.tpPizza.ResumeLayout(false);
            this.tpPizza.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbCustomers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.TextBox tbHouseNumber;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TabPage tpOrders;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btPlaceOrder;
        private System.Windows.Forms.Button btAddNewPizza;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox clbProduct;
        private System.Windows.Forms.CheckedListBox clbPizza;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDeliveryMethod;
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nudSellPrice;
        private System.Windows.Forms.NumericUpDown nudPurchasePrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tpPizza;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckedListBox clbToppings;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nudValue3;
        private System.Windows.Forms.NumericUpDown nudValue2;
        private System.Windows.Forms.NumericUpDown nudValue1;
        private System.Windows.Forms.ComboBox cbShape;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbCrust;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox lbPizza;
        private System.Windows.Forms.Button btAddPizza;
    }
}

