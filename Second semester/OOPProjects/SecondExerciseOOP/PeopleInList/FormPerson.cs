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
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private Person person = new Person();

        public Person Person
        {
            get
            {
                return person;
            }
            set
            {
                person = value;

                NameTxtbox.Text = person.PersonName;
                EgnTxtbox.Text = person.Egn;

                productsListbox.Items.Clear();
                foreach (var product in Person.products)
                {
                    productsListbox.Items.Add(product);
                }
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            Person.PersonName = NameTxtbox.Text;
            Person.Egn = EgnTxtbox.Text;
            

            string personName = NameTxtbox.Text;
            string personEgn = EgnTxtbox.Text;

            if (string.IsNullOrEmpty(personName))
            {
                MessageBox.Show("Моля въведете полето за име.");
                NameTxtbox.Text = string.Empty;
                return;
            }
            else if (string.IsNullOrEmpty(personEgn))
            {
                MessageBox.Show("Моля въведете полето за ЕГН.");
                EgnTxtbox.Text = string.Empty;
                return;
            }

            if (!Regex.IsMatch(personEgn, "^[0-9]*$"))
            {
                MessageBox.Show("Моля въведете само цифри.");
                EgnTxtbox.Text = string.Empty;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var formProduct = new ProductForm();
            var product = new Product();

            formProduct.Product = product;

            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                Person.products.Add(product);
                productsListbox.Items.Add(product);
            }
        }

        private void RemoveProduct_Click(object sender, EventArgs e)
        {
            if (productsListbox.SelectedItem == null)
            {
                MessageBox.Show("Моля изберете запис за изтриване.");
                return;
            }

            productsListbox.Items.Remove(productsListbox.SelectedItem);
        }

        private void productsListbox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (productsListbox.SelectedItem == null)
            {
                MessageBox.Show("Моля изберете запис за обновяване.");
                return;
            }

            var formProduct = new ProductForm();
            var product = (Product)productsListbox.SelectedItem;
            formProduct.Product = product;

            if (formProduct.ShowDialog() == DialogResult.OK)
            {
                int index = productsListbox.SelectedIndex;
                productsListbox.Items.RemoveAt(index);
                productsListbox.Items.Insert(index, product);
            }
        }
    }
}
