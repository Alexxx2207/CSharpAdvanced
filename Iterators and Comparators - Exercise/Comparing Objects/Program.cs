using System;
using System.Collections.Generic;

namespace Comparing_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] personInfo = input.Split();

                people.Add(new Person(personInfo[0], int.Parse(personInfo[1]), personInfo[2]));
            }

            int personIndex = int.Parse(Console.ReadLine());


            Person targetPerson = people[personIndex-1];

            int matches = 1;

            foreach (var person in people)
            {
                if (person.CompareTo(targetPerson) == 0 && !person.Equals(targetPerson))
                {
                    matches++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{matches} {people.Count - matches} {people.Count}");
            }
        }
    }
}
