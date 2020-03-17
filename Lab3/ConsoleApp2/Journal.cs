using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal : Position
    {
        public int Number { get; set; }

        public Journal() : base()
        {
            Number = 0;
        }

        public Journal(string _title, int _id, string _publisher,
            DateTime _publishDate, int _number) : base(_title, _id, _publisher,
                _publishDate)
        {
            Number = _number;
        }

        public override string ToString()
        {
            return base.ToString() + $"Journal number:{Number}\n";
        }
        public override void WriteInfo()
        {
            Console.WriteLine(this);
        }
    }
}
