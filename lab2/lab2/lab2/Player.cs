using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Player : Person
    {
        private string Position { get; set; }
        private string Club { get; set; }
        private int NumberOfGoals { get; set; }

        public Player(string _firstname, string _lastname, string _birthday, string _position, string _club) : base(_firstname, _lastname, _birthday)
        {
            Position = _position;
            Club = _club;
            
        }

        public override string ToString()
        {
            return base.ToString()+ $"\nPosition: {Position}\nClub: {Club}\nNumber of goals: {NumberOfGoals}\n";
        }
        public override void WriteInfo()
        {
            Console.WriteLine(this);
        }
        public virtual void ScoreAGoal()
        {
            NumberOfGoals++;
        }
    }
}
