using System;

namespace lab2
{
    class Osoba
    {

        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string dataUrodzenia { get; set; }

        public Osoba (string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }


        public virtual void WypiszInfo()
        {
            Console.WriteLine($"{imie}, {nazwisko}, {dataUrodzenia}");
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(this);
        }
    }
}
