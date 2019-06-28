using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleInList
{
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
        }

        private ArrayList people = new ArrayList();

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var formPerson = new FormPerson();
            Person person = new Person();
            formPerson.Person = person;

            if (formPerson.ShowDialog() == DialogResult.OK)
            {
                people.Add(person);
                listBoxPeople.Items.Add(person);
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
            {
                MessageBox.Show("Моля изберете запис за изтриване.");
                return;
            }

            listBoxPeople.Items.Remove(listBoxPeople.SelectedItem);
        }

        private void listBoxPeople_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxPeople.SelectedItem == null)
            {
                MessageBox.Show("Моля изберете запис за обновяване.");
                return;
            }

            var formPerson = new FormPerson();
            var person = (Person)listBoxPeople.SelectedItem;
            formPerson.Person = person;

            if (formPerson.ShowDialog() == DialogResult.OK)
            {
                int index = listBoxPeople.SelectedIndex;
                listBoxPeople.Items.RemoveAt(index);
                listBoxPeople.Items.Insert(index, person);
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (SearchTxtbox.Text == string.Empty)
            {
                MessageBox.Show("Моля въведете име за търсене.");
                return;
            }

            listBoxPeople.Items.Clear();

            foreach (var person in people)
            {
                if (((Person)person).PersonName.Contains(SearchTxtbox.Text))
                {
                    listBoxPeople.Items.Add(person);
                }
            }
            SearchTxtbox.Text = string.Empty;
        }

        private void ShowAllBtn_Click(object sender, EventArgs e)
        {
            listBoxPeople.Items.Clear();

            if (people.Count == 0)
            {
                MessageBox.Show("Няма записи за показване.");
                return;
            }

            foreach (var item in people)
            {
                listBoxPeople.Items.Add(item);
            }
        }
    }
}
