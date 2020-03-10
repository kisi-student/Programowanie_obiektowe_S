using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car s1 = new Car();

            s1.Details();
            s1.Brand = "Fiat";
            s1.Model = "126p";
            s1.DoorCount = 2;
            s1.EngineVolume = 650;
            s1.AverageGasConsumption = 6.0;

            s1.Details();

            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            s2.Details();

            double tripCost = s2.calculateTripCost(30.5, 4.85);
            Console.WriteLine("Journey cost: " + tripCost);

            Car.PrintCarCount();

            Garage g1 = new Garage();
            g1.Address = "ul. Garazowa 1";
            g1.Capacity = 1;

            Garage g2 = new Garage("ul. Garazowa 1", 2);

            g1.pushCar(s1);
            g1.Details();
            g1.popCar();

            g2.pushCar(s2);
            g2.pushCar(s1);
            g2.Details();

            g2.popCar();
            g2.Details();

            g2.popCar();
            g2.popCar();

            Person person1 = new Person();
            person1.Name = "Jan";
            person1.Surname = "Kowalski";
            person1.Address = "Al. NMP 1";
            person1.AddCar("SCZ 12345");
            person1.AddCar("SC 9863");
            person1.AddCar("SCZ 37893");
            person1.AddCar("SCZ 4912");
            person1.Details();

            Person person2 = new Person("Piotr", "Nowak", "Al. Wolnosci 10");

            person2.AddCar("DW 9866");
            person2.Details();
            person2.RemoveCar("DW 9866");
            person2.Details();
            person2.RemoveCar("DW 9866");

            Console.ReadKey();
        }
    }
}
