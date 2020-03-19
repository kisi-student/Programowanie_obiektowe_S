using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab2;

namespace lab2
{
  public class Player :Person
    {
        public string Position { get; set; }
        public string Club { get; set; }

        private int goalCount = 0;

        public Player(string name_, string surname_, DateTime birthday_, string posisiton_, string club_)
            :base(name_, surname_, birthday_ )
        {
            Position = posisiton_;
            Club = club_;
        }

        public override void PrintInfo()
        {
            base.PrintInfo(); //korzystam z bazowej metody
            Console.WriteLine($"Position: {Position} Club {Club} Goals: {goalCount} \n");
        }

        public virtual void Score()
        {
            goalCount++;
        }
    }
}
