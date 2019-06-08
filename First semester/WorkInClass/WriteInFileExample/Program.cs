using System;
using System.IO;

namespace WriteInFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(File.ReadAllText("C:\\Users\\User\\Desktop\\test.txt"));
            File.WriteAllText("test.txt", Console.ReadLine());
        }
    }
}
