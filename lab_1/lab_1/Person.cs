using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Person
    {
        private string name, lastname, residential_address;
        private int number_ofCars = 0;
        private Car[] car;

        public Person()
        {
            name = "unknown";
            lastname = "unknown";
            residential_address = "unknown";
            car = null;
        }
        public Person(string _name, string _lastname, string _residential_address, int _number_ofCars)
        {
            name = _name;
            lastname = _lastname;
            residential_address = _residential_address;
            number_ofCars = _number_ofCars;
            car = new Car[number_ofCars];
        }
        public void Add_car(Car _registration_number)
        {
            if (number_ofCars >= 3)
                Console.WriteLine("Cannot add a car");
            else
            {
                car[number_ofCars] = _registration_number;
                number_ofCars++;
            }
        }
        public void Remove_car(Car _registration_number)
        {
            for (int i = 0; i < number_ofCars; i++)
            {
                if (car[i] != _registration_number)
                    Console.WriteLine("Cannot remove a car");
                else
                {
                    car[i] = null;
                    number_ofCars--;
                }
            }
        }
        public void Write_info()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Lastname: {0}", lastname);
            Console.WriteLine("Residential address: {0}", residential_address);
            for(int i=0; i<number_ofCars;i++)
            {
                Console.WriteLine("Registration number no.{0}: {1}",i, car[i]);
            }
        }
    }
}
