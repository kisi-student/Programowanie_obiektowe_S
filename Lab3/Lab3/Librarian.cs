using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Librarian :Person
    {
        public DateTime EmploymentDate { get; set; }
        public double Salary { get; set; }
        public Librarian()
        {
            EmploymentDate = default; //uproszenie new DateTime()
            Salary = 0.0;
        }
        public Librarian(string name, string surname, DateTime employmentDate, double salary) 
                    : base(name, surname)
        {
            EmploymentDate = employmentDate;
            Salary = salary;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Employment date: {EmploymentDate.ToShortDateString()} Salary: {Salary}");
        }
    }
}
