using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            int count = 0;
            string input;

            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (input.Length == 8)
                {
                    if (input[0] > 47 && input[0] < 58)
                    {
                        VIP.Add(input);
                    }
                    else
                    {
                        regular.Add(input);
                    }
                    count++;
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (input[0] > 47 && input[0] < 58 && VIP.Contains(input))
                {
                    VIP.Remove(input);
                    count--;
                }
                else if (regular.Contains(input))
                {
                    regular.Remove(input);
                    count--;
                }
            }

            Console.WriteLine(count);
            foreach (var vip in VIP)
            {
                Console.WriteLine(vip);
            }
            foreach (var reg in regular)
            {
                Console.WriteLine(reg);
            }
        }
    }
}
