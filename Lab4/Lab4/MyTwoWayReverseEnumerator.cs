using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class MyTwoWayReverseEnumerator<T>:MyTwoWayList<T>, IEnumerable<T>
    {
        protected class MyTwoWayREnumerator : IEnumerator<T>
        {
            Node last, current;
            public MyTwoWayREnumerator(Node last)
            {
                this.last = this.current = new Node { prev = last };
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
                    current = current.prev;
                }
                return current != null;
            }

            public void Reset()
            {
                current = last;
            }
        }
        public new IEnumerator<T> GetEnumerator()
        {
            return new MyTwoWayEnumerator(last);
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new MyTwoWayEnumerator(last);
        }
    }
}
