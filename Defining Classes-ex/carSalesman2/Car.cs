using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }

        public Car(string m, Engine eng)
        {
            Model = m;
            Engine = eng;
            Weight = "n/a";
            Color = "n/a";
        }
        public Car(string m, Engine eng, int w) : this(m, eng)
        {
            Weight = w.ToString();
        }
        public Car(string m, Engine eng, string c) : this(m, eng)
        {
            Color = c;
        }
        public Car(string m, Engine eng, string w, string c)
        {
            Model = m;
            Engine = eng;
            Weight = w;
            Color = c;
        }
    }
}
