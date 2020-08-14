using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            Stack<string> backUp = new Stack<string>();

            StringBuilder text = new StringBuilder();

            for (int i = 0; i < commands; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens[0] == "1")
                {
                    backUp.Push(text.ToString());
                    text.Append(tokens[1]);
                }
                else if (tokens[0] == "2")
                {
                    int count = int.Parse(tokens[1]);

                    if (count <= text.Length)
                    {
                        backUp.Push(text.ToString());
                        text.Remove(text.Length - count, count); 
                    }
                }
                else if (tokens[0] == "3")
                {
                    Console.WriteLine(text[int.Parse(tokens[1])-1]);
                }
                else
                {
                    if (backUp.Any())
                    {
                        text.Clear();
                        text.Append(backUp.Pop()); 
                    }
                }
            }
        }
    }
}
