using CustomNode = DataStructure.LinkedList;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataStructure.cs.LinkedList
{
    public class LinkedList<T>: ICollection<T>
    {
        public CustomNode.LinkedListNode<T> Head { get; private set; }
        public CustomNode.LinkedListNode<T> Tail { get; private set; }

        #region Add

        public void AddFirst(T value)
        {
            AddFirst(new CustomNode.LinkedListNode<T>(value));
        }
        public void AddFirst(CustomNode.LinkedListNode<T> node)
        {
            node.Next = Head;
            Head = node;
            Count++;

            if (Count == 1)
                Tail = Head;
        }

        public void AddLast(T value)
        {
            AddLast(new CustomNode.LinkedListNode<T>(value));
        }
        public void AddLast(CustomNode.LinkedListNode<T> node)
        {
            if (Count == 0)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;                
            }

            Tail = node;
            Count++;
        }

        #endregion

        #region Remove

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                Head = Head.Next;
                Count--;
                if(Count == 0)
                {
                    Tail = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count == 0)
                return;

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var current = Head;
                while (current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;
            }
                Count--;
        }
        #endregion

        #region ICollection
        public int Count { get; private set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            AddFirst(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            var current = Head;
            while(current != null)
            {
                if(current.Value.Equals(item))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
