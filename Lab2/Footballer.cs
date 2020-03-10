using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Footballer:Person
    {
        private string _position;
        private string _team;
        private int _goals;

        public Footballer():base()
        {
            _position = "unknown";
            _team = "unknown";
            _goals = 0;
        }

        public Footballer(string _firstName, string _secondName, string _dateOfBirth, string _position, string _team):base(_firstName, _secondName, _dateOfBirth)
        {
            this._position = _position;
            this._team = _team;
            _goals = 0;
        }

        public void IncrementGoals()
        {
            _goals++;
        }

        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.WriteLine($"Postion, team and goals: {_position},{_team},{_goals}");
        }

        public int Goals { get => _goals; set => _goals = value; }
        public string Team { get => _team; set => _team = value; }
        public string Position { get => _position; set => _position = value; }
    }
}
