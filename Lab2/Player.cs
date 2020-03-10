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

        public Player(string name, string surname, string birthday, string position, string club, int goals) : base(name, surname, birthday)
        {
            this.position = position;
            this.club = club;
            this.goals = goals;
        }
    }
}
