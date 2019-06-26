using System;
using System.Linq;

namespace Products
{
    class Startup
    {
        static void Main(string[] args)
        {
            var products = new Product[]
            {
                new Product {Id = 1, Type = "Phone", Model = "OnePlus", Price = 1000},
                new Product {Id = 2, Type = "Phone", Model = "Apple", Price = 2000},
                new Product {Id = 3, Type = "Phone", Model = "Samsung", Price = 1500},
                new Product {Id = 4, Type = "TV", Model = "Samsung 32", Price = 200},
                new Product {Id = 5, Type = "TV", Model = "Samsung 64", Price = 2000},
                new Product {Id = 6, Type = "TV", Model = "Samsung 64 OLED", Price = 7000},
                new Product {Id = 7, Type = "Car", Model = "VW Golf", Price = 30000},
                new Product {Id = 8, Type = "Car", Model = "VW Passat", Price = 60000},
                new Product {Id = 9, Type = "Car", Model = "Audi A8", Price = 120000}
            };

            var people = new Person[]
            {
                new Person{Id = 1, Name = "Ivan Ivanov", Money = 150000},
                new Person{Id = 2, Name = "Dragan Draganov", Money = 250000},
                new Person{Id = 3, Name = "Ivelin Ivelinov", Money = 350000}
            };

            var items = new Item[]
            {
                new Item{PersonId = 1, ProductId = 1, Amount = 1},
                new Item{PersonId = 1, ProductId = 4, Amount = 1},
                new Item{PersonId = 1, ProductId = 5, Amount = 1},
                new Item{PersonId = 1, ProductId = 7, Amount = 1},
                new Item{PersonId = 2, ProductId = 2, Amount = 1},
                new Item{PersonId = 2, ProductId = 6, Amount = 1},
                new Item{PersonId = 2, ProductId = 7, Amount = 1},
                new Item{PersonId = 2, ProductId = 9, Amount = 1},
                new Item{PersonId = 3, ProductId = 3, Amount = 1},
                new Item{PersonId = 3, ProductId = 8, Amount = 1},
                new Item{PersonId = 3, ProductId = 7, Amount = 1}
            };

            // Materialize
            var firstProduct = products.FirstOrDefault();
            var lastProduct = products.Last();
            // var productArray = products.Single();

            // Condition
            var cheapProducts = products
                .Where(c => c.Price < 10_000)
                .ToArray();

            foreach (var cheapProduct in cheapProducts)
            {
                Console.WriteLine($"Type: {cheapProduct.Type} -> Model: {cheapProduct.Model}");
            }

            Console.WriteLine("------------------------");

            // Sort
            var orderedCheapProducts = products
                .Where(c => c.Price < 10_000)
                .OrderBy(p => p.Price)
                .ToArray();

            foreach (var orderedCheapProduct in orderedCheapProducts)
            {
                Console.WriteLine($"Type: {orderedCheapProduct.Type} -> Model: {orderedCheapProduct.Model}");
            }

            Console.WriteLine("------------------------");

            // Skip and Take
            var orderedFilteredCheapProducts = products
                .OrderBy(p => p.Type)
                .ThenBy(p => p.Model)
                .Skip(1)
                .Take(2)
                .ToArray();

            // Projection
            var orderedCheapProductsText = products
                .Where(p => p.Price < 10_000)
                .OrderBy(o => o.Price)
                .Select(s => "Type: " + s.Type + " -> " + "Model: " + s.Model)
                .ToArray();

            foreach (var cheapProductText in orderedCheapProductsText)
            {
                Console.WriteLine(cheapProductText);
            }

            Console.WriteLine("------------------------");

            // Aggregate
            var cheapProductsText = products
                .Where(p => p.Price < 10_000)
                .Select(s => "Type: " + s.Type + " -> " + "Model: " + s.Model + Environment.NewLine)
                .Aggregate((f, s) => f + s);

            Console.WriteLine(cheapProductsText);

            Console.WriteLine("------------------------");

            // Sum
            var allProductPrices = products
                .Select(s => s.Price)
                .Aggregate((f, s) => f + s);

            var allProductPrices2 = products
                .Sum(s => s.Price);

            Console.WriteLine(allProductPrices);
            Console.WriteLine(allProductPrices2);
            Console.WriteLine("------------------------");

            // Min, Max and Average
            var mostExpensivePrice = products
                .Max(m => m.Price);

            var cheapestPrice = products
                .Min(m => m.Price);

            var allProductPricesAverage = products
                .Average(m => m.Price);

            Console.WriteLine(mostExpensivePrice);
            Console.WriteLine(cheapestPrice);
            Console.WriteLine(allProductPricesAverage);
            Console.WriteLine("------------------------");

            // Distinct
            var productCategories = products
                .Select(s => s.Model)
                .Distinct()
                .ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, productCategories));
            Console.WriteLine("------------------------");

