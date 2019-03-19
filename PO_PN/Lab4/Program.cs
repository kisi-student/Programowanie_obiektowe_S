using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{



    public partial class MyList<T>
    {
        private class Node
        {
            public T value { get; set; }
            public Node next;
        }

        private Node first = null;
        private Node last = null;

        public void Add(T element)
        {
            if (first == null)
                first = last = new Node() { value = element };
            else
                last = last.next = new Node() { value = element };
        }

        private Node Get(int i)
        {
            var e = first;
            while (i-- > 0 && e != null)
                e = e.next;
            if(e==null)
                throw new IndexOutOfRangeException();
            return e;
        }

        public T this[int i] { get => Get(i).value; set => Get(i).value = value; }
    }

    public partial class MyList<T> : IEnumerable<T>
    {
        class MyEnumerator : IEnumerator<T>
        {
            Node fisrst, current;
            public MyEnumerator(Node first)
            {
                this.fisrst = first = this.current = new Node{ next = first };
            }

            public T Current => this.current.value;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // destruktor
            }

            public bool MoveNext()
            {
                if(current != null)
                    current = current.next;
                return current != null;
            }

            public void Reset()
            {
                current = fisrst;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyEnumerator(first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(first);
        }
    }


    class Person
    {
        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        static int _id = 101;

        public Person(string Firstname, string Lastname, int Age)
        {
            this.Id = _id++;
            this.Firstname = Firstname; this.Lastname = Lastname; this.Age = Age;
        }

        public override string ToString() => $"{Firstname} {Lastname} age: {Age} id: {Id}";
    }

    class Program
    {
        static void Main(string[] args)
        {
            var l = new MyList<int>();
            l.Add(1);
            l.Add(3);
            Console.WriteLine( $"pierwszy element: {l[0]}");

            var list = new MyList<Person>
            {
                new Person("Jan", "Kowalski", 12),
                new Person("Ala", "Nowak", 32),
                new Person("Maja", "Marchewka", 14),
                new Person("Jakub", "Kowalski", 17),
                new Person("Janusz", "Nosacz", 65)
            };
            

            Console.WriteLine("\nosoby:");
            int i = 0;
            foreach (var e in list)
            {
                Console.WriteLine( $"\t[{++i}]=> {e}" );
            }

            Console.WriteLine("\nkobiety:");
            var sublist = list.Where(e => e.Firstname.EndsWith("a"));
            sublist.ToList().ForEach(e=>Console.WriteLine(e));            

            //Console.ReadKey();


            var list2 = new MyList2<Person>
            {
                new Person("Jan", "Kowalski", 12),
                new Person("Ala", "Nowak", 32),
                new Person("Maja", "Marchewka", 14),
                new Person("Jakub", "Kowalski", 17),
                new Person("Janusz", "Nosacz", 65)
            };


            Console.WriteLine("\nosoby:");
            foreach (var e in list2)
            {
                Console.WriteLine(e);
            }

            var list2_rev = new MyRevList<Person>(list2);
            Console.WriteLine("\nosoby od konca:");
            foreach (var e in list2_rev)
            {
                Console.WriteLine(e);
            }


            list2.Insert(1, new Person("Ignacy", "Potocki", 2));
            list2[0].Firstname = "Zmiana";
            list2.Add(new Person("Klementyna", "Sobota", 30));

            Console.WriteLine("\nosoby od konca po zmianie:");
            foreach (var e in list2_rev)
            {
                Console.WriteLine(e);
            }



            Console.ReadKey();
        }
    }
}
