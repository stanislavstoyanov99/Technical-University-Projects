namespace IteratorExercise1
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var list = new MyList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            Iterator<int> iterator = list.CreateIterator();

            Console.WriteLine("List content with iterator is:");
            for (Node<int> item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.Write($"{item.Value} ");
            }

            Console.WriteLine();
            Console.WriteLine("List content without iterator:");
            list.PrintList();

            Console.WriteLine();
        }
    }
}
