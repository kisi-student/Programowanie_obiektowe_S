using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();

            c1.ShowInfo();

            c1.Brand = "Fiat";
            c1.Model = "126p";
            c1.DoorCount = 2;
            c1.EngVolue = 650;
            c1.AverageConsuption = 6.0;

            c1.ShowInfo();

            Car c2 = new Car("Syrena", "105", 2, 800, 7.6);

            c2.ShowInfo();

            double driveCost = c2.CountCostOfDrive(30.5, 4.85);
            Console.WriteLine("Drive cost: " + driveCost);

            Car.ShowNumberOfCars();

            Console.ReadKey();

        }
    }
}
