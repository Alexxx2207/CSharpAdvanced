using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            
            Action<List<string>, string, string, string> filter = (list, command1, command2, actualFilter) =>
            {
                Predicate<string[]> StartWith = tokens => tokens[0].Substring(0, tokens[1].Length) == tokens[1];
                Predicate<string[]> EndsWith = tokens => tokens[0].Substring(tokens[0].Length - tokens[1].Length, tokens[1].Length) == tokens[1];
                Predicate<string[]> Length = tokens => tokens[0].Length == int.Parse(tokens[1]);

                command1 = command1.ToLower();
                command2 = command2.ToLower();

                if (command2 == "startswith")
                {
                    if (command1 == "remove")
                    {
                        list.RemoveAll(name => StartWith(new string[2] { name, actualFilter }));
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (StartWith(new string[2] { list[i], actualFilter }))
                            {
                                list.Insert(i, list[i]);
                                i++;
                            }
                        }

                    }
                }
                else if (command2 == "endswith")
                {
                    if (command1 == "remove")
                    {
                        list.RemoveAll(name => EndsWith(new string[2] { name, actualFilter })); 
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (EndsWith(new string[2] { list[i], actualFilter }))
                            {
                                list.Insert(i, list[i]);
                                i++;
                            }
                        }
                    }
                }
                else if (command2 == "length")
                {
                    if (command1 == "remove")
                    {
                        list.RemoveAll(name => Length(new string[2] { name, actualFilter })); 
                    }
                    else
                    {
                        for(int i = 0; i < list.Count; i++)
                        {
                            if (Length(new string[2] { list[i], actualFilter }))
                            {
                                list.Insert(i, list[i]);
                                i++;
                            }
                        }
                    }
                }
            };

            string input;

            while ((input = Console.ReadLine()) != "Party!")
            {
                string[] tokens = input.Split();

                filter(guests, tokens[0], tokens[1], tokens[2]);
            }
            if (guests.Any())
            {
                Console.WriteLine(string.Join(", ", guests) + " are going to the party!"); 
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
