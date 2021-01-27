using System;
using System.Collections.Generic;

//3.4 Polymorfism
//11.Polymorfism tillåter oss att implementera varianter av samma funktionalitet. Vi kan kalla grundmetoden utan att behöva veta
//   vilken variant some körs, t.ex genom en list av blandade klasser med samma bas.
//12.Vi förenklar implementationen av varianter för samma funktion. I annat fall kanske vi har flera metoder vi måste välja mellan genom en
//   if sats, men vi kan bara direkt köra "samma" metod i stället. Skillnaden är tydligast där klassen implementeras,
//   där vi antingen kan kalla en for loop eller direkt välja ut en instans från en lista eller array och kalla metoden utan
//   att behöva utföra någon ytterligare koll
//13.Abstrakt klass kan ha fält. Interface kan ärvas tillsammans med annan klass eller andra interface.
//   Varken den ena eller andra kan instantieras, men abstrakta klasser kan ändå innehålla implementationer,
//   medans interface bara innehåller metod definitioner.
namespace Exercise3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> errors = new List<UserError>();
            errors.Add(new NumericInputError());
            errors.Add(new TextInputError());
            errors.Add(new NumericInputError());
            errors.Add(new BoolError());
            errors.Add(new FormatError());
            errors.Add(new FloatingPointError());

            foreach (UserError error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
