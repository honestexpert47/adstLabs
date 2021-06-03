using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>(5);
            
            list.Add(30);
            list.Add(21);
            list.Add(7);
            list.Add(15);
            list.Add(17);
            
            Console.WriteLine(list);
            
            list.Separate(list);
            
            Console.WriteLine(list);
        }
    }
}