using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set.Structure
{
    public class LiteSet<T> : IEnumerable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public LiteSet() { }

        public LiteSet(T item)
        {
            items.Add(item);
        }

        public LiteSet(IEnumerable<T> items)
        {
            this.items = items.ToList();
        }

        public void Add(T item)
        {
            if (items.Contains(item)) return;
            items.Add(item);
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public LiteSet<T> Union(LiteSet<T> set)
        {
            LiteSet<T> result = new LiteSet<T>();
            foreach (var item in items)
            {
                result.Add(item);
            }

            foreach (var item in set.items)
            {
                result.Add(item);
            }

            return result;
        }

        public LiteSet<T> Intersection(LiteSet<T> set)
        {
            var result = new LiteSet<T>();
            LiteSet<T> big;
            LiteSet<T> small;

            if(Count >= set.Count)
            {
                big = this;
                small = set;
            }
            else
            {
                big = set;
                small = this;
            }

            foreach(var item1 in small.items)
            {
                foreach(var item2 in big.items)
                {
                    if(item1.Equals(item2))
                    {
                        result.Add(item1);
                        break;
                    }
                }
            }

            return result;
        }

        public LiteSet<T> Difference(LiteSet<T> set)
        {
            var result = new LiteSet<T>(items);

            foreach(var item in set.items)
            {
                result.Remove(item);
            }

            return result;
        }

        public bool Subset(LiteSet<T> set)
        {
            foreach(var item1 in items)
            {
                var equals = false;

                foreach(var item2 in set.items)
                {
                    if(item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }

                if (!equals) return false;
            }

            return true;
        }

        public LiteSet<T> SymmetricDifference(LiteSet<T> set)
        {
            var result = new LiteSet<T>();

            foreach(var item1 in items)
            {
                var equals = false;

                foreach(var item2 in set.items)
                {
                    if(item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }

                if(equals == false) result.Add(item1);
                
            }

            foreach (var item1 in set.items)
            {
                var equals = false;

                foreach (var item2 in items)
                {
                    if (item1.Equals(item2))
                    {
                        equals = true;
                        break;
                    }
                }

                if (equals == false) result.Add(item1);

            }

            return result;
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }
}
