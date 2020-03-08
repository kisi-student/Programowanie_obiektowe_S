using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;

namespace Lab_1
{
    class Program // domyślnie typ Internal (ten sam komponent to public, więcej komponentów to private)
    {
        static void Main(string[] args)
        {
            Task_1.Run();
            Task_2.Run();
            Homework.Run();
        }
    }
}
