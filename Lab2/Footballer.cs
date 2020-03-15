using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Footballer:Person
    {
        public Footballer():base()
        {
            Position = "unknown";
            Team = "unknown";
            Goals = 0;
        }

        public Footballer(string _firstName, string _secondName, DateTime _dateOfBirth, string _position, string _team):base(_firstName, _secondName, _dateOfBirth)
        {
            Position = _position;
            Team = _team;
            Goals = 0;
        }

        public virtual void Score()
        {
            Goals++;
        }

        public override string ToString()
        {
            return $"Postion, team and goals: {Position},{Team},{Goals}";
        }

        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.WriteLine(this);
        }

        public int Goals { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
    }
}
