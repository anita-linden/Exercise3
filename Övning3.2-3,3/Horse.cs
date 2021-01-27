using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Horse : Animal
    {
        public string ManeColor { get; set; }
        public Horse(int age, double weight, string maneColor) : base(age, weight)
        {
            Name = "Horse";
            ManeColor = maneColor;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh!\n");
        }

        public override string Stats()
        {
            return base.Stats() + $"Mane Color: {ManeColor}\n";
        }
    }
}
