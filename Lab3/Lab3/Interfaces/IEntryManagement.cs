using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IEntryManagement
    {
        Entry FindByTitle(string title);
        Entry FindById(int id);
        void PrintAllEntries();

    }
}
