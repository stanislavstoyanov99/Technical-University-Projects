using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 2, 4, 1, 10, 3, 7 };
            var numbersOnEvenPositions = Enumerable.Range(0, numbers.Length)
                .Where(x => x % 2 == 0)
                .Select(x => numbers[x])
                .ToArray();

            int i = 0;
            var secondWay = numbers
                .Where(x => i++ % 2 == 0)
                .Select(x => numbers[i - 1])
                .ToArray();

            var sum = numbers
                .Where(c => c / 3 > 0)
                .Select(s2 => s2 + numbers
                .Where(c => c / 3 == 0)
                .Aggregate((f, s) => f - s))
                .Sum();

            Console.WriteLine(string.Join(" ", numbersOnEvenPositions));
            Console.WriteLine(string.Join(" ", secondWay));
            Console.WriteLine(sum);


        }
    }
}
