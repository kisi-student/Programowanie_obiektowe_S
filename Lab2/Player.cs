using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Player:Person
    {
        private string position;
        private string club;
        private int goals = 0;

        public Player():base()
        {
        }

        public Player(string name, string surname, string birthday, string position, string club) : base(name, surname, birthday)
        {
            this.position = position;
            this.club = club;
        }

        public virtual void ShootGoal()
        {
            goals++;
        }

        public override void Details()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return base.ToString()+$", pozycja:{position}, klub:{club}, goli:{goals}";
        }
    }
}
