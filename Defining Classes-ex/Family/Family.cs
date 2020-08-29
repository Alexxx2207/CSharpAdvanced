using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Family
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }
        public void AddMember(Person member)
        {
            people.Add(member);
        }
        public Person GetOldestMember()
        {
            Person oldest = people[0];

            for(int i = 1; i < people.Count; i++)
            {
                if (people[i].Age > oldest.Age)
                {
                    oldest = people[i];
                }
            }

            return oldest;
        }
        public void SortAndPrintMembers()
        {
            people = people.OrderBy(person => person.Name).ToList();

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
