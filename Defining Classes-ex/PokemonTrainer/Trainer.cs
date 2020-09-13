using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon_Trainer
{
    class Trainer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public Trainer(int id, string n)
        {
            ID = id;
            Name = n;
            NumberOfBadges = 0;
            Pokemons = new List<Pokemon>();
        }
    }
}
