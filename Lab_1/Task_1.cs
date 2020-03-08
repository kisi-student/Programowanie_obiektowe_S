using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace Task1
{
    class Task_1
    {
        public static void Run()
        {
            Car s1 = new Car();

            s1.PrintInfo();

            s1.Brand = "Fiat";
            s1.Model = "126p";
            s1.DoorCount = 2;
            s1.EngineVolume = 650;
            s1.AvarageConsump = 6.0;

            s1.PrintInfo();

            Car s2 = new Car("Syrena", "105","SC56Y2C", 2, 800, 7.6);

            s2.PrintInfo();

            double travelCost = s2.CountCostOfTravel(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + travelCost);

            Car.PrintNumberOfCars();


            Console.ReadKey();
        }
    }
}
