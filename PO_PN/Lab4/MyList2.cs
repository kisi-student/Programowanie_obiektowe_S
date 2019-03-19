using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class MyList2<T>
    {
        protected class Node
        {
            public T value { get; set; }
            public Node next;
            public Node prev;
        }

        protected Node first = null;
        protected Node last = null;

        public void Add(T element)
        {
            if (first == null)
                first = last = new Node() { value = element };
            else
                last = last.next = new Node() { value = element, prev = last };
        }

        public void Insert(int index, T element)
        {
            var it = first;
            while(it!=null && index-- > 0)
                it = it.next;
            if (it == null)
                throw new IndexOutOfRangeException();
            var n = it.prev = new Node() { value=element, next = it, prev = it.prev };
            if (n.prev != null)
                n.prev.next = n;
        }


        private Node Get(int i)
        {
            var e = first;
            while (i-- > 0 && e != null)
                e = e.next;
            if (e == null)
                throw new IndexOutOfRangeException();
            return e;
        }

        public T this[int i] { get => Get(i).value; set => Get(i).value = value; }
    }

    public partial class MyList2<T> : IEnumerable<T>
    {
        class MyEnumerator : IEnumerator<T>
        {
            protected Node fisrst, current;
            public MyEnumerator(Node first)
            {
                this.fisrst = this.current = new Node { next = first };
            }

            public T Current => this.current.value;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // destruktor
            }

            public virtual bool MoveNext()
            {
                Console.Write("n");

                if (current != null)
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

    public partial class MyList2<T> : IEnumerable<T>
    {

        class MyRevEnumerator: MyEnumerator{
            public MyRevEnumerator(Node last)
                :base(null){
                current.prev = last;
            }
            public override bool MoveNext()
            {
                if (current != null)
                    current = current.prev;
                return current != null;
            }
        }

        public IEnumerator<T> GetRevEnumerator()
        {
            return new MyRevEnumerator(last);
        }
        
    }


    public class MyRevList<T> : IEnumerable<T>
    {
        MyList2<T> list;
        public MyRevList(MyList2<T> list)
        {
            this.list = list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetRevEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)(list.GetRevEnumerator());
        }
    }
}
