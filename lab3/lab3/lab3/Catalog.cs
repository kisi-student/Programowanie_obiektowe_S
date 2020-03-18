using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Catalog
    {
        public string ThematicDepartment { get; set; }
        public Catalog()
        { }
        public Catalog(string _thematicDepartment)
        {
            ThematicDepartment = _thematicDepartment;
        }
        //public void AddPosition(Position position)
        //{

       // }
    }
}
