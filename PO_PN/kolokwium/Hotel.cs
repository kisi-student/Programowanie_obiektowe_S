using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class Hotel
    {
        protected List<HotelRoom> Rooms;
        protected List<ClientOrder> Orders;
        
        protected void BillPrint(List<IBillItem> items)
        {
        }
        protected void Print<T>(List<T> items)
        {
        }
        protected void Print<T>(T item)
        {
        }
    }
}