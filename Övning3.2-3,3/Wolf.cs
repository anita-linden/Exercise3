using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Wolf : Animal
    {
        public bool Hungry { get; set; }

        public Wolf(int age, double weight, bool hungry) : base(age, weight)
        {
            Name = "Wolf";
            Hungry = hungry;
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl\n");
        }

        public override string Stats()
        {
            return base.Stats() + $"HUNGRY: {Hungry}\n";
        }
    }
}
