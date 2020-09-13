using System;
using System.Collections.Generic;
using System.Linq;

namespace Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Trainer> listOfTrainers = new Dictionary<string, Trainer>();
            int counter = 0;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split();

                if (!listOfTrainers.ContainsKey(tokens[0]))
                {
                    listOfTrainers.Add(tokens[0], new Trainer(counter++, tokens[0])); ;
                }
                listOfTrainers[tokens[0]].Pokemons.Add(new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3])));
            }

            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in listOfTrainers)
                {
                    if (trainer.Value.Pokemons.Where(pokemon => pokemon.Element == input).Any())
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        trainer.Value.Pokemons.ForEach(x => x.Health -= 10);
                        if (trainer.Value.Pokemons.Where(x => x.Health <= 0).Any())
                        {
                            trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                        }
                    }
                }
            }
            listOfTrainers = listOfTrainers
                .OrderByDescending(trainer => trainer.Value.NumberOfBadges)
                .ThenBy(trainer => trainer.Value.ID)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var trainers in listOfTrainers)
            {
                Console.WriteLine($"{trainers.Key} {trainers.Value.NumberOfBadges} {trainers.Value.Pokemons.Count}");
            }
        }
    }
}
