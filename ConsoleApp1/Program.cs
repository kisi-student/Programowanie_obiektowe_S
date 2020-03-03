using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car s1 = new Car();
            s1.WriteInformation();

            s1.Mark = "Fiat";
            s1.Model = "126p";
            s1.DoorCount = 2;
            s1.EngineCapacity = 650;
            s1.AvgFuelConsumption = 6.0;

            s1.WriteInformation();

            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            s2.WriteInformation();

            double kosztPrzejazdu = s2.CalculateCostRide(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu:" + kosztPrzejazdu);

            Car.WriteCarsCount();

            Console.ReadKey();
        }
    }
}
