using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Car
    {
        private string brand, model;
        private int number_of_doors, engine_capacity;
        private double average_fuel_consumption;
        private static int number_of_cars = 0;

        public Car ()
        {
            brand = "unknown";
            model = "unknown";
            number_of_doors = 0;
            engine_capacity = 0;
            average_fuel_consumption = 0.0;
            number_of_cars++;
        }
        public Car (string _brand, string _model, int _number_of_doors, int _engine_capacity, double _average_fuel_consumption)
        {
            brand = _brand;
            model = _model;
            number_of_doors = _number_of_doors;
            engine_capacity = _engine_capacity;
            average_fuel_consumption = _average_fuel_consumption;
            number_of_cars++;
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value;}
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Number_of_doors
        {
            get { return number_of_doors; }
            set { number_of_doors = value; }
        }
        public int Engine_capacity
        { 
            get { return engine_capacity; }
            set { engine_capacity = value; }
        }
        public double Average_fuel_consumption
        {
            get { return average_fuel_consumption; }
            set { average_fuel_consumption = value; }
        }
        private double Calculate_sc (double route_length)
        {
            return (average_fuel_consumption * route_length) / 100;
        }
        public double Calculate_the_fare(double route_length, double fuel_price)
        {
            return (Calculate_sc(route_length) * fuel_price);
        }
        public void Write_info()
        {
            Console.WriteLine("Brand: {0}", brand);
            Console.WriteLine("Model: {0}", model);
            Console.WriteLine("Number of doors: {0}", number_of_doors);
            Console.WriteLine("Engine capacity: {0}", engine_capacity);
            Console.WriteLine("Average fuel consumption: {0}", average_fuel_consumption);
        }
        public static void List_the_number_of_cars()
        {
            Console.WriteLine("Number of cars: "+ number_of_cars);
        }
    }
}
