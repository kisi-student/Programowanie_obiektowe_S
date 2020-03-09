using System;

using zadanie3osoba;

namespace Tasks
{
    public class Homework
    {
        public static void DoWork()
        {
            //var person = new Person();
            //var osobaJakoString = person.ToString();

            Person person = new Person("Ola", "Pyrkosz", "Jakis 31");

            person.PushCar("SZC3234");
            person.PushCar("SZC3235");
            person.PushCar("SZC3236");
            person.PushCar("SZC3237");

            person.PrintInfo();

            person.PopCar("SZC3236");

            person.PrintInfo();

            person.PopCar("SZC3234");
            person.PopCar("SZC3236");
            person.PopCar("SZC3235");

            person.PrintInfo();

            Console.ReadKey();
        }
    }
}
