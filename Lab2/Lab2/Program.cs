using System;
using System.Collections.Generic;

namespace Lab2
{
    class Person
    {
        protected string name;
        protected string surname;
        protected string birth; //dateOfBirth

        /*
        public Person()
        {
            name = "unknown";
            surname = "unknown";
            birth = "unknown";
        }
        */

        public Person (string name_, string surname_, string birth_)
        {
            name = name_;
            surname = surname_;
            birth = birth_;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
        }

        public string Birth
        {
            get
            {
                return birth;
            }
        }

        public virtual void Details()
        {
            Console.WriteLine("PERSON\n" + name + " " + surname + " " + birth);
        }
    }

    class Student : Person
    {
        private int year;
        private int group;
        private int index;

        public Student(string name_, string surname_, string birth_, int year_, int group_, int index_) : base(name_, surname_, birth_)
        {
            year = year_;
            group = group_;
            index = index_;
        }

        public int Year
        {
            get
            {
                return year;
            }
        }

        public int Group
        {
            get
            {
                return group;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
        }

        public override void Details()
        {
            Console.WriteLine("STUDENT\n" + name + " " + surname + " " + "\nyear : " + year + "\ngroup: " + group + "\nindex: " + index);
        }
    }

    class Footballer : Person
    {
        private string position;
        private string club;
        private int score = 0;

        public Footballer(string name_, string surname_, string birth_, string position_, string club_) : base(name_, surname_, birth_)
        {
            position = position_;
            club = club_;
        }

        public string Position
        {
            get
            {
                return position;
            }
        }

        public string Club
        {
            get
            {
                return club;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
        }

        public override void Details()
        {
            Console.WriteLine("FOOTBALLER\n" + name + " " + surname + " " + "\nposition : " + position + " club: " + club + "\nscore: " + score);
        }

        public void ScoreGoal() //Score a goal
        {
            score++;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person o = new Person("Adam", "Mis", "20.03.1980");
            Person o2 = new Student("Michal", "Kot", "13.04.1990", 2, 1, 12345);
            Person o3 = new Footballer("Mateusz", "Zbik", "10.08.1986", "obronca", "FC Czestochowa");

            o.Details();
            o2.Details();
            o3.Details();

            Student s = new Student("Krzysztof", "Jez", "22.12.1990", 2, 5, 54321);
            Footballer p = new Footballer("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

            s.Details();
            p.Details();

            ((Footballer)o3).ScoreGoal();
            p.ScoreGoal();
            p.ScoreGoal();

            o3.Details();
            p.Details();

            Console.ReadKey();
        }
    }
}
