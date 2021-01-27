using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._4
{
    class BoolError : UserError
    {
        public override string UEMessage()
        {
            return "You are trying to apply a boolean to a nonbool value how did you even send that?";
        }
    }
}
