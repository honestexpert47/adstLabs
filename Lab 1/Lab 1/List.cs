using System;

namespace Lab_1
{
    public class List<T> where T : IComparable
    {
        public int Length { get; private set; }
        
        public Node<T> First { get; private set; }
        
        public bool IsEmpty => Length == 0;
        
        private Node<T> this[int position]
        {
            get
            {
                if (!IsEmpty && position < Length)
                {
                    int counter = 0;
                    for (Node<T> i = First; i != null; i = i.Next)
                    {
                        if (counter == position) return i;
                        counter++;
                    }
                }
                throw new Exception("Incorrect position!");
            }
        }
        
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
        
        public int IndexOf(T item)
        {
            int counter = 0;
            for (Node<T> i = First; i != null; i = i.Next)
            {
                if (i.Data.Equals(item)) return counter;
                counter++;
            }
            return -1;
        }
        
        public void Delete(T item)
        {
            int position = IndexOf(item);
            if (position != -1)
            {
                if (position == 0)
                {
                    First = First.Next;
                }
                else if (position == Length - 1)
                {
                    this[Length - 2].Next = null;
                }
                else
                {
                    var prev = this[position - 1];
                    var next = this[position + 1];
                    prev.Next = next;
                }
                Length--;
            }
            else Console.WriteLine("Item Doesn't exist in the list.");
        }
    }
}