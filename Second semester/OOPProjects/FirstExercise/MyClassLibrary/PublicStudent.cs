using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLibrary
{
    class PublicStudent : Student
    {
        private string facNumber;
        public PublicStudent(string name, string facNumber) : base(name)
        {
            this.facNumber = facNumber;
        }

        public void Print()
        {
            Console.WriteLine(facNumber);
            Console.WriteLine(name);
        }
    }
}
