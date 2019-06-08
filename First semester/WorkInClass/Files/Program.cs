using System.IO;
using System;
using System.Security.Permissions;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("storage.txt"))
            {
                var file = File.Open("storage.txt", FileMode.Truncate);
                file.Close();
            }
            //if (File.Exists("storage.txt"))
            //{
            //    string stored = File.ReadAllText("storage.txt");
            //    Console.WriteLine(stored);
            //}
            string s = Console.ReadLine();
            File.WriteAllText("storage.txt", s);
        }
    }
}
