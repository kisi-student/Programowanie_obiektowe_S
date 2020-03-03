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
            Car s1 = new Car();
            s1.WriteInformation();

            s1.Brand = "Fiat";
            s1.Model = "126p";
            s1.DoorCount = 2;
            s1.EngineCapacity = 650;
            s1.AvgFuelConsumption = 6.0;
            s1.RegistrationNumber = "SCZ4563";

            s1.WriteInformation();

            Car s2 = new Car("Syrena", "105", "SCZ1221d", 2, 800, 7.6);
            s2.WriteInformation();

            Person p1 = new Person();
            p1.WriteInfo();

            Person p2 = new Person("Łukasz", "Włuka", "Kamyczkowa 12", 1);
            p2.WriteInfo();
            p2.AddCar("ERAVF15");
            p2.WriteInfo();

            p2.AddCar("adsadsdsa");

            p2.WriteInfo();

            p2.AddCar("asdasssss");


            p2.DeleteCar("ERAVF15");
            p2.WriteInfo();

            /*
            Garage g1 = new Garage();
            g1.Address = "ul.Garażowa 1";
            g1.Capacity = 1;

            Garage g2 = new Garage("ul.Garażowa 2", 2);

            g1.AddCar(s1);
            g1.WriteInfo();
            g1.AddCar(s2);

            g2.AddCar(s2);
            g2.AddCar(s1);
            g2.WriteInfo();

            g2.DeleteCar();
            g2.WriteInfo();

            g2.DeleteCar();
            g2.AddCar(s1);
            g2.WriteInfo();
            g2.DeleteCar();
            g2.WriteInfo();
            */
          //  s2.WriteInformation();
          /*
            double kosztPrzejazdu = s2.CalculateCostRide(30.5, 4.85);
            Console.WriteLine("Koszt przejazdu:" + kosztPrzejazdu);

            Car.WriteCarsCount();
            */
            Console.ReadKey();
        }
    }
}
