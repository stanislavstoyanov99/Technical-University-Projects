using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleInList
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string SerialNumber { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
