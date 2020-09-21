using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Frog : Animal
    {
        public override string ProduceSound()
        {
            return "Ribbit";
        }
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
            Type = "Frog";
        }
    }
}
