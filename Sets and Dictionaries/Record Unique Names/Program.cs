﻿using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
