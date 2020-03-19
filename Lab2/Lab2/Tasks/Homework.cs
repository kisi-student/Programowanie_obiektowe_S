using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab2;

namespace Tasks
{
   public class Homework
{
        public static void DoWork()
        {
           
            var handballPlayer = new HandballPlayer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "obrońca", "FC Częstochowa");
            var footballPlayer = new FootballPlayer("Piotr", "Kos", new DateTime(1984, 9, 14), "napastnik", "FC Politechnika");

            handballPlayer.PrintInfo();
            footballPlayer.PrintInfo();

            handballPlayer.Score();
            footballPlayer.Score();

            handballPlayer.PrintInfo();
            footballPlayer.PrintInfo();

            Console.ReadKey();
            Console.Clear();
        }
        
    }
}
