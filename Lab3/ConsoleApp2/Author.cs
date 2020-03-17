using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }

        public Author() : base()
        {
            Nationality = "Unkown";
        }

        public Author(string _name, string _surname, string _nationality)
            : base(_name, _surname)
        {
            Nationality = _nationality;
        }

        public override string ToString()
        {
            return base.ToString() + $"Nationality: {Nationality}\n";
        }
    }
}
