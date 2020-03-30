using System;
using System.Collections.Generic;

namespace Lab4
{
    public partial class MyOneWayList<T>
    {
        protected class Node
        {
            public T Value { get; set; }
            public Node next;
        }

        public int Number { get; private set; }
        protected Node first = null;
        protected Node last = null;
        
        public void Add(T element)
        {
            if(first == null)
            {
                first = last = new Node() { Value = element };
            }
            else
            {
                last = last.next = new Node() { Value = element };
            }
            Number += 1;
        }

        public void RemoveAt(int i)
        {
            if(i < Number && i >= 0)
            {
                var e = Get(i);
                if (i == 0)
                {
                    first = first.next;
                }
                else if (i == (Number-1))
                {
                    last = Get(i - 1);
                    last.next = null;
                }
                else
                {
                    Get(i - 1).next = e.next;
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
                if(e.Value.Equals(element))
                {
                    first = e.next;
                    Number--;
                }
                else 
                {
                    int i = 1;
                    while (i < Number)
                    {
                        e = Get(i);
                        if (e.Value.Equals(element))
                        {
                            if (i == (Number-1))
                            {
                                last = Get(i - 1);
                                last.next = null;
                            }
                            else
                            {
                                Get(i - 1).next = e.next;
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
            if (i<Number && i>=0)
            {
                var e = new Node() { Value = element };
                if (i == 0)
                {
                    e.next = first;
                    first = e;
                }
                else if (i == (Number-1))
                {
                    last = e;
                    last.next = null;
                    Get(i).next = last;
                }
                else
                {
                    e.next = Get(i - 1).next;
                    Get(i - 1).next = e;
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
