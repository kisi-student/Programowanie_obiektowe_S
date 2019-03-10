using System;

namespace Lab2
{
    public class Player: Person
    {
        private string _position;
        private string _club;
        private int _scoredGoals;

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Club
        {
            get { return _club; }
            set { _club = value; }
        }

        public int ScoredGoals
        {
            get { return _scoredGoals; }
            set { _scoredGoals = value; }
        }

        public Player() : base()
        {
            _scoredGoals = 0;
            _club = "none";
            _position = "none";
        }

        public Player(string firstName, string lastName, DateTime dateOfBirth,
                            string position, string club, int scoredGoals = 0)
                :base(firstName, lastName, dateOfBirth)
        {
            _position = position;
            _scoredGoals = scoredGoals;
            _club = club;
        }
        public override string ToString()
        {
            return base.ToString() + $" Position: {_position}, Scored goals: {_scoredGoals}, Club: {_club}";
        }

        public override void Details()
        {
            Console.WriteLine(this);
        }

        public virtual void ScoreGoal()
        {
            _scoredGoals++;
        }
    }
}
