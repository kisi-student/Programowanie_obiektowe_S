using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Librarian: Person
    {
        public string HireDate { get; set; }
        public double Salary { get; set; }

        public Librarian()
        {
            HireDate = null;
            Salary = 0.0;
        }
        public Librarian(string firstName, string lastName, string hireDate, double salary):
            base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Data zatrudnienia: {HireDate}, Wynagrodzenie: {Salary}";
        }
        public void Info()
        {
            Console.WriteLine(this);
        }
    }
}
