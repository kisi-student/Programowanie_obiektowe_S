using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _name = name;
            _surname = surname;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{_name} {_surname}");
        }
    }
}
