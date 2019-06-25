using System;

namespace MyClassLibrary
{
    public class Student
    {
        protected string name;

        //public string Name
        //{
        //    get { return name; }
        //   // set { name = value; }
        //}
        public Student(string Name)
        {
            this.name = Name;
        }

        public void Print()
        {
            Console.WriteLine(name);
        }

        public void Rename (string newName)
        {
            name = newName;
        }
    }
}