            // Grouping
            var productsByCategories = products
                .GroupBy(g => g.Type)
                .ToArray();

            foreach (var productsByCategory in productsByCategories)
            {
                Console.WriteLine(productsByCategory.Key);
                foreach (var product in productsByCategory)
                {
                    Console.WriteLine("\t" + product.Model);
                }
            }
            Console.WriteLine("------------------------");

            // Join
            var personItems = products
                .Join(items, o => o.Id, i => i.PersonId,
                (o, i) => new
                {
                    Person = o,
                    ProductId = i.ProductId
                })
                .ToArray();

            // Group Join
            var personItemsGroupJoin = products
                .GroupJoin(items, o => o.Id, i => i.PersonId,
                (o, i) => new
                {
                    Person = o,
                    ProductIds = i
                    .Select(s => s.ProductId)
                    .ToArray()
                })
                .ToArray();

            // Select Many
            var personItemsArr = products
                .GroupJoin(items, o => o.Id, i => i.PersonId,
                (o, i) => new
                {
                    Person = o,
                    Items = i
                })
                .SelectMany(m => m.Items
                .Select(s => new
                {
                    Person = m.Person,
                    Item = s
                }))
                .ToArray();

            // Exercises
            var peopleItemsArr = people
                .GroupJoin(items, o => o.Id, i => i.PersonId,
                (o, i) => new
                {
                    Person = o,
                    Products = i
                    .Join(
                        products,
                        o2 => o2.ProductId,
                        i2 => i2.Id,
                        (o2, i2) => i2)
                        .ToArray()
                })
                .ToArray();

            var peopleItemsSecondWay = people
                .Select(s => new
                {
                    Person = s,
                    Products = items
                    .Where(c => c.PersonId == s.Id)
                    .Select(s2 => products
                    .Single(s3 => s3.Id == s2.ProductId))
                    .ToArray()
                })
                .ToArray();

            var peopleItems = people
                .GroupJoin(items, o => o.Id, i => i.PersonId,
                (o, i) => new
                {
                    PersonName = o.Name,
                    Products = i
                    .Join(
                        products,
                        o2 => o2.ProductId,
                        i2 => i2.Id,
                        (o2, i2) => i2)
                        .Select(s => "\t" + s.Model + Environment.NewLine)
                        .Aggregate((f, s) => f + s)
                })
                .Select(s => s.PersonName + Environment.NewLine + s.Products)
                .Aggregate((f, s) => f + s);
            Console.WriteLine(peopleItems);
            Console.WriteLine("------------------------");

            var personProducts = people
                .Select(s => new
                {
                    Person = s,
                    Products = products
                    .Select(s2 =>
                    "Type: " + s2.Type +
                    "Model: " + s2.Model +
                    "Count: " + ((int)(s.Money / s2.Price)).ToString())
                    .ToArray()
                })
                .ToArray();

            var productTypes = items
                .Select(s => new
                {
                    Product = products
                    .Where(c => c.Id == s.ProductId)
                    .Single(),
                    Person = people
                    .Where(c => c.Id == s.PersonId)
                    .Single()
                })
                .GroupBy(g => g.Product.Type)
                .Select(s => new
                {
                    Type = s.Key,
                    People = s
                    .Select(s2 => s2.Person)
                    .Distinct()
                    .ToArray()
                })
                .ToArray();
        }
    }
}
