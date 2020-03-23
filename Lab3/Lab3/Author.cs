using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Author : Person
    {
        private string nationality;

        public string Nationality { get => nationality; set => nationality = value; }
        
        public Author():
            base()
        {
            nationality = ("--");
        }

        public Author(string name_, string surname_, string nationality_):
            base(name_, surname_)
        {
            nationality = nationality_;
        }

        

        public override string ToString()
        {
            return base.ToString() + $", Nationality: {nationality}";
        }
    }
}
