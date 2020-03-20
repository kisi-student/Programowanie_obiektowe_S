using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Mark
    {
        public string Lecture { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Mark(string lecture,DateTime date,double value)
        {
            Lecture = lecture;
            Date = date;
            Value = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Lecture: {Lecture} Date: {Date}\nValue: {Value}";
        }
    }
}
