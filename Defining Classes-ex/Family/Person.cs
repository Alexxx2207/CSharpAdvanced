using System;
using System.Collections.Generic;
using System.Text;

namespace Family
{
    public class Person
    {
        private string _name;
        private int _age;

        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) : this()
        {
            Age = age;
        }

        public Person(string name, int age) : this(age)
        {
            Name = name;
            Age = age;
        }
    }
}
