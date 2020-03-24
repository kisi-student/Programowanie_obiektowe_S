using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TwoWayList<T> : OnewayList<T>, IEnumerable<T>
    {
        private class MyEnumerator : IEnumerator<T>
        {
            Node first, current;

            public MyEnumerator(Node first)
            {
                this.first = first = this.current = new Node { Next = first };
            }

            public T Current => this.current.Value;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                // deconstructor
            }

            public bool MoveNext()
            {
                if(current != null)
                {
                    current = current.Next;
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
            return new MyEnumerator(_first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(_first);
        }
    }
}
