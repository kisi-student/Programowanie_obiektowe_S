using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public partial class MyList_one_way<T> : IEnumerable<T>
    {
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new MyEnumerator(_first);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(_first);
        }

        class MyEnumerator : IEnumerator<T>
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
                //destructor
            }

            public bool MoveNext()
            {
                if (current != null)
                    current = current.Next;
                return current != null;
            }

            public void Reset()
            {
                current = first;
            }
          
        }
    }
}
