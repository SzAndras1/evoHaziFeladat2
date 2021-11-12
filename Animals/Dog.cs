using System;
using System.Collections.Generic;
using System.Text;

namespace evoHaziFeladat.Animals
{
    public class Dog:Animal
    {
        public Dog()
        {

        }
        public Dog(int age, string name, int weight, string species) : base(age, name, weight, species)
        {

        }

        public void Bark()
        {
            Console.WriteLine("Wau wau");
        }

        public void Bark(string personToBarkAt)
        {
            Console.WriteLine("*Barking at {0}*", personToBarkAt);
        }

        public new void Eat()
        {
            Console.WriteLine("Dog is eating...");
        }

        public override string ToString()
        {
            return Age + " " + Name + " " + Weight+ " " + Species;
        }
    }


}

