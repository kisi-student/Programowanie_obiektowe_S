using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public partial class MyTwoWayList<T>: IEnumerable<T>
    {
        protected class MyTwoWayEnumerator: IEnumerator<T>
        {
            Node first, current;
            public MyTwoWayEnumerator(Node first)
            {
                this.first = this.current = new Node { next = first };
            }

            public T Current => this.current.Value;
            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //destr
            }

            public bool MoveNext()
            {
                if (current != null)
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
        public IEnumerator<T> GetEnumerator()
        {
            return new MyTwoWayEnumerator(first);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyTwoWayEnumerator(first);
        }
    }
}
