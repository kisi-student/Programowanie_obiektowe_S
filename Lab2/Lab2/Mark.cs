using System;

namespace Lab2
{
    class Mark
    {
        public string LectureName { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Mark(string lectureName, DateTime date, double value)
        {
            LectureName = lectureName;
            Date = date;
            Value = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Lecture: {LectureName} Date: {Date.ToShortDateString()} Mark: {Value}";
        }
    }
}
