using System;
using System.Collections.Generic;

using DuplexLinkedList.Structure;
using Circular_List.Structure;
using Stack.Structure;
using Queue.Structure;
using Set.Structure;
using HashTable.Structure;
using Dictionary.Structure;
using Trie.Structure;
using Binary_Heap.Structure;
using Binary_Search_Tree.Structure;
using Graphs.Structure;

namespace Data_Structures_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var set1 = new LiteSet<int>(new int[] { 1, 2, 3, 4, 5 });
            var set2 = new LiteSet<int>(new int[] { 4, 5, 6, 7, 8});
            var set3 = new LiteSet<int>(new int[] { 3, 4, 5 });

            Console.WriteLine("Union: ");
            foreach(var item in set1.Union(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Intersection: ");
            foreach (var item in set1.Intersection(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Difference A \\ B: ");
            foreach (var item in set1.Difference(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Difference B \\ A: ");
            foreach (var item in set2.Difference(set1))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("A Subset C: ");
            Console.Write(set1.Subset(set3));
            Console.WriteLine();

            Console.WriteLine("C Subset A: ");
            Console.Write(set3.Subset(set1));
            Console.WriteLine();

            Console.WriteLine("C Subset B: ");
            Console.Write(set3.Subset(set2));
            Console.WriteLine();

            Console.WriteLine("Symmetric Difference: ");
            foreach (var item in set1.SymmetricDifference(set2))
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            var dictionary = new Dictionary.Model.Dictionary<int, string>();
            dictionary.Add(new Item<int, string>(1, "One"));
            dictionary.Add(new Item<int, string>(1, "One"));
            dictionary.Add(new Item<int, string>(2, "Two"));
            dictionary.Add(new Item<int, string>(3, "Three"));
            dictionary.Add(new Item<int, string>(4, "Four"));
            dictionary.Add(new Item<int, string>(5, "Five"));
            dictionary.Add(new Item<int, string>(101, "One Hundred One"));

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine(dictionary.Search(7) ?? "Not found.");
            Console.WriteLine(dictionary.Search(3) ?? "Not found.");
            Console.WriteLine(dictionary.Search(101) ?? "Not found.");

            Console.WriteLine();

            dictionary.Remove(7);
            dictionary.Remove(3);
            dictionary.Remove(1);
            dictionary.Remove(101);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(8);
            tree.Add(6);
            tree.Add(9);
            tree.Add(4);

            Console.Write("Preorder: ");
            foreach(var item in tree.Preorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Postorder: ");
            foreach (var item in tree.Postorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Inorder: ");
            foreach (var item in tree.Inorder())
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();*/

            /*var trie = new Trie<int>();
            trie.Add("hello", 50);
            trie.Add("world", 100);
            trie.Add("hell", 200);

            trie.Remove("hell");
            Search(trie, "hell");*/

            /*var list = new List<int>();
            list.Add(20);
            list.Add(11);
            list.Add(7);
            list.Add(4);
            list.Add(13);
            list.Add(15);
            list.Add(14);

            var heap = new Heap(list);

            foreach (var item in heap)
            {
                Console.WriteLine(item);
            }*/

            var graph = new Graph();
            var v1 = new Vertex(1);
            var v2 = new Vertex(2);
            var v3 = new Vertex(3);
            var v4 = new Vertex(4);
            var v5 = new Vertex(5);
            var v6 = new Vertex(6);
            var v7 = new Vertex(7);

            graph.Add_Vertex(v1);
            graph.Add_Vertex(v2);
            graph.Add_Vertex(v3);
            graph.Add_Vertex(v4);
            graph.Add_Vertex(v5);
            graph.Add_Vertex(v6);
            graph.Add_Vertex(v7);

            graph.Add_Edge(v1, v2);
            graph.Add_Edge(v1, v3);
            graph.Add_Edge(v3, v4);
            graph.Add_Edge(v2, v5);
            graph.Add_Edge(v2, v6);
            graph.Add_Edge(v6, v5);
            graph.Add_Edge(v5, v6);

            GetMatrix(graph);
            Console.WriteLine("\n");

            Console.WriteLine("L I S T:\n");
            Getvertex(graph, v1);
            Getvertex(graph, v2);
            Getvertex(graph, v3);
            Getvertex(graph, v4);
            Getvertex(graph, v5);
            Getvertex(graph, v6);
            Getvertex(graph, v7);

            Console.ReadKey();
        }

        private static void GetMatrix(Graph graph)
        {
            var matrix = graph.GetMatrix();

            Console.WriteLine("M A T R I X:\n");
            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write($"    {i + 1}  ");
            }
            Console.WriteLine();

            for (int i = 0; i < graph.VertexCount; i++)
            {
                Console.Write(i + 1);
                for (int j = 0; j < graph.EdgeCount; j++)
                {
                    Console.Write(" | " + matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }

        private static void Getvertex(Graph graph, Vertex vertex)
        {
            Console.Write(vertex.Number + ": ");
            foreach (var v in graph.GetVertexList(vertex))
            {
                Console.Write(v.Number + ", ");
            }
            Console.WriteLine();
        }

        private static void Search(Trie<int> trie, string word)
        {
            if (trie.TrySearch(word, out int value))
            {
                Console.WriteLine(word + " " + value);
            }
            else
            {
                Console.WriteLine(word + "wasn't found.");
            }

        }
    }
}
