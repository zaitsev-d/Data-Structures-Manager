using DuplexLinkedList.Model;
using Ring_List.Model;
using Stack.Model;
using System;
using System.Collections.Generic;

namespace Data_Structures_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var ringList = new CircularLinkedList<int>();
            ringList.Add(1);
            ringList.Add(2);
            ringList.Add(3);
            ringList.Add(5);
            ringList.Add(6);

            foreach(var item in ringList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            ringList.Delete(3);

            foreach (var item in ringList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
