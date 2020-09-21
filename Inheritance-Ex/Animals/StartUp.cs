using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input;

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] info = Console.ReadLine().Split();
                if (int.TryParse(info[0], out int age) && !string.IsNullOrWhiteSpace(info[0]) && !string.IsNullOrWhiteSpace(info[2]))
                {
                    if (age >= 0 && info.Length == 3)
                    {
                        if (input == "Dog")
                        {
                            animals.Add(new Dog(info[0], age, info[2]));
                        }
                        else if (input == "Cat")
                        {
                            animals.Add(new Cat(info[0], age, info[2]));

                        }
                        else if (input == "Frog")
                        {
                            animals.Add(new Frog(info[0], age, info[2]));

                        }
                        else if (input == "Tomcat")
                        {
                            if (info[2] == "Male")
                            {
                                animals.Add(new Tomcat(info[0], age)); 
                            }
                            else
                            {
                                throw new ArgumentException("Invalid input!");
                            }

                        }
                        else if (input == "Kitten")
                        {
                            if (info[2] == "Female")
                            {
                                animals.Add(new Kitten(info[0], age)); 
                            }
                            else
                            {
                                throw new ArgumentException("Invalid input!");
                            }
                        }
                        else
                        {
                            throw new ArgumentException("Invalid input!");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    } 
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Type);
                Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                Console.WriteLine(animal.ProduceSound());
            }
        }
    }
}
