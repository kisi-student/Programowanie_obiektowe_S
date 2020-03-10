using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class FootBallPlayer : Player
    {
        public FootBallPlayer() : base() { }
        public FootBallPlayer(string name_, string lastname_, string dateOfB_, string position_, string club_, int goalCount_ = 0) : base(name_, lastname_, dateOfB_, position_, club_) { }

        public override void ScoreGoal()
        {
            base.ScoreGoal();
            Console.WriteLine("Foot Ball Player scored!!");
        }
    }
}
