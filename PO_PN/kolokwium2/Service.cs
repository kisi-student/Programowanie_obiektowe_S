using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{   
    public class Service : IBillItem
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantit { get; set; }


        public Service(string name, float price, int quantit)
        {
            Name = name;
            Price = price;
            Quantit = quantit;
        }

        public override string ToString()
        {
            return $"{Name} cena:{Price}zł  ilosc:{Quantit}";
        }
    }
}