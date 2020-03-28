using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Interfaces
{
    interface IMyList<T>
    {
        void Add(T element);
        void Remove(T element);
        void RemoveAt(uint index);
        void Insert(uint index, T element);
    }
}
