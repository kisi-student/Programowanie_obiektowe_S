using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Person
    {
        protected string Firstname { get; set; }
        protected string Lastname { get; set; }

        public Person()
        { }
        public Person(string _firstname, string _lastname)
        {
            Firstname = _firstname;
            Lastname = _lastname;
        }
        public override string ToString()
        {
            return $"Name: {Firstname}\nSurname: {Lastname}\n";
        }
    }
}
