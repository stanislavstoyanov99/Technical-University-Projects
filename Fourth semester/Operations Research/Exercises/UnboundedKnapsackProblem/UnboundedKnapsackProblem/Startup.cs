namespace UnboundedKnapsackProblem
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
                int weightOfKnapsack = ValidateInput(inputWeightOfKnapsack);

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
                var knapSackResult = UnboundedKnapSack(products, weightOfKnapsack);

                Console.WriteLine($"Time to execute: {sw.Elapsed}");
                Console.WriteLine($"Unbounded knapsack (Belman) result is: {knapSackResult}");
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

        private static int UnboundedKnapSack(List<Product> items, int capacity)
        {
            var result = new int[capacity + 1];

            for (int i = 0; i <= capacity; i++)
            {
                for (int j = 0; j < items.Count; j++)
                {
                    if (items[j].Weight <= i)
                    {
                        var currentCapacity = result[i];
                        var itemCapacity = result[i - items[j].Weight] + items[j].Price;

                        result[i] = Math.Max(currentCapacity, itemCapacity);
                    }
                }
            }

            return result[capacity];
        }
    }
}
