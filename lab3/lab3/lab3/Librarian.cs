using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Librarian : Person
    {
        public string DateOfEmployment { get; set; }
        public int Salary { get; set; }

        public Librarian() : base()
        { }
        public Librarian(string _firstname, string _lastname, string _dateOfEmployment, int _salary) : base (_firstname, _lastname)
        {
            DateOfEmployment = _dateOfEmployment;
            Salary = _salary;
        }
    }
}
