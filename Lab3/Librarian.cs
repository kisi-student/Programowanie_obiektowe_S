using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Librarian: Person
	{
		private string employmentDate;
		private double salary;

		public Librarian()
		{
		}

		public Librarian(string name, string surname, string employmentDate, double salary) : base(name, surname)
		{
			this.employmentDate = employmentDate;
			this.salary = salary;
		}

		public string EmploymentDate { get => employmentDate; set => employmentDate = value; }
		public double Salary { get => salary; set => salary = value; }

		public override string ToString()
		{
			return base.ToString()+$", zatrudniony: {employmentDate}, zarabia: {salary}";
		}
	}
}
