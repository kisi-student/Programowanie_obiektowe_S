using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string firstname, string lastname, string birthday, string position, string club) : base(firstname, lastname, birthday,position,club)
        {

        }
        public override void ScoreAGoal()
        {
            Console.WriteLine("Footballer");
            base.ScoreAGoal();
        }
    }
}
