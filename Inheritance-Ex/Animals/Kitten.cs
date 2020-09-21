using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Cat
    {
        public override string ProduceSound()
        {
            return "Meow";
        }
        public Kitten(string name, int age) : base(name, age, "Female")
        {
            Type = "Kitten";
        }
    }
}
