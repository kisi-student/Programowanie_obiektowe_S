using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	class Handballer:Player
	{
		public Handballer(string name, string surname, string birthday, string position, string club) : base(name, surname, birthday, position, club)
		{
		}

		public override void ShootGoal()
		{
			base.ShootGoal();
			Console.WriteLine("Reczny strzelil!");
		}
	}
}
