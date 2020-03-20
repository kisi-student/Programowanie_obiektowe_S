using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Author: Person
    {
        public string Nation { get; set; }

        public Author()
            : base()
        {
            Nation = "none";
        }

        public Author(string name,string surname,string nation):
            base(name,surname)
        {
            Nation = nation;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Nationality: {Nation}");
        }
    }
}
