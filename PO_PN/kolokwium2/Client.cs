using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class Client : IBill
    {
        static int _lastid = 0;

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public List<SiteHosting> Sites{get; set;}

        public Client(string Firstname, string Lastname, string Email = null)
        {
            this.Id = ++_lastid;
            this.Firstname = Firstname; this.Lastname = Lastname; this.Email = Email ?? $"{Firstname}.{Lastname}@example.test";
            this.Sites = new List<SiteHosting>();
        }

        public void BillPrint()
        {
            Console.WriteLine("Name".PadRight(20) + "Ilosc".PadLeft(10) + "cena".PadLeft(10) + "wartosc".PadLeft(10));
            var sum = 0.0;
            Sites.ForEach(site =>
                site.Services.ForEach(serv =>
                {
                    Console.Write($"{site.Name}_{serv.Name}".PadRight(20));
                    Console.Write($"{serv.Quantit}".PadLeft(10));
                    Console.Write($"{serv.Price}".PadLeft(10));
                    Console.Write($"{ serv.Quantit* serv.Price}".PadLeft(10));
                    Console.WriteLine();
                    sum += serv.Quantit * serv.Price;
                })
            );
            Console.WriteLine($"razem:".PadLeft(40) + $"{sum}zł".PadLeft(10));
        }


        public override string ToString() => $"{Firstname} {Lastname} email: {Email} id: {Id}";

    }
}