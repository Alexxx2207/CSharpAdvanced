using System;
using System.Collections.Generic;

namespace Stacks_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> chars = new Stack<char>(Console.ReadLine());

            while (chars.Count != 0)
            {
                Console.Write(chars.Pop());
            }
        }
    }
}
