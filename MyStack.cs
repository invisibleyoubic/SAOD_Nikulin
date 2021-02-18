using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T>
    {
        public MyStack()
        {

        }

        public int size = 0;
        public T[] array = new T[100];

        public void Push(T item)
        {
            array[++size] = item;
        }

        public T Pop()
        {
            if (size == 0)
                return array[size];
            else
                return array[size--];
        }

        public int Size()
        {
            return size;
        }

        public T Peek()
        {
            return array[size];
        }

        public bool Empty()
        {
            if (size == 0)
                return true;
            else
                return false;
        }
    }
}
