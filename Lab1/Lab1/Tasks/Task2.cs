using System;

using Lab1;

namespace Tasks
{
    public class Task2
    {
        public static void DoWork()
        {
            Car car1 = new Car("Fiat", "126p", 2, 650, 6.0f);
            Car car2 = new Car("Syrena", "105", 2, 800, 7.6f);

            Garage garage1 = new Garage();
            Garage garage2 = new Garage("ul. Garażowa 1", 2);

            garage1.Address = "ul. Garażowa 1";
            garage1.Capacity = 1;

            garage1.DriveIn(car1);
            garage1.PrintInfo();
            garage1.DriveIn(car2);

            garage2.DriveIn(car2);
            garage2.DriveIn(car1);
            garage2.PrintInfo();

            garage2.DriveOut();
            garage2.PrintInfo();

            garage2.DriveOut();
            garage2.DriveOut();

            Console.ReadKey();
        }
    }
}
