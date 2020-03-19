using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class FootballPlayer : Player
    {
        public FootballPlayer(string name_, string surname_, DateTime birthday_, string posisiton_, string club_)
            : base(name_, surname_, birthday_, posisiton_, club_)
        {
          
        }

        public override void Score()
        {
            base.Score();
            Console.WriteLine("Football");
        }
    }
}
