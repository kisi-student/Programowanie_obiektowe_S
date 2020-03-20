using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Person
    {
        protected string _name;
        protected string _surname;

        public Person()
        {
            _name = "none";
            _surname = "none";
        }

        public Person(string name, string surname)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                throw new Exception("Could not add Name and Surname which are null");
            }
            _name = name;
            _surname = surname;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {_name} Surname: {_surname}\n");
        }
    }
}
