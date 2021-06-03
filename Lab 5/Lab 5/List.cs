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
    }
}