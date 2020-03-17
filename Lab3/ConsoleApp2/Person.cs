using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person()
        {
            Name = "Unknown";
            Surname = "Unkown";
        }

        public Person(string _name, string _surname)
        {
            Name = _name;
            Surname = _surname;
        }

        public override string ToString()
        {
            return $"Name:{Name} Surname{Surname}\n";
        }
    }
}
