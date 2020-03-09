using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Garage
    {
        private string address;
        private int capacity;
        private int number_of_cars = 0;
        private Car[] cars;

        public Garage()
        {
            address = "unknown";
            capacity = 0;
            cars = null;
        }
        public Garage(string _address, int _capacity)
        {
            address = _address;
            capacity = _capacity;
            cars = new Car[capacity];
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set
            {
                capacity = value;
                cars = new Car[capacity];
            }
        }
        public void Enter_the_car(Car car)
        {
            if (number_of_cars >= capacity)
                Console.WriteLine("Garage is full");
            else
            {
                cars[number_of_cars] = car;
                number_of_cars++;
            }
        }
        public Car Get_the_car_out()
        {
            if (number_of_cars == 0)
            {
                Console.WriteLine("Garage is empty");
                return null;
            }
            else
            {
                Car car = cars[number_of_cars - 1];
                cars[number_of_cars - 1] = null;
                number_of_cars--;
                return car;
            }
        }
        public void Write_information()
        {
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Capacity: {0}", capacity);
            Console.WriteLine("Number of cars: {0}", number_of_cars);

            for (int i = 0; i < number_of_cars; i++)
            {
                cars[i].Write_info();
            }
        }
    }
}
