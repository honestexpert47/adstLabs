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
        }
    }
}