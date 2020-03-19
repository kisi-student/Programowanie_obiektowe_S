using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Magazine : Position
    {
        public int Number { get; set; }
        public Magazine()
        { }
        public Magazine(string _title, int _id, string _publishing, int _publicationDate, int _number) : base(_title, _id, _publishing, _publicationDate)
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
