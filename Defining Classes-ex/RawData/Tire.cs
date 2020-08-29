using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Tire
    {
        public double Pressure { get; set; }
        public int Age { get; set; }

        public Tire(double p, int a)
        {
            Pressure = p;
            Age = a;
        }
    }
}
