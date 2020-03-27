using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Task1
    {
        public static void Return()
        {
            Console.WriteLine("TASK 1\n");



            var people = new MyList_one_way<Person>();



            people.Add(new Person("Jan", "Kowalski", 12));

            people.Add(new Person("Ala", "Nowak", 32));

            people.Add(new Person("Krzysztof", "Krawczyk", 14));

            people.Add(new Person("Jakub", "Kowalski", 17));

            people.Add(new Person("Jan", "Nowak", 65));



            Console.WriteLine($"Unchanged list of people: ");

            PrintPeople(people);



            Console.WriteLine($"Adults: ");

            for (uint i = 0; i < people.Count; i++)

            {

                if (people[i].Age >= 18)

                    Console.WriteLine(people[i].ToString());

            }



            try

            {

                Console.WriteLine("\nInsert at 1:");

                people.Insert(1, new Person("Dawid", "Wójcik", 24));

                PrintPeople(people);



                Console.WriteLine("Insert at the beginning:");

                people.Insert(0, new Person("Damian", "Kaczmarek", 15));

                PrintPeople(people);



                Console.WriteLine("Insert at the end:");

                people.Insert(people.Count - 1, new Person("Kinga", "Dąbrowska", 15));

                PrintPeople(people);



                Console.WriteLine("Remove first: ");

                people.RemoveAt(0);

                PrintPeople(people);



                Console.WriteLine("Remove last: ");

                people.RemoveAt(people.Count - 1);

                PrintPeople(people);



                Console.WriteLine("Remove Krzysztof Krawczyk element: ");

                people.Remove(new Person("Krzysztof", "Krawczyk", 14));

                PrintPeople(people);



                Console.WriteLine("Try to remove non-existing person: ");

                people.Remove(new Person("Sławomir", "Mazur", 14));

                PrintPeople(people);



            }

            catch (IndexOutOfRangeException ex)

            {

                Console.WriteLine(ex.Message);

            }



            try

            {

                Console.WriteLine("Try to access invalid index 99:");

                Console.WriteLine(people[99]);

            }

            catch (IndexOutOfRangeException ex)

            {

                Console.WriteLine(ex.Message);

            }



            Console.ReadKey();

            Console.Clear();

        }



        private static void PrintPeople(MyList_one_way<Person> people)

        {

            for (uint i = 0; i < people.Count; i++)

            {

                Console.WriteLine(people[i].ToString());

            }

            Console.WriteLine();
        }
    }
}

