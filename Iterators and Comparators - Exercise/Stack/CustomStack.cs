using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class CustomStack<T> : IEnumerable<T>
    {
        Stack<T> stack;


        public CustomStack()
        {
            stack = new Stack<T>();   
        }

        public void Push(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                stack.Push(item);
            }
        }
        
        public void Pop()
        {
            if(stack.Any())
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            T[] elements = stack.ToArray();
           
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
