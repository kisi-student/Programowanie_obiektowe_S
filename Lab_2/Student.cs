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

        public Student(string name,string surname,DateTime birthday,int year,int group,int indexNumber):
            base(name,surname,birthday)
        {
            Year = year;
            Group = group;
            IndexNumber = indexNumber;
        }

        public void AddMark(string lecture,DateTime date,double value)
        {
            marks.Add(new Mark(lecture, date, value));
        }

        public void RemoveMark(string lecture, DateTime date,double value)
        {

            foreach (var mark in marks.ToList())
            {
                if (mark.Lecture == lecture && mark.Date == date && mark.Value == value)
                {
                    marks.Remove(mark);
                }
                
            }
        }

        public void RemoveAllMarks()
        {
            marks.Clear();
        }

        public void RemoveAllMarks(string lecture)
        {
            foreach (var mark in marks.ToList())
            {
                if (mark.Lecture == lecture)
                {
                    marks.Remove(mark);
                }
            }
        }

        public void PrintMarks()
        {
            foreach (var mark in marks)
            {
                mark.PrintInfo();
            }
        }

        public void PrintMarks(string lecture)
        {
            foreach (var mark in marks)
            {
                if (mark.Lecture == lecture)
                {
                    mark.PrintInfo();
                }
            }
        }

        public override void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string str = base.ToString() + $"Year: {Year} Group: {Group}\nIndexNo: {IndexNumber}\n";

            foreach (var mark in marks)
            {
                str += mark.ToString();
            }

            return str;
        }
    }
}
