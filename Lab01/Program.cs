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
            s1.EngCapacity = 650;
            s1.AvgConsump = 6.0;

            s1.Details();

            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            s2.Details();

            double routeConsumption = s2.CaluclateCost(30.5, 4.85);
            Console.WriteLine("Route consumption: " + routeConsumption);

            Car.DisplayCarCount();

        }
    }
}
