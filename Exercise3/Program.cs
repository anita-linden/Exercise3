using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Separated by spaces, input first name, last name, age, height and weight:");
            string[] input = Console.ReadLine().Split();
            /*try { Person person = new Person(input[0], input[1]); }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }*/

            PersonHandler pHandler = new PersonHandler();
            Person p;

            try { 
                p = pHandler.CreatePerson(int.Parse(input[2]), input[0], input[1], double.Parse(input[3]), double.Parse(input[4]));
                pHandler.PrintPerson(p);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            
        }
    }
}
