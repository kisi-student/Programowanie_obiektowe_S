using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab2;


namespace lab2
{
   public class Student : Person
    {
        public int Year { get; set; }
        public int Group { get; set; }
        public int NoIndex { get; set; }

        private List<Mark> _marks = new List<Mark>();

        public Student(string name_,string surname_,DateTime birthday_,
                        int year_, int group_, int noIndex_) :base(name_,surname_,birthday_)
        {
            Year = year_;
            Group = group_;
            NoIndex = noIndex_;
        }

        public void AddMark(string subject, DateTime date, double value)
        {
            _marks.Add(new Mark(subject, date, value));
        }

        public void PrintMarks()
        {
            foreach(Mark mark in _marks)
            {
                mark.PrintInfo();
            }
        }

        public void PrintMarks(string subject)
        {
            foreach (var mark in _marks) //dla kazdej oceny w ocenach
            {
                if (mark.Subject == subject)
                    mark.PrintInfo();
            }
        }

        public void RemoveMark(string subject, DateTime date, double value)
        {
            foreach (var mark in _marks.ToList()) //bez tolist wywala blad
            {
                if (mark.Subject == subject && mark.Date == date && mark.Value == value)
                    _marks.Remove(mark);
            }
        }

        public void RemoweMarks()
        {
            _marks.Clear();
        }

        public void RemoweMarks(string subject)
        {
            foreach (var mark in _marks.ToList()) //bez tolist wywala blad
            {
                if (mark.Subject == subject)
                    _marks.Remove(mark);
            }
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Year: {Year} Group {Group}\n NoIndex: {NoIndex}");
            PrintMarks();
        }


    }
}
