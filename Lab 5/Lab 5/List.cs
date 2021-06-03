using System;

namespace Lab_5
{
    public class List<T> where T : IComparable
    {
        private T[] _array;
        
        public int Count { get; private set; }
        
        public bool IsEmpty => Count == 0;

        public bool IsFull => Count == _array.Length;
        
        public List(int max)
        {
            _array = new T[max];
            Count = 0;
        }
        
        public override string ToString()
        {
            if (IsEmpty) return "List is empty.";
            var res = "";
            for (int i = 0; i < Count; i++)
            {
                res += $"{_array[i]}\t";
            }
            return res;
        }
        
        public void Add(T item)
        {
            if (IsFull)
            {
                Console.WriteLine("List is full.");
                return;
            }
            _array[Count++] = item;
        }
    }
}