using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public class Mamal : Animal
    {
        public Mamal(string species, string name, string food, string origin, string envinfo) : base(species, name, food, origin)
        {
            EnvInfo = envinfo;
        }

        public string EnvInfo { get; set; }
    }
}
