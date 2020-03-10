using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Student : Person
    {
        public int Year { get; set; }

        public int Group { get; set; }

        public int IndexNumber { get; set; }

        private IList<Mark> marks = new List<Mark>();

        public Student(string name,string surname,string birthday,int year,int group,int indexNumber):
            base(name,surname,birthday)
        {
            Year = year;
            Group = group;
            IndexNumber = indexNumber;
        }

        public void AddMark(string lecture,string date,double value)
        {
            marks.Add(new Mark(lecture, date, value));
        }

        public void PrintMark()
        {
            foreach (var mark in marks)
            {
                mark.PrintInfo();
            }
        }

        public void RemoveMark()
        {
            foreach (var mark in marks)
            {
                marks.Remove(mark);
            }
        }

        public void RemoveMarks()
        {
            marks.Clear();
        }

        public void RemoveMarks(string Lecture)
        {
            foreach (var mark in marks)
            {

            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return base.ToString() + $"Year: {Year} Group: {Group}\nIndexNo: {IndexNumber}\n";
        }
    }
}
