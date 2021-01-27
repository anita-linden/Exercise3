using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(int age, double weight)
        {
            Age = age;
            Weight = weight;
        }

        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}\n" +
                $"Age: {Age}\n" +
                $"Weight: {Weight}\n";
        }
    }
}
