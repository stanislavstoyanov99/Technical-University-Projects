using System;
using System.IO;

namespace ReadOfTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var entropy = new int[100_000];

            using (var f = File.OpenText(@"E:\ТУ - програмиране\WorkInClass\WriteInFileUsing\bin\Debug\storage.txt"))
            {
                int lineNum = 0;
                while (!f.EndOfStream)
                {
                    string line = f.ReadLine();
                    entropy[lineNum++] = int.Parse(line);
                }
            }
            foreach (var num in entropy)
            {
                Console.WriteLine(num);
            }
        }
    }
}
