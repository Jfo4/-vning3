using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Fname
        {
            get { return fName; }
            set { fName = value; }
        }
        public string Lname
        {
            get { return lName; }
            set { lName = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
