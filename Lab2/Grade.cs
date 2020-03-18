using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Grade
	{
		private string subjectName;
		private string date;
		private double value;

		public Grade(string subjectName, string date, double value)
		{
			this.subjectName = subjectName;
			this.date = date;
			this.value = value;
		}

		public string SubjectName { get => subjectName; set => subjectName = value; }
		public string Date { get => date; set => date = value; }
		public double Value { get => value; set => this.value = value; }

		public void Details()
		{
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			return $"\r\nOcena {value} z {subjectName} otrzymana {date}";
		}

		public override bool Equals(object obj)
		{
			return obj.ToString().Equals(this.ToString());
		}
	}
}
