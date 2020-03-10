using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Player : Person
    {
        private string position { get; set; }
        private string club { get; set; }
        private int numberOfGoals { get; set; }

        public Player(string _firstname, string _lastname, string _birthday, string _position, string _club) : base(_firstname, _lastname, _birthday)
        {
            position = _position;
            club = _club;
            
        }

        public override string ToString()
        {
            return base.ToString()+ $"\nPosition: {position}\nClub: {club}\nNumber of goals: {numberOfGoals}\n";
        }
        public override void WriteInfo()
        {
            Console.WriteLine(this);
        }
        public void ScoreAGoal()
        {
            numberOfGoals++;
        }
    }
}
