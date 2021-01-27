using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Dog:Animal
    {
        public bool Neutered { get; set; }

        public void Neuter() { Neutered = true; }

        public Dog(int age, double weight, bool neutered) : base(age, weight)
        {
            Name = "Dog";
            Neutered = neutered;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof\n");
        }

        public override string Stats()
        {
            return base.Stats() + $"Neutered: {Neutered}\n";
        }

        public string TestString()
        {
            return "Is this printing? Hello?";
        }
    }
}
