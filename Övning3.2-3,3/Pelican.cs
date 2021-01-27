using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Pelican : Bird
    {
        public bool HasFish { get; set; }

        public Pelican(int age, double weight) : base(age, weight, false) 
        {
            Name = "Pelican";
        }

        public override string Stats()
        {
            return base.Stats() + $"Fish in mouth: {HasFish}\n";
        }
    }
}
