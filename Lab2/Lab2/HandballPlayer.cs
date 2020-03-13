using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class HandballPlayer : Player
    {
        public HandballPlayer(string name_, string surname_, string dateOfBirth_, string position_, string club_) :
            base(name_, surname_, dateOfBirth_, position_, club_) { }

        public void Goal() { base.Goal(); }
    }
}
