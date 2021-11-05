using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomStack<string> stack = new CustomStack<string>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split();
                if (tokens[0] == "Push")
                {
                    stack.Push(string.Concat(tokens.Skip(1)).Split(","));
                }
                else
                {
                    stack.Pop();
                }
            }

            foreach(var item in stack)
                Console.WriteLine(item.ToString());
            foreach(var item in stack)
                Console.WriteLine(item.ToString());
        }
    }
}
