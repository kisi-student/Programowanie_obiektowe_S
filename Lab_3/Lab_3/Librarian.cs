using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Librarian: Person
    {
        public DateTime DateOfEmployment { get; }

        public double Salary { get; set; }

        public Librarian()
        {
            DateOfEmployment = new DateTime();
            Salary = 0.0f;
        }

        public Librarian(string name,string surname,DateTime dateOfEmployment,double salary):
            base(name,surname)
        {
            DateOfEmployment = dateOfEmployment;
            Salary = salary;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Employmnet date: {DateOfEmployment.ToShortDateString()} Salary: {Salary}");
        }
    }
}
