using System;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
