using System;
using evoHaziFeladat.Animals;
using System.Linq;
using System.Collections.Generic;

namespace evoHaziFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();

            Animal doggo = new Dog(); //bal oldali a fordítási
            //jobb oldali a futási idő
            Animal kitty = new Cat();

            //Overloading(dog);

            dog.Eat();
            cat.Eat();
            doggo.Eat();
            kitty.Eat();

            List<Dog> kutyak = new List<Dog>();
            int[] eletkor = { 12, 3, 5, 8, 9 };
            string[] nevek = { "Pucu", "Répa", "Manó", "Rox", "Keksz" };
            int[] suly = { 32, 5, 12, 7, 30 };
            string[] fajta = { "Német törpe", "Golden Retriever", "Huski", "Virsli", "Perzsa" };
            Random r = new Random();
            for(int i = 0; i < 20; i++)
            {
                Dog egy = new Dog(eletkor[r.Next(0, 5)],nevek[r.Next(0, 5)], suly[r.Next(0, 5)], fajta[r.Next(0, 5)]);
                kutyak.Add(egy);
            }

            foreach (var item in kutyak)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nHuskik:");
            //List<feladat> egyediek = rendezettLista.GroupBy(e => e.telefonszám).Select(e => e.First()).ToList();
            List<Dog> huskik = kutyak.Where(x => x.Species.Equals("Huski")).ToList();
            foreach (var item in huskik)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSúly: 10 fölött és 8-nál kisebb");
            List<Dog> tizfolott = kutyak.Where(x => x.Weight > 10 & x.Age < 8).ToList();
            foreach (var item in tizfolott)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nSúly 31 és 11 kg közötti virsli kutyák");
            List<Dog> virslik = kutyak.Where(x => x.Weight > 11 & x.Weight < 31 & x.Species.Equals("Virsli")).ToList();
            foreach (var item in virslik)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();
        }

        public static void Overloading(Dog dog)
        {
            dog.Bark();
            dog.Bark("Jani");
        }

    }
}
