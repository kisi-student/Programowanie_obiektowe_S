using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class HotelRoom
    {
        public int RoomNumber { get; set; }
        public int Floor{get; set;}
        public String Type { get; set; }
        public float PricePerDay { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}