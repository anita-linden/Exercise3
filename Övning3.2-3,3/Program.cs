using System;
using System.Collections.Generic;

namespace Exercise3._2_3_3
{
    //3.2 Arv
    //13. Vart vi ska lägga nya attribut för alla fåglar är i Bird klassen, då den delas av alla
    //14. I fallet att alla djur ska ha det så läggs det i Animal

    //3.3 Polymorfism
    //9. Man kan inte konvertera två klasser mellan varandra bara för att de ärver från samma klass.
    //   De må dela Animal, men har annars unik kod, och ingen som helst referens till varandra. De är utanför varandras scope.
    //10.Listan måste vara Animal för att delas av alla Animal ärvande klasser. Enligt samma princip, om man hade en Bird lista
    //   så kan Flamingo och Pelican vara i den listan, men inte Dog och Horse.
    //13.foreach loopen går igenom varje klass i listan och kallar deras Stats metod. vare stats returnerar strängen från sin basmetod med  
    //   ny text inkluderad, så vi får informationen från varje nivå av klassen.
    //17.Animal känner inte till metoder i Dog, så när vi använder en Animal referens till klassen så ser vi inte dessa metoder

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Animals.Add(new Bird(2, 0.3, true));
            Animals.Add(new Swan(3, 1.5, 4));
            Animals.Add(new Wolfman(34, 78));
            Animals.Add(new Dog(3, 35, true));
            Animals.Add(new Dog(1, 40, false));

            List<Dog> Dogs = new List<Dog>();
            //Dogs.Add(new Horse(5, 100, "Beige"));

            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.Stats());
                animal.DoSound();

                if (animal is IPerson)
                {
                    (animal as IPerson).Talk();
                }
            }

            foreach (Animal animal in Animals)
            {
                if (typeof(Dog).Equals(animal.GetType()))
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine((animal as Dog).TestString());
                }
            }
        }
    }
}
