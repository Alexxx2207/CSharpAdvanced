using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public Pokemon(string n, string e, int h)
        {
            Name = n;
            Element = e;
            Health = h;
        }
    }
}
