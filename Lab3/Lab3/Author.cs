using System;

namespace Lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }
        public Author()
        { }

        public Author(string name, string surname, string nationality)
            : base(name, surname)
        {
            Nationality = nationality;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Nationality: {Nationality}");
        }
    }
}
