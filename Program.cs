using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> mystack = new MyStack<string>();

            System.Console.WriteLine(mystack.Size());
            System.Console.WriteLine(mystack.Peek());

            mystack.Push("first");
            mystack.Push("second");

            System.Console.WriteLine(mystack.Empty());
            System.Console.WriteLine(mystack.Size());

            mystack.Push("third");
            mystack.Push("fourth");

            while (!mystack.Empty())
            {
                System.Console.WriteLine(mystack.Peek());
                mystack.Pop();
            }

            mystack.Pop();
            System.Console.WriteLine(mystack.Empty());
        }
    }
}
