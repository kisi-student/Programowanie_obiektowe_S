using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public class Bird : Animal
    {
        public Bird(string species, string name, string food, string origin, float wingspan) : base(species, name, food, origin)
        {
            Wingspan = wingspan;
        }

        public float Wingspan { get; set; }
    }
}
