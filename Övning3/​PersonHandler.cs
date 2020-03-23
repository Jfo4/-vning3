using System;
using System.Collections.Generic;
using System.Text;

    
namespace Övning3
{
    class PersonHandler
    {
        //public int Age { get; set; }
        //public string Fname { get; set; }
        //public string Lname { get; set; }
        //public double Height { get; set; }
        //public double Weight { get; set; }

        //private int age;
        //private string fname;
        //private string lname;
        //double height;
        //double weight;

        List<Person> personList;
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public PersonHandler()
        {
            personList = new List<Person>();
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person persontemp = new Person(age, fname, lname, height, weight);
            personList.Add(persontemp);
            return persontemp;
        }
        //public void AddPerson(Person person) => personList.Add(person);
     


        //public Person CreatePerson​(int age​, string ​fname​, string ​lname​, double ​height​, double ​weight​)
        //{
        //1
        //Person create = new Person();
        //create.Age = age;
        //create.FName = fname;

        //return create;

        //2
        //return  new Person
        // {
        //     Age = age,
        //     FName = fname
        // };

        //3
        //  return new Person(age, fname, lname, height,weight):
        // }

    }
}