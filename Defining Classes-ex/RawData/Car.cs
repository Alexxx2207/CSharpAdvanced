using System;
using System.Collections.Generic;
using System.Text;

namespace Raw_Data
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }
        public Car(string m, Engine eng, Cargo cargo, Tire[] tires)
        {
            Model = m;
            Engine = eng;
            Cargo = cargo;
            Tires = tires;
        }
    }
}
