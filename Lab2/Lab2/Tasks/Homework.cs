using System;

using Lab2;

namespace Tasks
{
    public class Homework
    {
        public static void DoWork()
        {
            Console.WriteLine("PRACA DOMOWA\n");

            var handballPlayer = new HandballPlayer("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Częstochowa");
            var footballPlayer = new FootballPlayer("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

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
