using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Swan:Bird
    {
        public int ChildrenCarriedOnBack { get; set; }

        public Swan(int age, double weight, int chicks) : base(age, weight, false)
        {
            ChildrenCarriedOnBack = chicks;
            Name = "Swan";
        }

        public override string Stats()
        {
            return base.Stats() + $"How many chicks it carries: {ChildrenCarriedOnBack}\n";
        }
    }
}
