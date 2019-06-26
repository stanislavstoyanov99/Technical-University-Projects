using System;
using System.Linq;

namespace BasicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ivan", "Dragan", "Zivko", "Petyr", "Dimitar" };

            // Sort
            string[] orderedNames = names
                .OrderBy(o => o)
                .ToArray();

            // Filter
            string[] filteredNames = names
                .Where(c => c.StartsWith("D"))
                .ToArray();

            // Filter and sort cascadically
            string[] orderedAndFilteredNames = names
                .Where(c => c.StartsWith("D"))
                .OrderBy(o => o)
                .ToArray();

            // Choose last element
            string lastName = names
                .Where(c => c.StartsWith("D"))
                .OrderBy(o => o)
                .LastOrDefault();

            // Projection
            char lastNameFirstLetter = names
                .Where(c => c.StartsWith("D"))
                .OrderBy(o => o)
                .Select(s => s[0])
                .LastOrDefault();

            char lastNameLastLetter = names
                .Where(c => c.StartsWith("D"))
                .OrderBy(o => o)
                .Select(s => s[s.Length - 1])
                .LastOrDefault();

            Console.WriteLine(string.Join(Environment.NewLine, orderedNames));
            Console.WriteLine("------------------");
            Console.WriteLine(string.Join(Environment.NewLine, filteredNames));
            Console.WriteLine("------------------");
            Console.WriteLine(string.Join(Environment.NewLine, orderedAndFilteredNames));
            Console.WriteLine("------------------");
            Console.WriteLine(lastName);
            Console.WriteLine("------------------");
            Console.WriteLine(lastNameFirstLetter);
            Console.WriteLine("------------------");
            Console.WriteLine(lastNameLastLetter);
        }
    }
}
