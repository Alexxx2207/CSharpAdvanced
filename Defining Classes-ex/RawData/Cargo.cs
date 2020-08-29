using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
        public Cargo(int w, string t)
        {
            CargoWeight = w;
            CargoType = t;
        }
    }
}
