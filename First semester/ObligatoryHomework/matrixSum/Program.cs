using System;
using System.IO;
using System.Linq;

namespace matrixSum
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("matrix.txt");
            using (reader)
            {
                int rowCounter = 0;
                int columnCounter = 0;

                int evenSum = 0;
                int oddSum = 0;

                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    rowCounter++;
                    var element = line.Split(' ').Select(int.Parse);

                    foreach (var number in element)
                    {
                        columnCounter++;
                        if (rowCounter % 2 != 0 && number % 2 == 0)
                        {
                            evenSum += number;
                        }
                        if (columnCounter % 2 == 0 && number % 2 != 0)
                        {
                            oddSum += number;
                        }
                    }
                    columnCounter = 0;
                }

                Console.WriteLine("The sum of even numbers on odd rows is: {0}", evenSum);
                Console.WriteLine("The sum of odd numbers on even columns is: {0}", oddSum);
            }
        }
    }
}

