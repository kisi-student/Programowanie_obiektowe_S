using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IPositionManagment
    {
        Position FindPositionByTitle(string _title);

        Position FindPositionById(int _id);
        void WriteAllPositions();

    }
}
