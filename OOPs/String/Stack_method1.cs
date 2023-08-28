using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    internal class Stack_method1
    {

        static void Main(string[] args)
        {

            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);


            stack.Pop();
            stack.Pop();// remove the top element
            // Peek() -- returns the top element in the stack
            Console.WriteLine("Top element " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
