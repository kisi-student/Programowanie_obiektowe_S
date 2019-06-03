using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class RoomRentService : Service
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public HotelRoom Room { get; set; }
    }
}