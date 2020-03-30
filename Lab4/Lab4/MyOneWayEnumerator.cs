using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class MyOneWayList<T> : IEnumerable<T>
    {
        protected class MyOneWayEnumerator : IEnumerator<T>
        {
            Node first, current;
            public MyOneWayEnumerator(Node first)
            {
                this.first = first = this.current = new Node { next = first };
            }

            public T Current => this.current.Value;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //destruktor
            }

            public bool MoveNext()
            {
                if(current != null)
                {
                    current = current.next;
                }
                return current != null;
            }

            public void Reset()
            {
                current = first;
            }
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return new MyOneWayEnumerator(first);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyOneWayEnumerator(first);
        }
    }
}
