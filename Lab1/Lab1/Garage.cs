using System;
using System.Collections.Generic;


namespace Lab1
{
    public class Garage
    {
        public string Address { get; set; }

        private int capacity;
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; cars = new Car[capacity]; }
        }

        private int carCount;
        private Car[] cars;

        public Garage()
        {
            Address = "none";
            capacity = 0;
            cars = null;
        }

        public Garage(string address, int capacity)
        {
            Address = address;
            Capacity = capacity;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            string str = $"Garage address: {Address}, Capacity: {Capacity}, Cars: {carCount}\nCars in the garage:\n";

            foreach (var car in cars)
            {
                if (car != null)
                    str += car.ToString();
            }
            
            return str;
        }

        public void DriveIn(Car car)
        {
            if(!(Capacity == carCount))
            {
                cars[carCount] = car;
                carCount++;
            }
            else 
            {
                Console.WriteLine("Garage is full!\n");
            }
        }

        public Car DriveOut()
        {
            if (carCount > 0)
            {
                Car car = new Car();

                car = cars[carCount - 1];
                cars[carCount - 1] = null;
                carCount--;
                return car;
            }
            else
            {
                Console.WriteLine("Garage is empty!\n");
            }
            return null;
        }
    }
}
