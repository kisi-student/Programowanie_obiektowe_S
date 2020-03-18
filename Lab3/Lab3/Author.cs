using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Author
    {
        private string name;
        private string surname;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        
        public Author()
        {
            name = ("--");
            surname = ("--");
        }

        public Author(string name_, string surname_)
        {
            name = name_;
            surname = surname_;
        }

        public override string ToString()
        {
            return $"Auhtor Details | Name: {name}, Surname: {surname}";
        }
    }
}
