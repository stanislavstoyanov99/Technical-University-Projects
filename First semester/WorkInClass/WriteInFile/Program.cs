using System;
using System.IO;
using System.Text;

namespace WriteInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = File.Open("storage.txt", FileMode.Create);
            var rng = new Random();
            for (int i = 0; i < 50; ++i)
            {
                string line = rng.Next() + Environment.NewLine;
                byte[] lineBytes = Encoding.UTF8.GetBytes(line);
                f.Write(lineBytes, 0, lineBytes.Length);
            }
            f.Close();
        }

        //static void Main(string[] args)
        //{
        //    var f = File.Open("storage.txt", FileMode.Create);
        //    string message = Console.ReadLine();
        //    for (int i = 0; i < 100_000; ++i)
        //    {
        //        string line = message + Environment.NewLine;
        //        byte[] lineBytes = Encoding.UTF8.GetBytes(line);
        //        f.Write(lineBytes, 0, lineBytes.Length);
        //    }
        //    f.Close();
        //}
    }
}
