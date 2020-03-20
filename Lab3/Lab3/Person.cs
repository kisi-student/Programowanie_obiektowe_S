using System;

namespace Lab3
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
                throw new Exception("Could not instantiate Person object. Ivalid contruction params.");
            }
            _name = name;
            _surname = surname;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{_name} {_surname}");
        }
    }
}
