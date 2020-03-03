using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Garage
    {
        private string address;
        private int capacity;
        private int carCount = 0;
        private Car[] cars;

        public string Address{
            get { return address; }
            set { address = value; }
        }

        public int Capacity {
            get { return capacity; }
            set { capacity = value; cars = new Car[capacity]; }
        }

        public Garage() {
            address = "none";
            capacity = 0;
            cars = null;
        }
        public Garage(string _address, int _capacity) {
            address = _address;
            capacity = _capacity;
            cars = new Car[capacity];
        }
        public void PushCar(Car c) {
            if (carCount == capacity) { Console.WriteLine("Garage full"); }
            else {
                cars[carCount++] = c;
            }
        }
        public Car PopCar() {
            if (carCount < 1) { Console.WriteLine("Garage is empty"); return null; }
            else {
                cars[--carCount] = null;
                return cars[carCount];
            }
        }

    }
}
