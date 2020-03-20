using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Car : ICar
    {
        public string Rejestracja { get; set; }

        public void Crash(string car)
        {
            Console.WriteLine("Badum");
        }

        public void Drive()
        {
            Console.WriteLine("Jade kurla");
        }
    }
}
