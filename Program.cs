using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static int[,] array;
        public static int n = 0;
        public static void Main(string[] args)
        {
            n = Convert.ToInt32(Console.ReadLine());
            array = new int[n, n];
            Fill();
            Print();
            toString(Count());
            FloodFill(3, 2, 2, 0);
            Console.WriteLine();
            Print();
            toString(Count());
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

        public static void FloodFill(int x, int y, int color, int point)  //Закраска
        {
            if ((x >= 0) && (y >= 0) && (x < n) && (y < n) && array[x, y] == point)
            {
                array[x, y] = color;
                FloodFill(x + 1, y, color, point);
                FloodFill(x - 1, y, color, point);
                FloodFill(x, y + 1, color, point);
                FloodFill(x, y - 1, color, point);
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

