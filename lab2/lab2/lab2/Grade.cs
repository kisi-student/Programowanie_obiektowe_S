using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Grade
    {
       public string Subject { get; set; }
       public string Date { get; set; }
        public double Value { get; set; }
    
        public Grade (string _subject, string _date, double _value )
        {
            Subject = _subject;
            Date = _date;
            Value = _value;
        }

        public Grade()
        {
        }
        public void WriteInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Subject: {Subject} Date: {Date} Mark: {Value}";
        }
    }


}
