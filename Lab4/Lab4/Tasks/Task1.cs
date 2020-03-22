using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Tasks
{
    class Task1
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 1\n");

            OnewayList<int> onewayList = new OnewayList<int>();

            onewayList.Add(1);
            onewayList.Add(2);
            onewayList.Add(3);
            onewayList.Add(4);
            onewayList.Add(5);

            Console.WriteLine($"Unchanged list: ");
            PrintMyList(onewayList);

            //Console.WriteLine("Remove first: ");
            //onewayList.RemoveAt(0);
            //PrintMyList(onewayList);
            
            //Console.WriteLine("Remove last: ");
            //onewayList.RemoveAt(onewayList.Count - 1);
            //PrintMyList(onewayList);

            //Console.WriteLine("Remove 3: ");
            //onewayList.Remove(3);
            //PrintMyList(onewayList);

            //Console.WriteLine("Remove 30: ");
            //onewayList.Remove(30);
            //PrintMyList(onewayList);

            Console.WriteLine("Insert at 1:");
            onewayList.Insert(1,99);
            PrintMyList(onewayList);

            Console.WriteLine("Insert at the start:");
            onewayList.Insert(0, 12);
            PrintMyList(onewayList);

            Console.WriteLine("Insert at the end:");
            onewayList.Insert(onewayList.Count - 1, 12);
            PrintMyList(onewayList);

            try
            {
                Console.WriteLine("Try to access invalid index 99:");
                Console.WriteLine(onewayList[99]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void PrintMyList<T>(OnewayList<T> onewayList)
        {
            for (uint i = 0; i < onewayList.Count; i++)
            {
                Console.Write($"{onewayList[i]} ");
            }
            Console.WriteLine();
        }
    }
}
