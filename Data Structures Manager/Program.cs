using DuplexLinkedList.Model;
using Ring_List.Model;
using Stack.Model;
using Queue.Model;
using Set.Model;
using System;
using System.Collections.Generic;

namespace Data_Structures_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var set1 = new LiteSet<int>(new int[] { 1, 2, 3, 4, 5 });
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

            Console.ReadKey();
        }
    }
}
