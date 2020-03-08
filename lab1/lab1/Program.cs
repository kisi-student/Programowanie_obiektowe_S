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
            /*
            //ZADANIE 1
            Car s1 = new Car();

            s1.CarInfo();

            s1.Brand = "Fiat";
            s1.Model = "126p";
            s1.NumDoors = 2;
            s1.EngineCap = 650;
            s1.AvgConsump = 6.0;

            s1.CarInfo();

            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            s2.CarInfo();

            double kosztPrzejazdu = s2.CalcFuelCost(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu + "zl");

            Car.CarCount();

            Console.ReadKey();
            */

            //ZADANIE 2
            Car s1 = new Car("Fiat", "126p", 2, 650, 6.0);
            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            Garage g1 = new Garage();
            g1.Address = "ul. Garażowa 1";
            g1.Capacity = 1;

            Garage g2 = new Garage("ul. Garażowa 2", 2);

            g1.InsertCar(s1);
            g1.GarageInfo();
            g1.InsertCar(s2);

            g2.InsertCar(s2);
            g2.InsertCar(s1);
            g2.GarageInfo();

            g2.RemoveCar();
            g2.GarageInfo();

            g2.RemoveCar();
            g2.RemoveCar();

            Console.ReadKey();
        }
    }
}
