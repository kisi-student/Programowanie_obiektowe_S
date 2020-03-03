using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        private int carCount = 0;
        private IList<string> cars = new List<string>();

        public Person()
        {
            Name = "none";
            Surname = "none";
            Address = "none";
        }

        public Person(string name, string surname, string address, int carCount = 0)
        {
            Name = name;
            Address = address;
            this.carCount = carCount;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            string str = $"Name: {Name}, Surname: {Surname}, Address: {Address}\nOwned vehicles:\n";

            foreach (var car in cars)
            {
                str += car + "\n";
            }

            return str;
        }

        public void AddVehicle(string registrationNumber)
        {
            if(carCount < 3)
            {
                cars.Add(registrationNumber);
                carCount++;
            }
            else
            {
                Console.WriteLine("One mustn't own more than three cars!");
            }
        }

        public void RemoveVehicle(string registrationNumber)
        {
            if (carCount > 0)
            {
                cars.Remove(registrationNumber);
                carCount--;
            }
            else
            {
                Console.WriteLine("No vehicles left in the garage.");
            }
        }
    }
}
