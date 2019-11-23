namespace HufmanCoding
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            var nodes = inputText
                .Distinct()
                .Select(s => new Node
                {
                    Letter = s,
                    Frequency = inputText
                    .Count(c => c == s)
                })
                .OrderBy(o => o.Frequency)
                .ToList();

            BinaryTree tree = new BinaryTree();
            Node root = new Node();

            foreach (var node in nodes)
            {
                tree.Insert(node.Frequency);
            }

            tree.DisplayTree();
        }
    }
}
