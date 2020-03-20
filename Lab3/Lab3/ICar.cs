using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface ICar
    {
        string _rejestracja { get; set; }

        void Drive();
        void Crash(string car);
    }
}
