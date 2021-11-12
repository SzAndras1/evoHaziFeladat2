using System;
using System.Collections.Generic;
using System.Text;

namespace evoHaziFeladat.Animals
{
    public class Cat : Animal
    {
        public Cat()
        {

        }
        public Cat(int age, string name, int weight, string species) : base(age, name, weight, species)
        {

        }

        public new void Eat()
        {
            Console.WriteLine("Cat is eating...");
        }
    }
}
