using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Magazine : Entry
    {
        public uint Number { get; set; }

        public Magazine()
        {
            Number = 0;
        }

        public Magazine(uint id, string title, string publishingHouse, DateTime year, uint number)
            : base(id, title, publishingHouse, year)
        {

            Number = number;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Magazine Title: {_title},Publisher: {_publishingHouse},Year: {_year},Magazine number:  {Number}");
        }
    }
}
