using System;
using System.Collections.Generic;
namespace Stack
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        MyStack<string> mystack = new MyStack<string>();

    //        System.Console.WriteLine(mystack.Size());
    //        System.Console.WriteLine(mystack.Peek());

    //        mystack.Push("first");
    //        mystack.Push("second");

    //        System.Console.WriteLine(mystack.Empty());
    //        System.Console.WriteLine(mystack.Size());

    //        mystack.Push("third");
    //        mystack.Push("fourth");

    //        while (!mystack.Empty())
    //        {
    //            System.Console.WriteLine(mystack.Peek());
    //            mystack.Pop();
    //        }

    //        mystack.Pop();
    //        System.Console.WriteLine(mystack.Empty());

    //    }
    //}

    class Program
    {
        static int[,] array;
        static int n = 0;
        static MyStack<KeyValuePair<int, int>> mystack = new MyStack<KeyValuePair<int, int>>();
        public static void Main(string[] args)
        {

            Console.WriteLine("Ввести размер массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n, n];
            Fill();
            Print();
            toString(Count());
            mystack.Push(new KeyValuePair<int, int>(3, 2));
            while (!mystack.Empty())
            {
                FloodFill(mystack.Pop(), 2, 0);
            }
            Console.WriteLine();
            Print();
            toString(Count());
            Console.WriteLine("Success");
            Console.ReadKey();
        }

        public static void Fill()  //Заполнение
        {
            Random r = new Random(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Convert.ToInt32(r.Next(0, 4)) == 3)
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                }
            }
        }

        public static void Print()     //Печать
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void FloodFill(KeyValuePair<int, int> pair, int color, int point)  //Закраска
        {
            if ((pair.Key >= 0) && (pair.Value >= 0) && (pair.Key < n) && (pair.Value < n) && array[pair.Key, pair.Value] == point)
            {
                array[pair.Key, pair.Value] = color;
                mystack.Push(new KeyValuePair<int, int>(pair.Key + 1, pair.Value));
                mystack.Push(new KeyValuePair<int, int>(pair.Key - 1, pair.Value));
                mystack.Push(new KeyValuePair<int, int>(pair.Key, pair.Value + 1));
                mystack.Push(new KeyValuePair<int, int>(pair.Key, pair.Value - 1));
            }
        }

        public static int[] Count()   //Счетчик
        {
            int[] counts = new int[3];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i, j] == 0)
                    {
                        counts[0]++;
                    }
                    if (array[i, j] == 1)
                    {
                        counts[1]++;
                    }
                    if (array[i, j] == 2)
                    {
                        counts[2]++;
                    }
                }
            }

            return counts;
        }

        public static void toString(int[] array)   //Напечатать счетчик
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
