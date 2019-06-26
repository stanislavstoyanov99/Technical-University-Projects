using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LoadingAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"D:\ТУ - програмиране\OOP - Projects\Reflection\ClassLibrary\bin\Debug\ClassLibrary.dll");

            IEnumerable<Type> assemblyTypes = assembly.GetTypes();
            int i = 1;
            foreach (Type type in assemblyTypes)
            {
                Console.WriteLine("Type: " + i++ + ": " + type.Name);
                Console.WriteLine("\tMethods: " + type.GetMethods().Count());
                Console.WriteLine("\tFields: " + type.GetFields().Count());
            }
        }
    }
}
