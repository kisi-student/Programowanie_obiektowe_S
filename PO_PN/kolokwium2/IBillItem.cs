using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kolokwium
{
    public interface IBillItem
    {
        string Name { get; set; }
        float Price { get; set; }
        int Quantit { get; set; }
    }
}