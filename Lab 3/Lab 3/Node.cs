namespace Lab_3
{
    public class Node<T>
    {
        public T Data { get; set; }
        
        public int Priority { get; set; }

        public Node(T data, int priority)
        {
            Data = data;
            Priority = priority;
        }
    }
}