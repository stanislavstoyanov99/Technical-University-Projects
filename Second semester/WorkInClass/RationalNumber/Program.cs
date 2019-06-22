using System;

namespace RationalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new RationalNumber(2, 5);
            var b = new RationalNumber(1, 5);

            var c = a * b / 3;

            Console.WriteLine($"a = {a} b = {b} c = {c}");
            Console.WriteLine("a==b:{0}", a == b);
            Console.WriteLine("a>b: {0}", a > b);
        }
    }
}
