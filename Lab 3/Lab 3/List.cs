using System;

namespace Lab_3
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
        
        public void Remove()
        {
            if (IsEmpty)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            Count--;
        }

        public void HeapSort()
        {
            
        }

        private void Heapify(int i, int n)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            int max = i;

            if (left <= n && _array[left].CompareTo(_array[max]) == 1)
            {
                max = left;
            }

            if (right <= n && _array[right].CompareTo(_array[max]) == 1)
            {
                max = right;
            }

            if (max != i)
            {
                T temp = _array[max];
                _array[max] = _array[i];
                _array[i] = temp;
                
                Heapify(max, n);
            }
        }
    }
}