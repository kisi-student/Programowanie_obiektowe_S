using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new DateTime(2000, 12, 12);
            Console.WriteLine(d < DateTime.Now);
            Console.ReadKey();
        }
    }
}
