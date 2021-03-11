using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(1);
            Console.WriteLine(list.First());
            Console.WriteLine(list.Last());
            list.Insert(5, 9);
            Console.WriteLine($"Size = {list.Size()}");
            Console.WriteLine(list.Last());
            list.Insert(0, 6);

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.RemoveAt(0);

            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
