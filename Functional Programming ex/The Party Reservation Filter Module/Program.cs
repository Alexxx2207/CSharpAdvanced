using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            List<string> filterList = new List<string>();

            //filter types
            // 0 -> default word
            // 1 -> filter parameter
            Predicate<string[]> StartWith = tokens => tokens[0].Substring(0, tokens[1].Length) == tokens[1];
            Predicate<string[]> EndsWith = tokens => tokens[0].Substring(tokens[0].Length - tokens[1].Length, tokens[1].Length) == tokens[1];
            Predicate<string[]> Length = tokens => tokens[0].Length == int.Parse(tokens[1]);
            Predicate<string[]> Contains = tokens => tokens[0].Contains(tokens[1]);

            Action<List<string>, string> AddFilter = (list, filter) => list.Add(filter);
            Action<List<string>, string> RemoveFilter = (list, filter) => { if (list.Contains(filter)) list.Remove(filter); };

            Action<List<string>, string> ExecuteFilter = (list, filter) =>
            {
                string[] parts = filter.Split(';');
                if (parts[0] == "Starts with")
                {
                    list.RemoveAll(guest => StartWith(new string[2] { guest, parts[1] } ));
                }
                else if (parts[0] == "EndsWith")
                {
                    list.RemoveAll(guest => EndsWith(new string[2] { guest, parts[1] }));
                }
                else if (parts[0] == "Length")
                {
                    list.RemoveAll(guest => Length(new string[2] { guest, parts[1] }));
                }
                else
                {
                    list.RemoveAll(guest => Contains(new string[2] { guest, parts[1] }));
                }
            };

            string input;

            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(';');

                switch (tokens[0])
                {
                    case "Add filter":
                        AddFilter(filterList, tokens[1] + ";" + tokens[2]);
                        break;
                    case "Remove filter":
                        RemoveFilter(filterList, tokens[1] + ";" + tokens[2]);
                        break;
                    default:
                        break;
                }
            }
            foreach (var filter in filterList)
            {
                ExecuteFilter(guests, filter);
            }

            Action<List<string>> print = list => Console.WriteLine(string.Join(" ", list));
            print(guests);
        }
    }
}
