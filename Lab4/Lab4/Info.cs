using System;

namespace Lab4
{
    public class Info
    {
        public static void WriteInfo(MyOneWayList<Person> _list)
        {
            int i = 0; 
            foreach (var item in _list)
            {
                Console.WriteLine($"{++i}. {item}");
            }
        }

        public static void WriteInfo(MyTwoWayList<Person> _list)
        {
            int i = 0;
            foreach (var item in _list)
            {
                Console.WriteLine($"{++i}. {item}");
            }
        }
        
    }
}
