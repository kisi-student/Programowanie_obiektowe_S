using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public interface IBillItem
    {
        float Name { get; set; }
        float Price { get; set; }
        float Quantit { get; set; }
    }
}