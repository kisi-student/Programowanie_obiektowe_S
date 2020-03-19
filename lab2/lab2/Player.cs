using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Player: Person
    {
        public string Position { get; set; }
        public string Club { get; set; }
        public int GoalCount { get; set; }

        public Player(string firstName, string lastName, string birthDate, string position, string club):
            base(firstName, lastName, birthDate)
        {
            Position = position;
            Club = club;
            GoalCount = 0;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, gra jako {Position}, w klubie {Club}, strzelone gole: {GoalCount}";
        }

        public override void Info()
        {
            Console.WriteLine(this);
        }

        public virtual void ScoreGoal()
        {
            GoalCount++;
        }
    }
}
