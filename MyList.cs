using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace list
{
    class MyList<T> : IEnumerable
    {
        static int size = 0;
        static T[] array = new T[size];

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < size; i++)
                yield return array[i];
        }

        public void Add(T item)
        {
            Array.Resize<T>(ref array, ++size);
            array[size - 1] = item;
        }

        public void Insert(int index, T item)
        {
            if(index > size)
            {
                size += index;
                Array.Resize<T>(ref array, size);
                array[index] = item;
            }
            if(index < 0)
            {
                throw new Exception("Index < 0");
            }
            if ((index >= 0) && (index < size))
            {
                array[index] = item;
            }
        }

        public void RemoveAt(int index)
        {
            if (index > size)
            {
                throw new Exception("Index > Size");
            }
            if (index > 0)
            {
                throw new Exception("Index < 0");
            }
            if ((index >= 0) && (index < size))
            {
                for(int i = index; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize<T>(ref array, --size);
            }
        }

        public T Last()
        {
            return array[size-1];
        }

        public T First()
        {
            return array[0];
        }

        public void Clear()
        {
            Array.Resize<T>(ref array, 0);
        }

        public int Size()
        {
            return size;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
