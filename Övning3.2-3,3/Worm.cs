using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Worm:Animal
    {
        public bool IsPoisonous { get; set; }

        public Worm(int age, double weight, bool poison) : base(age, weight)
        {
            Name = "Worm";
            IsPoisonous = poison;
        }

        public override void DoSound()
        {
            Console.WriteLine("... *too silent to hear*\n");
        }

        public override string Stats()
        {
            return base.Stats() + $"Poisonous: {IsPoisonous}\n";
        }
    }
}
