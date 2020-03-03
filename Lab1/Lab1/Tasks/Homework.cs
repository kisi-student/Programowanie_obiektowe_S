using System;
using System.Collections.Generic;

using Lab1;

namespace Tasks
{
    public class Homework
    {
        public static void DoWork()
        {
            var car1 = new Car("Fiat", "126p", 2, 650, 6.0, "SCZ6969");
            var car2 = new Car("Syrena", "105", 2, 800, 7.6, "SCZ8888");
            var car3 = new Car("Ferrari", "Italia", 2, 800, 7.6, "SCZ3287");

            var person = new Person("Ian", "Kovalski", "Melbourne, Something 6 St.");

            person.AddVehicle(car1.Registration);
            person.AddVehicle(car2.Registration);
            person.AddVehicle(car3.Registration);
            person.AddVehicle(car3.Registration);
            person.PrintInfo();


            person.RemoveVehicle(car1.Registration);
            person.PrintInfo();

            person.RemoveVehicle(car2.Registration);
            person.RemoveVehicle(car3.Registration);
            person.RemoveVehicle(car3.Registration);
            person.PrintInfo();

            Console.ReadKey();
        }
    }
}
