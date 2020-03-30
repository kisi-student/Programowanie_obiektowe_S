using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--------Zad1---------");
            var list = new MyOneWayList<Person>
           {
               new Person("Jan", "Kowalski", 12),
               new Person("Ala", "Nowak", 32),
               new Person("Maja", "Marchewka", 14),
               new Person("Jakub", "Kowalski", 17),
               new Person("Janusz", "Nosacz", 65)
           };
            
            Info.WriteInfo(list);
            Console.WriteLine("\nLista osob pelnoletnich");
            for (int i = 0; i < list.Number; i++)
            {
                if (list[i].Age >= 18)
                {
                    Console.WriteLine(list[i].ToString());
                }
            }
            try
            {
                Console.WriteLine("\nDodanie osoby na koncu");
                list.Add(new Person("Stasiek", "Las", 45));
                Info.WriteInfo(list);

                Console.WriteLine("\nDodanie osoby w wybrane miejsce");
                list.Insert(3, new Person("Mariusz", "Czajka", 23));
                Info.WriteInfo(list);

                Console.WriteLine("\nUsuniecie wybranego elementu");
                list.RemoveAt(3);
                Info.WriteInfo(list);

                Console.WriteLine($"\nUsuniecie osoby {list[4].ToString()}");
                list.Remove(list[4]);
                Info.WriteInfo(list);

                Console.WriteLine("\nProba skasowania osoby ktorej nie ma");
                list.Remove(new Person("Miszczunioo", "Majaczunio", 20));
                Info.WriteInfo(list);

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("Nie ma osoby o podanych danych");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nKobiety:");
            var sublist = list.Where(item => item.FirstName.EndsWith("a"));
            sublist.ToList().ForEach(item => Console.WriteLine(item));

            Console.WriteLine("\nNacisnij przycisk by przejsc do zadania 2");
            Console.ReadKey();
            Console.Clear();
             Console.WriteLine("-------Zad2---------");
              var list2 = new MyTwoWayReverseEnumerator<Person>
            {
                new Person("Jan", "Kowalski", 12),
                new Person("Ala", "Nowak", 32),
                new Person("Maja", "Marchewka", 14),
                new Person("Jakub", "Kowalski", 17),
                new Person("Janusz", "Nosacz", 65)
            };

             Info.WriteInfo(list2);
             Console.WriteLine("\nLista osob pelnoletnich");
             for (int i = 0; i < list2.Number; i++)
             {
                 if (list2[i].Age >= 18)
                 {
                     Console.WriteLine(list2[i].ToString());
                 }
             }
             try
             {
                 Console.WriteLine("\nDodanie osoby na koncu");
                 list2.Add(new Person("Stasiek", "Las", 45));
                 Info.WriteInfo(list2);

                 Console.WriteLine("\nDodanie osoby w wybrane miejsce");
                 list2.Insert(3, new Person("Mariusz", "Czajka", 23));
                 Info.WriteInfo(list2);

                 Console.WriteLine("\nUsuniecie wybranego elementu");
                 list2.RemoveAt(3);
                 Info.WriteInfo(list2);

                 Console.WriteLine($"\nUsuniecie osoby {list2[4].ToString()}");
                 list2.Remove(list[4]);
                 Info.WriteInfo(list2);

                 Console.WriteLine("\nProba skasowania osoby ktorej nie ma");
                 list2.Remove(new Person("Miszczunioo", "Majaczunio", 20));
                 Info.WriteInfo(list2);

             }
             catch (IndexOutOfRangeException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             catch (KeyNotFoundException)
             {
                 Console.WriteLine("Nie ma osoby o podanych danych");
             }
             catch (NullReferenceException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             Console.WriteLine("\nNacisnij przycisk by zakonczyc");
            
            Console.ReadKey();
            Console.Clear();
        }
    }
}
