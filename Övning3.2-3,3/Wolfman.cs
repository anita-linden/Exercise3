using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._2_3_3
{
    class Wolfman:Wolf, IPerson
    {
        public Wolfman(int age, double weight) : base(age, weight, true)
        {
            Name = "Wolfman";
        }

        public void Talk()
        {
            Console.WriteLine("I'm hungry\n");
        }
    }
}
