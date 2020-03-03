using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Task1
    {
        public static void DoWork()
        {
            Car car1 = new Car();
            Car car2 = new Car("Syrena", "105", 2, 800, 7.6);

            car1.Brand = "Fiat";
            car1.Model = "126p";
            car1.DoorCount = 2;
            car1.EngineCapacity = 650;
            car1.AverageCombustion = 6.0f;

            car1.PrintInfo();
            car2.PrintInfo();

            Console.WriteLine($"Travel expenses: {car2.CalcTravelCost(30.05, 4.85)}");

            Car.PrintCarCount();

            Console.ReadKey();
        }
    }
}
