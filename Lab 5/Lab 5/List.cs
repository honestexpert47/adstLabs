using System;

namespace Lab_5
{
    public class List<T> where T : IComparable
    {
        private T[] _array;
        
        public int Count { get; private set; }
        
    }
}