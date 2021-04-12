using System;

namespace Lab_1
{
    public class List<T> where T : IComparable
    {
        public int Length { get; private set; }
        
        public Node<T> First { get; private set; }
        
        public bool IsEmpty => Length == 0;
    }
}