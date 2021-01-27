using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Flamingo:Bird
    {
        public bool SeesYou { get; set; }

        public Flamingo(int age, double weight):base(age,weight,false)
        {
            Name = "Flamingo";
            SeesYou = false;
        }

        public override string Stats()
        {
            return base.Stats() + $"Sees you: {SeesYou}\n";
        }
    }
}
