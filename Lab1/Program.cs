using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();

            c1.printInfo();

            c1.Brand = "Fiat";
            c1.Model = "126p";
            c1.DoorNumber = 2;
            c1.EngineCapacity = 650;
            c1.AvgPetrolUse = 6.0;

            c1.printInfo();

            Car c2 = new Car("Syrena", "105", 2, 800, 7.6);

            c2.printInfo();

            double drivingCost = c2.drivingCost(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + drivingCost);

            Car.printNumberOfCarInstances();

            Garage g1 = new Garage();
            g1.Adres = "ul. Garażowa 1";
            g1.Capacity = 1;

            Garage g2 = new Garage("ul. Garażowa 2", 2);

            g1.LeadCarIn(c1);
            g1.PrintInfo();
            g1.LeadCarIn(c2);

            g2.LeadCarIn(c2);
            g2.LeadCarIn(c1);
            g2.PrintInfo();

            g2.LeadCarOut();
            g2.PrintInfo();

            g2.LeadCarOut();
            g2.LeadCarOut();

            Console.ReadKey();
        }
    }
}
