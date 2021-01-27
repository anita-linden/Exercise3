using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._4
{
    class FormatError : UserError
    {
        public override string UEMessage()
        {
            return "Text input may be a maximun of 30 characters.";
        }
    }
}
