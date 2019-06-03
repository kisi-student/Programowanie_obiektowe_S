using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public abstract class Animal: IObject
    {
        protected Animal(string species, string name, string food, string origin)
        {
            Species = species;
            Name = name;
            Food = food;
            Origin = origin;
        }

        public string Species { get; set; }
        public string Name { get; set; }
        public string Food { get; set; }
        public string Origin { get; set; }

        public override string ToString()
        {
            return $"{Species} {Name} {Food} {Origin}";
        }
        
    }
}
