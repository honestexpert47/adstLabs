using System;

namespace Lab_3
{
    public class Queue<T>
    {
        private Node<T>[] _array;

        public int Count { get; private set; }
        
        public bool IsEmpty => Count == 0;

        public bool IsFull => Count == _array.Length;
        
        public Queue(int max)
        {
            _array = new Node<T>[max];
            Count = 0;
        }

        public override string ToString()
        {
            if (IsEmpty) return "Queue is empty.";
            var res = "";
            for (int i = 0; i < Count; i++)
            {
                res += $"{_array[i].Data}({_array[i].Priority})\t";
            }
            return res;
        }
        
        private void Heapify(int i, int n)
        {
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            int max = i;

            if (left < n && _array[left].Priority > _array[max].Priority)
            {
                max = left;
            }

            if (right < n && _array[right].Priority > _array[max].Priority)
            {
                max = right;
            }

            if (max != i)
            {
                var temp = _array[max];
                _array[max] = _array[i];
                _array[i] = temp;
                
                Heapify(max, n);
            }
        }

        public void Enqueue(T value, int priority)
        {
            if (IsFull)
            {
                Console.WriteLine("Queue is full.");
                return;
            }

            if (IsEmpty)
            {
                _array[Count++] = new Node<T>(value, priority);
            }

            else
            {
                _array[Count++] = new Node<T>(value, priority);
                for (int i = Count / 2 - 1; i >= 0; i--)
                {
                    Heapify(i, Count);
                }
            }
        }
    }
}