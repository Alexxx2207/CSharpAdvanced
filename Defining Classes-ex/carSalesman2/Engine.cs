using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        public string Model { get; set; }
        public int Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string m, int p)
        {
            Model = m;
            Power = p;
            Displacement = "n/a";
            Efficiency = "n/a";
        }
        public Engine(string m, int p, int d) : this(m, p)
        {
            Displacement = d.ToString();
        }
        public Engine(string m, int p, string e) : this(m, p)
        {
            Efficiency = e;
        }
        public Engine(string m, int p, string d, string e)
        {
            Model = m;
            Power = p;
            Displacement = d;
            Efficiency = e;
        }
    }
}
