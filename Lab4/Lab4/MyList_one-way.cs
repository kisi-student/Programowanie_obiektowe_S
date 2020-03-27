using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public partial class MyList_one_way<T>
    {
        public uint Count { get; private set; }

        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }

        private Node _first = null;
        private Node _last = null;

        public void Add(T element)
        {
            if (_first == null)
                _first = _last = new Node() { Value = element };
            else
                _last = _last.Next = new Node() { Value = element };
           
            Count++;
        }

        private Node Get(uint i)
        {
            var e = _first;
            while (i > 0 && e != null)
            {
                e = e.Next;
                i--;
            }
            if (e == null)
                throw new IndexOutOfRangeException();
            return e;
        }

        public void Insert(uint i, T element)
        {
            if(i >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            var el = new Node();
            el.Value = element;
            if(i == 0)
            {
                el.Next = _first;
                _first = el;
                
            }
            else if(i  == (Count-1))
            {
                _last = el;
                _last.Next = null;
                Get(i).Next = _last;
                
            }
            else
            {
                el.Next = Get(i - 1).Next;
                Get(i - 1).Next = el;
            }
            Count++;
        }

        public void Remove(T element)
        {
            Node e = _first;

            if((e.Value.Equals(element)))
            {
                _first = e.Next;
                Count--;
                return;
            }

            uint i = 1;
            while(e != null)
            {
                e = Get(i);
                if(e.Value.Equals(element))
                {
                    if(i == (Count - 1))
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

        public void RemoveAt(uint i)
        {
            if(i >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            var element = Get(i);

            if(i == 0)
            {
                _first = _first.Next;
            }
            else if(i == (Count - 1))
            {
                _last = Get(i - 1); 
                _last.Next = null;
            }
            else
            {
                Get(i - 1).Next = element.Next;
            }
            Count--;
            
        }

        public T this[uint i] { get => Get(i).Value; set => Get(i).Value = value; }
    }
}