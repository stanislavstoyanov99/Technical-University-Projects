using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleInList
{
    public class Person
    {
        public string PersonName { get; set; }
        public string Egn { get; set; }
        public List<Product> products = new List<Product>();

        public override string ToString()
        {
            return PersonName;
        }
    }
}
