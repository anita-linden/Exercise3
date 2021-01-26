using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public int GetAge(Person pers)
        {
            return pers.Age;
        }

        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public double GetWeight(Person pers)
        {
            return pers.Weight;
        }

        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public double GetHeight(Person pers)
        {
            return pers.Height;
        }

        public void ChangeFirstName(Person pers, string fname)
        {
            pers.FName = fname;
        }

        public void ChangeLastName(Person pers, string lname)
        {
            pers.LName = lname;
        }

        public string GetFirstName(Person pers)
        {
            return pers.FName;
        }

        public string GetLastName(Person pers)
        {
            return pers.LName;
        }

        public string GetName(Person pers)
        {
            return $"{pers.FName} {pers.LName}";
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person(fname, lname);
            SetAge(p, age);
            SetHeight(p, height);
            SetWeight(p, weight);

            return p;
        }

        public void PrintPerson(Person pers)
        {
            Console.WriteLine($"{GetName(pers)}\n" +
                $"Age: {pers.Age}\n" +
                $"Height: {pers.Height}\n" +
                $"Weight: {pers.Weight}");
        }
    }
}
