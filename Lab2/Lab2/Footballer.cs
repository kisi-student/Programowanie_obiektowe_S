using System;

namespace Lab2
{
    public class Footballer : Person
    {
        public string Role { get; set; }
        public string Club { get; set; }
        public int GoalCount { get; set; }

        public Footballer(string name, string surname, string birthday,
            string role, string club) : base(name, surname, birthday)
        {
            Role = role;
            Club = club;
        }

        public virtual void Score()
        {
            Console.WriteLine($"{Name} {Surname} scored a goal!");
            GoalCount++;
        }

        //public override void PrintInfo()
        //{
        //    Console.WriteLine(this);
        //}

        public override string ToString()
        {
            return base.ToString() + $"Role: {Role} Club: {Club} Goals: {GoalCount}\n";
        }
    }
}
