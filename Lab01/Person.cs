using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Person
    {
        private const int maxCars = 3;
        private string name;
        private string surname;
        private string address;
        private int ownedCarsCount = 0;

        private IList<string> ownedCars;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }
        public int OwnedCarsCount { get => ownedCarsCount; }

        public Person(string name, string surname, string address)
        {
            this.name = name;
            this.surname = surname;
            this.address = address;
            ownedCars = new List<string>();
        }

        public Person()
        {
            name = "None";
            surname = "None";
            address = "None";

            ownedCars = new List<string>();
        }

        public void AddCar(string licensePlate)
        {
            if (ownedCarsCount >= maxCars)
                Console.WriteLine($"Person {name} {surname} cannot have more than {maxCars} cars.");

            ownedCars.Add(licensePlate);
            ownedCarsCount++;
        }

        public void RemoveCar(string licensePlate)
        {
            if (ownedCarsCount <= 0)
                Console.WriteLine($"Person {name} {surname} doesn't have any car.");

            if (ownedCars.Remove(licensePlate))
                ownedCarsCount--;
        }
        
        public void Details()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string os = $"Person {name} {surname} owns {OwnedCarsCount} cars: \r\n";

            foreach (string licensePlate in ownedCars)
                if (licensePlate != null)
                    os += licensePlate + "\r\n";

            return os;
        }
    }
}
