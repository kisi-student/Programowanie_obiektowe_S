using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{   
    public class Service : IBillItem
    {
        public Service(float name, float price, float quantit)
        {
           // Name = name;
           // Price = price;
           // Quantit = quantit;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}