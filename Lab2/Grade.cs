using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Grade
    {
        public Grade()
        {
            Subject = "unknown";
            Date = new DateTime();
            Value = 0.0;
        }

        public Grade(string _subject, DateTime _date, double _value)
        {
            Subject = _subject;
            Date = _date;
            Value = _value;
        }

        public override string ToString()
        {
            return $"Subject, data and value {Subject},{Date.ToShortDateString()},{Value}";
        }
        public void WriteInfo()
        {
            Console.WriteLine(this);
        }

        public double Value { get; set; }
        public DateTime Date { get; set; }
        public string Subject { get; set; }
    }
}
