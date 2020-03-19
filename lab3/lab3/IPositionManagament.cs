using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface IPositionManagament
    {
        Position FindPositionById(int id);
        Position FindPositionByTitle(string title);
        Position FindPositionByPublisher(string publisher);
        Position FindPositionByPublishYear(int publishYear);
        void InfoAll();
    }
}
