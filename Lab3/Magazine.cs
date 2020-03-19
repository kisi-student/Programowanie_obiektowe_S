using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Magazine : Position
	{
		public Magazine()
		{
		}

		public Magazine(string title, int id, string publisher, int publicationDate) : base(title, id, publisher, publicationDate)
		{
		}

		public override void Details()
		{
			Console.WriteLine( base.ToString());
		}
	}
}
