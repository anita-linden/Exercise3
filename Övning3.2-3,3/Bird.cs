using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Bird : Animal
    {
        public bool Flightless { get; set; }

        public Bird(int age, double weight, bool flightless) : base(age, weight)
        {
            Name = "Bird";
            Flightless = flightless;
        }

        public override void DoSound()
        {
            Console.WriteLine("SKREEEEEEEEE\n");
        }

        public override string Stats()
        {
            return base.Stats()+$"Flightless: {Flightless}\n";
        }
    }
}
