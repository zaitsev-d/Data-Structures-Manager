using System.Collections;

namespace Linked_List.Structure
{
    public class LinkedList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }

        public LinkedList() => Clear();

        public LinkedList(T data) => Set(data);

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Set(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void Add(T data)
        {
            var item = new Item<T>(data);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                Set(data);
            }
        }

        public void Delete(T data)
        {
            if (Head != null)
            {
                //If need delete first element
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head;
                var previous = Head;

                while (current.Next != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                }

                previous = current;
                current = current.Next;
            }
            else
            {
                Set(data);
            }
        }

        //Добавить данные в начала списка
        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };
            Head = item;
            Count++;
        }

        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Linked List: " + Count + " elements";
        }
    }
}
