using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T>
    {
        public MyStack()
        {
            array = new T[size];
        }
    

        public int size = 1;
        public T[] array;
       
        public void Push(T item)
        {
            Array.Resize<T>(ref array, ++size);
            array[size - 1] = item;
        }

        public T Pop()
        {
            if (size <= 1)
            {
                size = 1;
                return array[size - 1];
            }
            else
            {
                var buf = array[size - 1];
                Array.Resize<T>(ref array, --size);

                return buf;
            }
        }

        public int Size()
        {
            return size - 1;
        }

        public T Peek()
        {
            if (size <= 1)
            {
                size = 1;
                return array[size - 1];
            }
            else
            {
                return array[size - 1];
            }
        }

        public bool Empty()
        {
            if (size - 1 == 0)
                return true;
            else
                return false;
        }
    }
}
