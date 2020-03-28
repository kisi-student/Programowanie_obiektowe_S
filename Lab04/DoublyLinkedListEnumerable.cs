using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public partial class DoublyLinkedList<T> : IEnumerable<T>
    {

        class RevEnumerator : IEnumerator<T>
        {
            Node firstNode, currentNode;

            public RevEnumerator(Node first)
            {
                this.firstNode = first = currentNode = new Node { prev = first };
            }

            public T Current => this.currentNode.element;

            object IEnumerator.Current => Current;

            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (currentNode != null)
                    currentNode = currentNode.prev;
                return currentNode != null;
            }

            public void Reset()
            {
                currentNode = firstNode;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new RevEnumerator(lastElement);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new RevEnumerator(lastElement);
        }
    }
}
