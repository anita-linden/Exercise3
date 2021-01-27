using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._4
{
    public class NumericInputError:UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
}
