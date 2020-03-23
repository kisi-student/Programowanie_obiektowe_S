using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Person()
        {
            name = ("--");
            surname = ("--");
        }

        public Person(string name_, string surname_)
        {
            name = name_;
            surname = surname_;
        }

        public override string ToString()
        {
            return $"Person Details | Name: {name}, Surname: {surname}";
        }
    }
}
