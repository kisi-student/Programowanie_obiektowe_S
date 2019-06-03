using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.BLL
{
    public class Zoo : IAction, IObject, IInfo
    {
        public IList<Person> Workers { get; set; }
        public IList<Cage> Cages { get; set; }

        public Zoo()
        {
            Workers = new List<Person>();
            Cages = new List<Cage>();
        }

        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
