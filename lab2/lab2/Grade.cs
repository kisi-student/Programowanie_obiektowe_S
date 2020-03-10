using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Grade
    {
        private string subName;
        private string date;
        private double value1;

        public string SubName { get => subName; set => subName = value; }
        public string Date { get => date; set => date = value; }
        public double Value1 { get => value1; set => value1 = value; }

        public Grade()
        {
            subName = "none";
            date = "none";
            value1 = 0;
        }

        public Grade(string subName_, string date_, double value1_)
        {
            subName = subName_;
            date = date_;
            value1 = value1_;
        }

        public void Details()
        {
            Console.WriteLine("Subject name: " + subName + " Date: " + date + " value: " + value1);
        }
    }
}
