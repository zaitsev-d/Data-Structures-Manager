using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deque.Model
{
    public class Deque<T>
    {
        private Item<T> head;
        private Item<T> tail;
        public int Count { get; private set; }

        public Deque() { }

        public Deque(T data)
        {
            var item = new Item<T>(data);
            head = item;
            tail = item;
            Count = 1;
        }

        public void PushBack(T data)
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
            tail.Previous = item;
            tail = item;

            Count++;
        }

        public void PushFront(T data)
        {
            var item = new Item<T>(data);
            if (Count == 0)
            {
                head = item;
                tail = item;
                Count = 1;
                return;
            }

            
            item.Previous = head;
            head.Next = item;
            head = item;

            Count++;
        }

        public T PopBack()
        {
            if (Count > 0)
            {
                var result = tail.Data;
                var current = tail.Next;
                current.Previous = null;
                tail = current;

                Count--;
                return result;
            }
            else return default(T);
        }

        public T PopFront()
        {
            if (Count > 0)
            {
                var result = head.Data;
                var current = head.Previous;
                current.Next = null;
                head = current;

                Count--;
                return result;
            }
            else return default(T);
        }

        public T PeekBack()
        {
            return tail.Data;
        }

        public T PeekFront()
        {
            return head.Data;
        }
    }
}
