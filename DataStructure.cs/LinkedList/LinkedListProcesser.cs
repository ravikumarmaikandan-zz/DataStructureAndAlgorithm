using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinkedList
{
    public static class LinkedListProcesser
    {
        #region Trigger
        public static void DoFindMiddleNode<T>(this LinkedList<T> list)
        {
            var node = FindMiddleNode(list);
            Console.WriteLine("Middle Node:" +node.Value.ToString());
        }
        public static void DoDeleteMiddleNode<T>(this LinkedList<T> list, T nodeToRemove)
        {
            var result = list.Remove(nodeToRemove);
            if (result)
            {
                Console.WriteLine("Deleted Node:" + nodeToRemove.ToString());
                PrintList(list);
            }
        }
        public static void DoFindNthNode<T>(this LinkedList<T> list, int n)
        {
            PrintList(list);
            var result = FindNthNode(list,n);
            if (result != null)
            {
                Console.WriteLine("Found Node:" + result.Value.ToString());                
            }
            else
            {
                Console.WriteLine("node not available");
            }
        }
        public static void DoRemoveElements<T>(this LinkedList<T> list, int n)
        {
            PrintList(list);
            var result = RemoveElements(list.Head, n);
            Console.WriteLine("New List, Removed all the node with value: " +n.ToString());
            if(result!= null)
                result.Print();
        }

        #endregion
        public static LinkedListNode<T> FindMiddleNode<T>(LinkedList<T> list)
        {
            var left = list.Head;
            var right = list.Head;
            while(right != null && right.Next != null)
            {
                left = left.Next;
                right = right.Next.Next;
            }

            return left;
        }
        public static LinkedListNode<T> FindNthNode<T>(LinkedList<T> list, int n)
        {
            var current = list.Head;
            int i = 1;
            while(i != n && current != null)
            {
                current = current.Next;
                i++;
            }

            return current;
        }
        public static LinkedListNode<T> RemoveElements<T>(LinkedListNode<T> head, int val)
        {
            var current = head;
            LinkedListNode<T> previous = null;
            while (current != null)
            {
                if (current.Value.Equals(val))
                {
                    if (previous == null )
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    current = current.Next;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                }
            }

            return head;
        }
        private static void PrintList<T>(LinkedList<T> linkedList)
        {
            Console.WriteLine("Actual List: ");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item + "->");
            }
        }
    }
}
