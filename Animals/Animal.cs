using System;
using System.Collections.Generic;
using System.Text;

namespace evoHaziFeladat.Animals
{
    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Species { get; set; }

        public Animal()
        {

        }

        public Animal(int age, string name, int weight, string species)
        {
            Age = age;
            Name = name;
            Weight = weight;
            Species = species;
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating...");
        }

    }
}
