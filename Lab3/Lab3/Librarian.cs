using System;

namespace Lab3
{
    /// <summary>
    /// Bibliotekarz
    /// </summary>
    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian():base()
        {
            HireDate = default(DateTime);
            Salary = 0.0m;
        }

        public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary)
         :base(firstName, lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $"Hire date: {HireDate}, Salary: {Salary}";
        }
    }
}
