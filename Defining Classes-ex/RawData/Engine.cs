using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }
        public Engine(int s, int p)
        {
            Speed = s;
            Power = p;
        }
    }
}
