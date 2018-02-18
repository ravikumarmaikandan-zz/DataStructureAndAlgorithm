using DataStructure.LinkedList;
using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestLinkedList();
            //TestFindMiddleInLinkedList();
            //TestDeleteMiddleInLinkedList();
            //TestFindNthNodeInLinkedList();
            TestDeleteAllMatchingElementsInLinkedList();
            Console.ReadKey();
        }

        public static void TestLinkedList()
        {
            LinkedList<int> linkedList = BuildLinkedList();

            foreach (var item in linkedList)
            {
                Console.WriteLine(item + "->");
            }
        }
        public static void TestFindMiddleInLinkedList()
        {
            var list = BuildLinkedList();
            list.DoFindMiddleNode();
        }
        public static void TestFindNthNodeInLinkedList()
        {
            var list = BuildLinkedList();
            Console.WriteLine("FindNthNodeInLinkedList");
            list.DoFindNthNode(7);
        }
        public static void TestDeleteMiddleInLinkedList()
        {
            var list = BuildLinkedList();
            list.DoDeleteMiddleNode(3);
        }

        public static void TestDeleteAllMatchingElementsInLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(1);

            linkedList.DoRemoveElements(1);
        }
        private static LinkedList<int> BuildLinkedList()
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddLast(40);
            linkedList.AddLast(50);
            return linkedList;
        }
    }
}
