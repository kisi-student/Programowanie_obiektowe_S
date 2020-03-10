using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexNo { get; set; }

        private List<Mark> _marks = new List<Mark>();

        public Student(string name, string surname, DateTime birthday,
            int year, int group, int indexNo) : base(name, surname, birthday)
        {
            Year = year;
            Group = group;
            IndexNo = indexNo;
        }

        public void PushMark(string lectureName, DateTime date, double value)
        {
            _marks.Add(new Mark(lectureName, date, value));
        }

        public void PopMark(string lectureName, DateTime date, double value)
        {
            var mark = new Mark(lectureName, date, value);
            if(_marks.Contains(mark))
            {
                _marks.Remove(mark);
            }
        }

        public void PopMarks()
        {
            _marks.Clear();
        }

        public void PopMarks(string lectureName)
        {
            foreach (var mark in _marks.ToList())
            {
                if(mark.LectureName == lectureName)
                {
                    _marks.Remove(mark);
                }
            }
        }

        public void PrintMarks()
        {
            foreach (var mark in _marks)
            {
                mark.PrintInfo();
            }
        }

        public void PrintMarks(string lectureName)
        {
            foreach (var mark in _marks)
            {
                if(mark.LectureName == lectureName)
                {
                    mark.PrintInfo();
                }
            }
        }

        //public override void PrintInfo()
        //{
        //    Console.WriteLine(this);
        //}

        public override string ToString()
        {
            string str = $"{base.ToString()}Year: {Year} Group: {Group} IndexNo: {IndexNo}\n";
            
            foreach (var mark in _marks)
            {
                mark.PrintInfo();
            }

            return str;
        }
    }
}
