using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Player : Person
    {
        private string position;
        private string club;
        private int numberOfGoals = 0;

        public string Position { get => position; set => position = value; }
        public string Club { get => club; set => club = value; }
        public int NumberOfGoals { get => numberOfGoals; set => numberOfGoals = value; }

        public Player() :
            base()
        {
            position = ("--");
            club = ("--");
        }

        public Player(string name_, string surname_, string dateOfBirth_, string position_, string club_):
            base(name_, surname_, dateOfBirth_)
        {
            position = position_;
            club = club_;
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nPlayer Data | Position: {position}, Club: {club}, Number Of Goals: {numberOfGoals}";
        }

        public override void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("----------");
        }

        virtual public void Goal() { numberOfGoals++; }
    }
}
