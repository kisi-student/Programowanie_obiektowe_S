using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Grade
    {
        private string subjectName;
        private string date;
        private double note;

        public string SubjectName { get => subjectName; set => subjectName = value; }
        public string Date { get => date; set => date = value; }
        public double Note { get => note; set => note = value; }

        public Grade(string subjectName_, string date_, double note_) 
        {
            subjectName = subjectName_;
            date = date_;
            note = note_;
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nGrade Data | Subject Name: {subjectName}, Date: {date}, Grade: {note}";
        }

        public void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("----------");
        }
    }
}
