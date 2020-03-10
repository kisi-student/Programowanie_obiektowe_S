using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Player : Person
    {
        private string position;
        private string club;
        private int goalCount = 0;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Club
        {
            get { return club; }
            set { club = value; }
        }

        public int GoalCount
        {
            get { return goalCount; }
            set { goalCount = value; }
        }

        public Player() : base()
        {
            position = "none";
            club = "none";
            goalCount = 0;
        }

        public Player(string name_, string lastname_, string dateOfB_,string position_,string club_,int goalCount_=0): base(name_,lastname_,dateOfB_)
        {
            position = position_;
            club = club_;
            goalCount = goalCount_;
        }

        public override void Details()
        {
            base.Details();
            Console.WriteLine("Position: " + position + " Club: " + club + " Goal count: " + goalCount);
        }
        
        public virtual void ScoreGoal()
        {
            goalCount++;
        }

       
    }
}
