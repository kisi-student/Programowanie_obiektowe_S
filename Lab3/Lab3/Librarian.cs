using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab3
{
    public class Librarian : Person
    {
        public DateTime EmploymentDate { get; }
        public double Salery { get; set; }
       
        public Librarian()
        {
            EmploymentDate = new DateTime();
            Salery = 0.0f;
        }

        public Librarian(string name, string surname, DateTime employmentDate, double salery)
            : base(name, surname)
        {
            EmploymentDate = employmentDate;
            Salery = salery;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Employment date: {EmploymentDate.ToShortDateString()} Salery: {Salery}");
        }
    }
}
