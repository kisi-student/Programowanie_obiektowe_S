using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    interface IPositionManagement
    {
        Position FindPositionByTitle(string title);
        Position FindPositionById(uint id);
        void PrintAllPositions();
    }
}
