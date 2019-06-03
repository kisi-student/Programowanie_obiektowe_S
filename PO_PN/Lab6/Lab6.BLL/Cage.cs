using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public class Cage : IAction, IObject , IInfo
    {
        public Cage(String id, int size)
        {
            Id = id;
            Size = size;
            Animals = new List<Animal>();
        }

        public Cage Add(Animal animal)
        {
            if (Animals.Count < Size)
                Animals.Add(animal);
            return this;
        }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }

        public string Id { get; set; }
        public int Size { get; set; }
        public Person Keeper { get;set;}
        public IList<Animal> Animals { get; set; }
    }
}
