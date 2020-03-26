using System;

using Lab4.Interfaces;

namespace Lab4
{
    public partial class MyList<T> : IMyList<T>
    {
        class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }
        
        public uint Count { get; private set; }

        private Node _first = null;
        private Node _last = null;

        public void Add(T element)
        {
            if(_first == null)
            {
                _first = _last = new Node() { Value = element };
            }
            else
            {
                // w tym momencie _last to jest 1
                _last.Next = new Node() { Value = element };
                
                // w tym momencie ustawiamy _last na 15
                _last = _last.Next; 
            }
            Count++;
        }

        private Node Get(uint index)
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

        public void Remove(T element)
        {
            Node e = _first; 

            if(e != null)
            {
                if (e.Value.Equals(element))
                {
                    _first = e.Next;
                    Count--;
                    return;
                }
                
                uint i = 1;
                while (i < Count)
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
        }

        public void RemoveAt(uint index)
        {
            if(index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

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
            if (index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            var e = new Node() { Value = element };

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

        public T this[uint index] 
        { 
            get => Get(index).Value;
            set => Get(index).Value = value;
        }
    }
}
