using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<double>(10);
            
            list.Add(15);
            list.Add(0);
            list.Add(78);
            list.Add(1);
            list.Add(10);
            list.Add(7);
            list.Add(-8);
            list.Add(7);
            list.Add(65);
            list.Add(18);
            
            Console.WriteLine(list);
            
            list.HeapSort();
            Console.WriteLine(list);
            
            Console.WriteLine(list.Count);
            Console.WriteLine(list.IsEmpty);
            Console.WriteLine(list.IsFull);
            
            list.Remove();
            
            Console.WriteLine(list);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.IsEmpty);
            Console.WriteLine(list.IsFull);

            var queue = new Queue<int>(10);
            
            queue.Enqueue(12, 5);
            queue.Enqueue(15, 15);
            queue.Enqueue(20, -5);
            queue.Enqueue(40, 4);
            
            Console.WriteLine(queue);
            
            Console.WriteLine(queue.Count);
            Console.WriteLine(queue.IsEmpty);
            Console.WriteLine(queue.IsFull);
            
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            
            queue.Enqueue(10, 100);
            
            Console.WriteLine(queue.Dequeue());
        }
    }
}