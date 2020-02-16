using DuplexLinkedList.Model;
using Ring_List.Model;
using Stack.Model;
using Queue.Model;
using Set.Model;
using HashTable.Model;
using Dictionary.Model;
using System;
using System.Collections.Generic;
using Binary_Search_Tree.Model;

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
            Console.WriteLine();*/

            /*var dictionary = new Dictionary.Model.Dictionary<int, string>();
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
            }*/

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
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
