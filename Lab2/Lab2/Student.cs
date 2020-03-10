using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        private int year;
        private int group;
        private int indexNumber;
        private List<Grade> oceny = new List<Grade>();

        public int Year { get => year; set => year = value; }
        public int Group { get => group; set => group = value; }
        public int IndexNumber { get => indexNumber; set => indexNumber = value; }

        public Student():
            base()
        {
            year = 0;
            group = 0;
            indexNumber = 0;
        }


        public Student(string name_, string surname_, string dateOfBirth_, int year_, int group_, int indexNumber_):
            base(name_, surname_, dateOfBirth_)
        {
            year = year_;
            group = group_;
            indexNumber = indexNumber_;
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nStudent Data | Year: {year}, Group: {group}, Index Number: {IndexNumber} ";
        }

        public override void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("----------");
        }

        public void AddGrade()
    }
}
