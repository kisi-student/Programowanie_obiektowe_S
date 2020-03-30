using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class MyTwoWayList<T>
    {
        protected class Node
        {
            public T Value { get; set; }
            public Node next;
            public Node prev;
        }

        public int Number { get; private set; }
        protected Node first = null;
        protected Node last = null;

        public void Add(T element)
        {
            if (first == null)
            {
                first = last = new Node() { Value = element };
            }
            else
            {
                Node el = new Node { Value = element };
                el.prev = last; //poprzedni wskazuje na ostatni
                last = last.next = new Node() { Value = element };
            }
            Number += 1;
        }

        public void RemoveAt(int i)
        {
            if(i < Number && i >=0)
            {
               
                if (i == 0)
                {
                    first.next.prev = null; //kasujemy pierwszy, wiec poprzendi jest nullem
                    first = first.next;
                }
                else if (i == (Number-1))
                {
                    last.prev.next = null;
                }
                else
                {
                    var ne = Get(i+1);
                    var pe = ne.prev.prev;
                    pe.next = ne;
                    ne.prev = pe;
                }
                Number--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        public void Remove(T element)
        {
            var e = first;
            if(e == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                if (e.Value.Equals(element))
                {
                    first.next.prev = null;
                    first = e.next;
                    Number--;
                }
                else
                {
                    int i = 1;
                    while (i < Number)
                    {
                        e = Get(i);
                        var pe = e.prev;
                        if (e.Value.Equals(element))
                        {
                            if (i == (Number-1))
                            {
                                last.prev.next = null;
                            }
                            else
                            {
                                pe.next = e;
                                e.prev = pe;
                            }
                            Number--;
                            break;
                        }
                        i++;
                        if (i == Number)
                        {
                            throw new KeyNotFoundException();
                        }
                    }
                }
            }
        }

        public void Insert(int i, T element)
        {
            if(i<Number && i>=0)
            {
                var e = new Node() { Value = element };
                if (i == 0)
                {
                    e.next = first;
                    first = first.prev = e;
                }
                else if(i == (Number-1))
                {
                    last.next = e;
                    last.next.next = null;
                    e.prev = last;
                    last = e;
                }
                else
                {
                    var _prev = Get(i - 1);
                    var _next = _prev.next;
                    _prev.next = e;
                    _next.prev = e;
                    e.prev = _prev;
                    e.next = _next;
                }
                Number++;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        private Node Get(int i)
        {
            var e = first;
            while (i-- > 0 && e != null)
            {
                e = e.next;
            }
            if (e == null)
            {
                throw new IndexOutOfRangeException();
            }
            return e;
        }

        public T this[int i] { get => Get(i).Value; set => Get(i).Value = value; }
    }
}
