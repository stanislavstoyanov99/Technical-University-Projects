namespace AlgorithmModels
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using System.Collections.Generic;

    using DijkstraAlgorithm.Models;
    using DijkstraAlgorithm.Models.Interfaces;

    using Wintellect.PowerCollections;

    public class Prim
    {
        private readonly IGraph graph;

        private static HashSet<IVertex> spanningTree = new HashSet<IVertex>();
        private static Dictionary<int, List<IEdge>> nodeToEdges = new Dictionary<int, List<IEdge>>();

        public Prim(IGraph graph)
        {
            this.graph = graph;
        }

        public void GetShortestPath(int startId, PictureBox pictureBoxGraph, RichTextBox richTextBox)
        {
            foreach (var edge in graph.Edges)
            {
                if (!nodeToEdges.ContainsKey(edge.FirstVertex.Id))
                {
                    nodeToEdges[edge.FirstVertex.Id] = new List<IEdge>();
                }

                if (!nodeToEdges.ContainsKey(edge.SecondVertex.Id))
                {
                    nodeToEdges[edge.SecondVertex.Id] = new List<IEdge>();
                }

                nodeToEdges[edge.FirstVertex.Id].Add(edge);
                nodeToEdges[edge.SecondVertex.Id].Add(edge);
            }

            IVertex initialVertex = graph[startId];

            Algorithm(initialVertex, pictureBoxGraph, richTextBox);
        }

        private static void Algorithm(IVertex startingVertex, PictureBox pictureBoxGraph, RichTextBox richTextBox)
        {
            spanningTree.Add(startingVertex);

            var priorityQueue =
                new OrderedBag<IEdge>(Comparer<IEdge>.Create((f, s) => f.Weight - s.Weight));

            priorityQueue.AddMany(nodeToEdges[startingVertex.Id]);

            richTextBox.Text += "Edge   Weight" + Environment.NewLine;

            while (priorityQueue.Count != 0)
            {
                var minEdge = priorityQueue.GetFirst();
                priorityQueue.Remove(minEdge);

                var firstVertex = minEdge.FirstVertex;
                var secondVertex = minEdge.SecondVertex;

                var nonTreeVertex = new Vertex(-1);

                if (spanningTree.Any(x => x.Id == secondVertex.Id) &&
                    !spanningTree.Any(x => x.Id == firstVertex.Id))
                {
                    nonTreeVertex.Id = firstVertex.Id;
                    nonTreeVertex.MinCost = minEdge.Weight;
                }

                if (spanningTree.Any(x => x.Id == firstVertex.Id) &&
                    !spanningTree.Any(x => x.Id == secondVertex.Id))
                {
                    nonTreeVertex.Id = secondVertex.Id;
                    nonTreeVertex.MinCost = minEdge.Weight;
                }

                if (nonTreeVertex.Id == -1)
                {
                    continue;
                }

                spanningTree.Add(nonTreeVertex);

                richTextBox.Text += $"{firstVertex.Id + 1} - {secondVertex.Id + 1}    {minEdge.Weight}" + Environment.NewLine;

                priorityQueue.AddMany(nodeToEdges[nonTreeVertex.Id]);
            }

            var minWeight = spanningTree
                .Where(x => x.MinCost != int.MaxValue)
                .Sum(x => x.MinCost);

            richTextBox.Text += $"Minimum result function (F): {minWeight}";
        }
    }
}
