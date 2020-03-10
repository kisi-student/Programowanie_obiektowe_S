using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class FootballPlayer : Footballer
    {
        public FootballPlayer(string name, string surname, DateTime birthday,
             string role, string club)
            : base(name, surname, birthday, role, club) { }

        public override void Score()
        {
            Console.Write("Piłkarz ręczny ");
            base.Score();
        }
    }
}
