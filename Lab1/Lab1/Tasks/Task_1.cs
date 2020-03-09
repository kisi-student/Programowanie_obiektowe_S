using System;

using zadanie1samochod;

namespace Tasks
{
    public class Task_1
    {
        public static void DoWork()
        {
            Car s1 = new Car();
            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            s1.WypiszInfo();

            s1.Brand = "Fiat";
            s1.Model = "126p";
            s1.DoorCount = 2;
            s1.EngineCapacity = 650;
            s1.Combustion = 6.0;

            s1.WypiszInfo();

            s2.WypiszInfo();

            double kosztPrzejazdu = s2.ObliczKosztPrzejazdu(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu: " + kosztPrzejazdu);

            Car.WypiszIloscSamochodow();

            Console.ReadKey();
        }
    }
}
