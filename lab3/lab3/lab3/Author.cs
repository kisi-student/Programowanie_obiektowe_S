using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Author : Person
    {
        
        public string Nationality { get; set; }
        public Author()
        { }
        public Author(string _firstname, string _lastname, string _nationality) : base (_firstname, _lastname)
        {
            Nationality = _nationality;
        }
  

        public override string ToString()
        {
            return base.ToString() + $"Nationality: {Nationality}\n";
        }
    }
}
