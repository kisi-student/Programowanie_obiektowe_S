using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Author
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Author()
        { }
        public Author(string _firstname, string _lastname)
        {
            Firstname = _firstname;
            Lastname = _lastname;
        }
    }
}
