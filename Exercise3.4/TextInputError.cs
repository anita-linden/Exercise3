using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3._4
{
    class TextInputError:UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field. This fired an error!";
        }
    }
}
