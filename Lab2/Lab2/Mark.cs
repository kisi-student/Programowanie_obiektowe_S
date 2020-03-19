using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   public class Mark
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Mark(string subject, DateTime date, double value)
        {
            Subject = subject;
            Date = date;
            Value = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Subject: {Subject} Date: {Date.ToShortDateString()} Mark: {Value}");
        }
    }
}
