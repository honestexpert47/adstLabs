using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(40);
            list.Add(41);
            list.Add(-11);
            list.Add(1);
            list.Add(5);
            list.Add(8);
            
            Console.WriteLine(list);
            Console.WriteLine(list.Length);
            Console.WriteLine(list.IsEmpty);
            list.Delete(5);
            Console.WriteLine(list);
            Console.WriteLine(list.Length);
            Console.WriteLine(list.IndexOf(8));
            Console.WriteLine(list.IndexOf(8, list.First));
        }
    }
}