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

            Car car1 = new Car();

            car1.Details();

            car1.Brand = "Fiat";
            car1.Model = "126p";
            car1.DoorCount = 2;
            car1.EngineVolume = 650;
            car1.AvgConsump = 6.0;

            car1.Details();

            Car car2 = new Car("Syrena", "105", 2, 800, 7.6);

            car2.Details();

            double cost = car2.CalculateCost(30.5, 4.85);
            Console.WriteLine("Cost of travel: " + cost);

            Car.DisplayCarCount();

            Console.ReadKey();
        } 
    }
}

