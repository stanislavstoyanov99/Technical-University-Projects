using MyNameSpace;
using System;
using MyClassLibrary;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student("Ivancho");
            Console.WriteLine(st.Name);
            st.Rename("Mariika");

            Console.ReadLine();
        }
    }
}
