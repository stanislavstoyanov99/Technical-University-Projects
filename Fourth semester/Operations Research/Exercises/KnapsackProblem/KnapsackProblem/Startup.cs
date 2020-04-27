namespace KnapsackProblem
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;

    public class Startup
    {
        private const string Delimeter = "----------------------------";

        public static void Main()
        {
            Console.Write("W [Maximum weigth of knapsack] = ");
            string inputWeightOfKnapsack = Console.ReadLine();

            try
            {
                int w = ValidateInput(inputWeightOfKnapsack);

                Console.Write("Number of products = ");
                string inputNumberOfProducts = Console.ReadLine();

                int numberOfProducts = ValidateInput(inputNumberOfProducts);

                Console.WriteLine(Delimeter);

                var products = new List<Product>(numberOfProducts);
                for (int i = 0; i < numberOfProducts; i++)
                {
                    Console.Write($"Write {i + 1}.product's price = ");
                    string inputPrice = Console.ReadLine();

                    int price = ValidateValue(inputPrice);

                    Console.Write($"Write {i + 1}.product's weight = ");
                    string inputWeight = Console.ReadLine();

                    int weight = ValidateValue(inputWeight);

                    var product = new Product
                    {
                        Price = price,
                        Weight = weight,
                    };

                    products.Add(product);

                    Console.WriteLine(Delimeter);
                }

                var sw = Stopwatch.StartNew();
                var dynamicResult = KnapSackDynamically(products, w);

                Console.WriteLine($"Time to execute: {sw.Elapsed}");
                Console.WriteLine($"Dynamic programming result is: {dynamicResult}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static int ValidateValue(string input)
        {
            if (!int.TryParse(input, out int value) || value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            return value;
        }

        private static int ValidateInput(string input)
        {
            if (!int.TryParse(input, out int value))
            {
                throw new ArgumentException("Invalid input!");
            }

            return value;
        }

        // Dynamic programming
        private static int KnapSackDynamically(List<Product> items, int capacity)
        {
            int[,] matrix = new int[items.Count + 1, capacity + 1];

            for (int itemIndex = 0; itemIndex <= items.Count; itemIndex++)
            {
                var currentItem = itemIndex == 0 ? null : items[itemIndex - 1];
                for (int currentCapacity = 0; currentCapacity <= capacity; currentCapacity++)
                {
                    // Преди добавяне на елементите в раницата, сетваме всички елементи на 0
                    if (currentItem == null || currentCapacity == 0)
                    {
                        matrix[itemIndex, currentCapacity] = 0;
                    }
                    else if (currentItem.Weight <= currentCapacity)
                    {
                        matrix[itemIndex, currentCapacity]
                            = Math.Max(
                                currentItem.Price + matrix[itemIndex - 1, currentCapacity - currentItem.Weight],
                                matrix[itemIndex - 1, currentCapacity]);
                    }
                    else
                    {
                        matrix[itemIndex, currentCapacity] = matrix[itemIndex - 1, currentCapacity];
                    }
                }
            }

            return matrix[items.Count, capacity];
        }
    }
}
