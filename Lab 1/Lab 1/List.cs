using System;

namespace Lab_1
{
    public class List<T> where T : IComparable
    {
        public int Length { get; private set; }
        
        public Node<T> First { get; private set; }
        
        public bool IsEmpty => Length == 0;
        
        public List()
        {
            Length = 0;
        }
        
        public override string ToString()
        {
            if (IsEmpty) return "List is empty";
            string result = "";
            for (var i = First; i != null; i = i.Next)
            {
                result += $"{i.Data}\t";
            }
            return result;
        }
    }
}