using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Person
	{
		private string name;
		private string surname;

		public Person()
		{
		}

		public Person(string name, string surname)
		{
			this.name = name;
			this.surname = surname;
		}

		public string Name { get => name; set => name = value; }
		public string Surname { get => surname; set => surname = value; }

		public override string ToString()
		{
			return name + " " + surname; ;
		}
	}
}
