using System;

namespace Lab_3
{
    public class List<T> where T : IComparable
    {
        private T[] _array;
        
        public int Count { get; private set; }
    }
}