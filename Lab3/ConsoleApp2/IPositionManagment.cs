using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IPositionManagment
    {
        Position FindPositionById(int _id);
        Position FindPositionByTitle(string _title);
        void WriteAllPositions();
    }
}
