using System;

namespace Övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person()
            //{
            //    Fname = "Bo",
            //    Lname = "Ek",
            //    Age = 48,
            //    Height = 1.78,
            //    Weight = 88
            //};
            //Console.WriteLine($"{person.Fname} {person.Lname} är {person.Age} år.");
            //Console.WriteLine($"Längd: {person.Height}, vikt: {person.Weight}, BMI: {person.Weight / person.Height / person.Height:F1}.");

            //Console.ReadLine();

            PersonHandler handler = new PersonHandler();
            Person person = handler.CreatePerson(34, "Bosse", "Larsson", 1.85, 75);
            
            handler.SetAge(person, 24);
            handler.SetWeight(person, 73.4);

            // Hur läggar jag till personer i listan?
            
            Console.WriteLine($"{person.Fname} {person.Lname} är {person.Age} år.");
            Console.WriteLine($"Längd: {person.Height:F2}, vikt: {person.Weight:F1}, BMI: {person.Weight / person.Height / person.Height:F1}.");

            Console.ReadLine();
        }
    }
}
