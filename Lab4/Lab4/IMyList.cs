using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    interface IMyList<T>
    {
        void RemoveAt(uint i);
        void Remove(T element);
        void Insert(uint i, T element);
        void Add(T element);
        
    }
}
