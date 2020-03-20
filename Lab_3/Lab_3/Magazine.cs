using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Magazine: Position
    {
        public uint Number { get; set; }

        public Magazine()
        {
            Number = 0;
        }

        public Magazine(string title,uint id,string publishingHouse,DateTime publicationYear,uint number):
            base(title,id,publishingHouse,publicationYear)
        {
            Number = number;
        }


        public override void PrintInfo()
        {
            Console.WriteLine($"Id: {_id} Magazine title: {_title} Publisher: {_publisher} " +
                $"Publication Year: {_publicationYear.ToShortDateString()} Number: {Number}");
        }

    }
}
