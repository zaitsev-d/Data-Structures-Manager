using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Structure
{
    public class Queue<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set; }

        public Queue() { }
        public Queue(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        public void Enqueue(T data)
        {
            var item = new Item<T>(data);
            if (Count == 0)
            {
                head = item;
                tail = item;
                Count = 1;
                return;
            }

            item.Next = tail;
            tail = item;
            Count++;
        }

        public T Dequeue()
        {
            var data = head.Data;
            var current = tail.Next;
            var previous = tail;

            while(current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            head = previous;
            head.Next = null;
            Count--;

            return data;
        }

        public T Peek()
        {
            return head.Data;
        }
    }
}
