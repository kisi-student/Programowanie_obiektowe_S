using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car s1 = new Car();

            s1.Write_info();
            s1.Brand = "fiat";
            s1.Model = "126p";
            s1.Number_of_doors = 2;
            s1.Engine_capacity = 650;
            s1.Average_fuel_consumption = 6.0;

           s1.Write_info();

            Car s2 = new Car("Syrena", "105", 2, 800, 7.6);

            s2.Write_info();

            double cost_of_trip = s2.Calculate_the_fare(30.5, 4.85);
            Console.WriteLine("Cost of trip: {0}", cost_of_trip);

            Car.List_the_number_of_cars();
            Console.ReadKey();


        }
    }
}
