using System;

namespace Övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Fname = "Bo",
                Lname = "Ek",
                Age = 48,
                Height = 1.78,
                Weight = 88
            };

            Console.WriteLine($"{person.Fname} {person.Lname} är {person.Age} år.");
            Console.WriteLine($"Längd: {person.Height}, vikt: {person.Weight}, BMI: {person.Weight/person.Height/person.Height:F1}.");

            Console.ReadLine();
        }
    }
}
