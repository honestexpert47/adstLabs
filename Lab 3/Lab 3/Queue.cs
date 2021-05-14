namespace Lab_3
{
    public class Queue<T>
    {
        private Node<T>[] _array;

        public int Count { get; private set; }
        
        public bool IsEmpty => Count == 0;

        public bool IsFull => Count == _array.Length;
    }
}