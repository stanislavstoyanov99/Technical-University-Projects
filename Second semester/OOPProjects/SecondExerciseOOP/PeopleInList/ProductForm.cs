using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleInList
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private Product product = new Product();

        public Product Product
        {
            get
            {
                return product;
            }
            set
            {
                product = value;

                ProductNameTxtbox.Text = product.ProductName;
                ProductPriceTxtbox.Text = product.Price;
                ProductSerialNumberTxtbox.Text = product.SerialNumber;
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            Product.ProductName = ProductNameTxtbox.Text;
            Product.Price = ProductPriceTxtbox.Text;
            Product.SerialNumber = ProductSerialNumberTxtbox.Text;

            string productName = ProductNameTxtbox.Text;
            string price = ProductPriceTxtbox.Text;
            string serialNumber = ProductSerialNumberTxtbox.Text;

            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Моля въведете полето за име.");
                ProductNameTxtbox.Text = string.Empty;
                return;
            }
            else if (!Regex.IsMatch(price, "^[0-9]*$"))
            {
                MessageBox.Show("Моля въведете само цифри.");
                ProductPriceTxtbox.Text = string.Empty;
                return;
            }
            else if (!Regex.IsMatch(serialNumber, "^[0-9]*$"))
            {
                MessageBox.Show("Моля въведете само цифри.");
                ProductSerialNumberTxtbox.Text = string.Empty;
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
