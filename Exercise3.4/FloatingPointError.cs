using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._4
{
    class FloatingPointError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to implement a floating point number when an integer was expected!";
        }
    }
}
