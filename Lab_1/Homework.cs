using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using Lab_1;

namespace Lab_1
{
    class Homework
    {
        public static void Run()
        {
            var car1 = new Car("Fiat", "126p", "SCZ6969", 2, 650, 6.0);
            var car2 = new Car("Syrena", "105", "SCZ8888", 2, 800, 7.6);
            var car3 = new Car("Ferrari", "Italia", "SCZ3287", 2, 800, 7.6);

            var person = new Person("Ian", "Kovalski", "Melbourne, Something 6 St.");

            person.PushCar(car1.RegistrationNumber);
            person.PushCar(car2.RegistrationNumber);
            person.PushCar(car3.RegistrationNumber);
            person.PushCar(car3.RegistrationNumber);
            person.PrintInfo();


            person.PopCar(car1.RegistrationNumber);
            person.PrintInfo();

            person.PopCar(car2.RegistrationNumber);
            person.PopCar(car3.RegistrationNumber);
            person.PopCar(car3.RegistrationNumber);
            person.PrintInfo();


            Console.ReadKey();
        }
    }
}
