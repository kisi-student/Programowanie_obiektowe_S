using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student:Person
    {
        private int year;
        private int group;
        private int indexNumber;

        public Student() : base()
        {
        }

        public Student(string name, string surname, string birthday, int year, int group, int indexNumber) : base(name, surname, birthday)
        {
            this.year = year;
            this.group = group;
            this.indexNumber = indexNumber;

        }

        public int Year { get => year; set => year = value; }
        public int Group { get => group; set => group = value; }
        public int IndexNumber { get => indexNumber; set => indexNumber = value; }

        public override void Details()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"rok:{year}, grupa:{group}, nr indeksu:{indexNumber}";
        }
    }
}
