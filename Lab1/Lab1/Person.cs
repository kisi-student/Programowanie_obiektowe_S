using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zadanie1samochod;

namespace zadanie3osoba
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        private int _carCount = 0; // carCount
        public List<string> Registrations { get; set; }

        public Person()
        {
            Name = "nieznane";
            Surname = "nieznane";
            Address = "nieznany";
            Registrations = new List<string>();


        }

        public Person(string name, string surname, string address, int carCount = 0)
        {
            Name = name;
            Surname = surname;
            Address = address;
            _carCount = carCount;
            Registrations = new List<string>();
        }

        public void PushCar(string nrRej)
        {
            if (Registrations.Count < 3)
            {
                Registrations.Add(nrRej);
                _carCount++;
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public void PopCar(string nrRej)
        {
            if (Registrations.Any() && Registrations.Contains(nrRej))
            {
                Registrations.Remove(nrRej);
                _carCount--;
            }
            else
            {
                Console.WriteLine("Is empty or the car is not present on the list");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            var str = $"Name: {Name} Surname: {Surname}\n" +
                $"Address: {Address}\nOwned cars:\n";

            foreach (var registration in Registrations)
            {
                str += $"Number: {registration}\n";
            }

            return str;
        }
    }
}
