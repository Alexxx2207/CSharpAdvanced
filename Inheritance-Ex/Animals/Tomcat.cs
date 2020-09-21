using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        public override string ProduceSound()
        {
            return "MEOW";
        }
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
            Type = "Tomcat";
        }
    }
}
