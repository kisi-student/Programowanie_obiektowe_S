using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public class MealService : Service
    {
        public bool Vegetarian { get; set; }
        public bool Breakfast { get; set; }
        public bool Dinner { get; set; }
    }
}