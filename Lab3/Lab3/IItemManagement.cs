using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IItemManagement
    {
        void FindItemByPhrase(string phrase_);

        void FindItemByNumber(int number);

        void ShowAll();
    }
}
