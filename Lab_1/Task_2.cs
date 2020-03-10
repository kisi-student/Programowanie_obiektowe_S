using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using Garage_;

namespace Task2
{
    class Task_2
    {
        public static void Run()
        {
            Car s1 = new Car("Fiat","126p","SKL74YY",2,650,6.0);
            Car s2 = new Car("Syrena","105", "SC56Y2C", 2,800,7.6);

            Garage g1 = new Garage();
            g1.Adres = "ul. Garażowa 1";
            g1.Capacity = 1;

            Garage g2 = new Garage("ul. Garażowa 2", 2);

            g1.EnterCar(s1);
            g1.PrintInfo();
            g1.EnterCar(s2);

            g2.EnterCar(s2);
            g2.EnterCar(s1);
            g2.PrintInfo();

            g2.EnterCar();
            g2.PrintInfo();

            g2.EnterCar();
            g2.EnterCar();

            Console.ReadKey();
        }
    }
}
