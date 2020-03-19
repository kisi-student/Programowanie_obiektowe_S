using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Author: Person
	{
		private string nationality;

		public Author()
		{
		}

		public Author(string name, string surname, string nationality):base(name,surname)
		{
			this.nationality = nationality;
		}

		public string Nationality { get => nationality; set => nationality = value; }

		public override string ToString()
		{
			return base.ToString()+", "+nationality;
		}
	}
}
