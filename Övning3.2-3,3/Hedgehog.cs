using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Hedgehog : Animal
    {
        public bool IsBlue { get; set; }

        public Hedgehog(int age, double weight, bool blue) : base(age, weight)
        {
            Name = "Hedgehog";
            IsBlue = blue;
        }

        public override void DoSound()
        {
            Console.WriteLine("HISSSSSSSSSS\n");
        }

        public override string Stats()
        {
            return base.Stats() + $"Is it blue? {IsBlue}\n";
        }
    }
}
