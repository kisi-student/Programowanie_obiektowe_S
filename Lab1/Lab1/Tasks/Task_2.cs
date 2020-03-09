using System;

using zadanie1samochod;
using zadanie2garaz;

namespace Tasks
{
    class Task_2
    {
        public static void DoWork()
        {
            Car s1 = new Car();
            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            Garage g1 = new Garage();
            g1.Address = "ul. Garazowa 1";
            g1.Capacity = 1;

            Garage g2 = new Garage("ul. Garazowa 2", 2);

            g1.WprowadzSamochod(s1);
            g1.PrintInfo();
            g1.WprowadzSamochod(s2);

            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.PrintInfo();

            g2.WyprowadzSamochod();
            g2.PrintInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();

            Console.ReadKey();
        }

    }
}
