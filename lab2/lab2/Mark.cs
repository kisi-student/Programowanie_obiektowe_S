using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Mark
    {
        public string SubjectName { get; set; }
        public string Date { get; set; }
        public double Value { get; set; }

        public Mark(string subjectName, string date, double value)
        {
            SubjectName = subjectName;
            Date = date;
            Value = value;
        }

        public override string ToString()
        {
            return $"Ocena: {Value}, otrzymana {Date} z przedmiotu: {SubjectName}";
        }

        public void Info()
        {
            Console.WriteLine(this);
        }
    }
}
