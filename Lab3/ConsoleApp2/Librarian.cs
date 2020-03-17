using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Librarian : Person
    {
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }

        public Librarian() : base()
        {
            EmploymentDate = new DateTime();
            Salary = 0.0;
        }

        public Librarian(string _name, string _surname, DateTime _employmentDate,
            double _salary) : base(_name, _surname)
        {
            EmploymentDate = _employmentDate;
            Salary = _salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"Salary:{Salary}, EmploymentDate:{EmploymentDate}\n";
        }
    }
}
