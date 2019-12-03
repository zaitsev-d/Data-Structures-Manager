using DuplexLinkedList.Model;
using Ring_List.Model;
using Stack.Model;
using Queue.Model;
using System;
using System.Collections.Generic;

namespace Data_Structures_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue.Model.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine();

            var arrayQueue = new ArrayQueue<int>(10);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.WriteLine();

            var deque = new Deque.Model.Deque<int>();
            deque.PushFront(1);
            deque.PushFront(2);
            deque.PushFront(3);
            deque.PushBack(4);
            deque.PushBack(5);

            Console.WriteLine(deque.PopFront());
            Console.WriteLine(deque.PopFront());
            Console.WriteLine(deque.PopBack());
            Console.WriteLine(deque.PopBack());

            Console.ReadKey();
        }
    }
}
