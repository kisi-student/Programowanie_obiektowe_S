using System;

using Lab4.Interfaces;

namespace Lab4
{
    public partial class MyList<T> : IMyList<T>
    {
        class Node //kazdy wezel sklada sie z ajkis dnych i adersu nasptnego
        {
            public T Value { get; set; } //typ generyczny T bedzie wszytstkim intem personna itp
            public Node Next { get; set; } //nastepny wezel
        }

        public uint Count { get; private set; } //liczbea elementowe tej lsty, zwieksza jak sie dodajemy elemen no i sie zmniejsza jka usuwamy

        private Node _first = null; //poczatek listy
        private Node _last = null; //koncowka ostatni element

        public void Add(T element) //dodanie na koniec

            //MyList<iint> vs = new myList<int>();
            //vs.Add(1)
            //vs.Add(15)
        {
            if(_first == null) //jezeli list jest puysa
            {
                _first = _last = new Node() { Value = element }; //pierwszy element jest jednopczenie pierwszym i ostatnim (na pozatku)
            }
            else
            {
                //_last = _last.Next = new Node() { Value = element, Next = null }; //jak dodaje na sam koniec no to ten next pokazuje na null (isnstrukcja 4 stron1)
                _last.Next = new Node() { Value = element, Next = null }; // w tym momencie _last to jest 1
                //w tym momenie ustawiamy _last na 15
                _last = _last.Next; //za kazdym razem jak tworzymy nowy element to przesuwamy ten tytuł elementu ostatniego elemetu w prawo
            }
            Count++;
        }

        private Node Get(uint index) //pobiera z lisy element wedlug indeksu, pokolei przjezdza i zatrzymuje sie tam gdzie jest ten potrzebny element
        {
            var element = _first;
            while (index > 0 && element != null)
            {
                element = element.Next;
                index--;
            }
            if(element == null)
            {
                throw new IndexOutOfRangeException();
            }
            return element;
        }

        public void Remove(T element) //usuwa konrketny element, ale bez znajomosci indeksu,
            //mam schroniko na posow i chce tego konkretnego psa, ale nie mam zadnej ksiegi psow
            //ja mowie ze chce go usunac i tyle
        {
            Node e = _first; 

            if (e.Equals(element))
            {
                _first = e.Next;
            }

            uint i = 1;
            while(i < Count && e != null)
            {
                e = Get(i);
                if (e.Value.Equals(element))
                {
                    if (i == (Count - 1))
                    {
                        _last = Get(i - 1);
                        _last.Next = null;
                    }
                    else
                    {
                        Get(i - 1).Next = e.Next;
                    }

                    Count--;
                    break;
                }
                i++;
            }
        }

        public void RemoveAt(uint index) //usuwanie konrketnego elemendu spod jakiegos indekstu
        {
            var element = Get(index);
            
            if(index == 0)
            {
                _first = _first.Next;
            }
            else if(index == (Count - 1))
            {
                _last = Get(index - 1);
                _last.Next = null;
            }
            else
            {
                Get(index - 1).Next = element.Next;
            }
            Count--;
        }

        public void Insert(uint index, T element)
        {
            var e = new Node();
            e.Value = element;

            if(index == 0)
            {
                e.Next = _first;
                _first = e;
            }
            else if(index == (Count - 1))
            {
                _last = e;
                _last.Next = null;
                Get(index).Next = _last;
            }
            else
            {
                e.Next = Get(index - 1).Next;
                Get(index - 1).Next = e;
            }
            Count++;
        }

        public T this[uint index] //przeciazanie ooperatora indeksowania, zwraca element typu T (wartosc tego elementu) np inta 
            //tej listy spod jakiegos indeksu
        { 
            get => Get(index).Value; //lista [0] = 3 i geter w cww wysietli ta wartosc 3
            set => Get(index).Value = value; //set ustawi ta valuse na 3 
        }
    }
}
