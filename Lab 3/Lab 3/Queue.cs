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
    }
}