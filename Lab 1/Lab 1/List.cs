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
        
        public void Add(T item)
        {
            Node<T> previous = null;
            var following = First;
            while (following != null && following.Data.CompareTo(item) == -1)
            {
                previous = following;
                following = following.Next;
            }
            Node<T> addedNode = new Node<T>(item);
            if (previous == null)
            {
                addedNode.Next = First;
                First = addedNode;
            }
            else
            {
                previous.Next = addedNode;
                addedNode.Next = following;
            }
            Length++;
        }
    }
}