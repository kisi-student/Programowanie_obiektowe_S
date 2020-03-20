using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Tasks
{
    public class Task3
    {
        public static void Return()
        {
            var handballPlayer = new HandBaller("Mateusz", "Żbik", new DateTime(1986, 8, 10), "obrońca", "FC Częstochowa");
            var footballPlayer = new FootBaller("Piotr", "Kos", new DateTime(1984, 9, 14), "napastnik", "FC Politechnika");

            handballPlayer.PrintInfo();
            footballPlayer.PrintInfo();

            handballPlayer.Shoot();
            footballPlayer.Shoot();

            handballPlayer.PrintInfo();
            footballPlayer.PrintInfo();

            Console.ReadKey();
            Console.Clear();
        }

        }
    }

