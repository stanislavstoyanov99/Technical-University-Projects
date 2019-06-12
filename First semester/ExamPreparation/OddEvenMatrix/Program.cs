using System;
using System.IO;

namespace OddEvenMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = File.OpenText("matrix.txt"))
            {
                int rowCounter = 0;
                int columnCounter = 0;

                int evenSum = 0;
                int oddSum = 0;

                string line;

                while ((line = file.ReadLine()) != null)
                {
                    rowCounter++;
                    //var element = line.Split(' ').Select(int.Parse);
                    //foreach (var number in element)
                    //{
                    //    columnCounter++;
                    //    if (rowCounter % 2 != 0 && elementAsInteger % 2 == 0)
                    //    {
                    //        evenSum += elementAsInteger;
                    //    }
                    //    if (columnCounter % 2 == 0 && elementAsInteger % 2 != 0)
                    //    {
                    //        oddSum += elementAsInteger;
                    //    }
                    //}
                    //columnCounter = 0;

                    var element = line.Split(' ');

                    int elementAsInteger = 0;
                    for (int i = 0; i < element.Length; i++) // rows
                    {
                        columnCounter++; // брои колоните
                        elementAsInteger = int.Parse(element[i]);

                        if (rowCounter % 2 != 0 && elementAsInteger % 2 == 0)
                        {
                            evenSum += elementAsInteger;
                        }
                        if (columnCounter % 2 == 0 && elementAsInteger % 2 != 0)
                        {
                            oddSum += elementAsInteger;
                        }
                    }
                    columnCounter = 0; // сетва колоните на 0
                }

                Console.WriteLine($"The sum of even numbers on odd rows is: {evenSum}");
                Console.WriteLine($"The sum of odd numbers on even columns is: {oddSum}");
            }
        }
    }
}
