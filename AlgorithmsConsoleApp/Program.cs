using Algorithms.Sorting;
using Algorithms.StringManupulation;
using System;

namespace AlgorithmsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sorting Trigger
            TestMergeSort();
            TestBubbleSort();
            TestInsertionSort();
            #endregion

            #region String Manipulation Trigger
            TestAnagram();
            TestUniqueCharacter();
            TestUniqueCharacterUsingBitShifter();
            #endregion

            Console.ReadKey();
        }

        #region Sorting
        public static void TestMergeSort()
        {
            int[] numbers = { 2, 12, 3, 8, 4, 1, 5 };
            numbers.DoMergeSort();
            Console.WriteLine("MergeSort Output element is:" + string.Join(",", numbers));
        }

        public static void TestBubbleSort()
        {
            int[] numbers = { 2, 12, 3, 8, 4, 1, 5 };

            Console.WriteLine("Bubble SortInput element is:" + string.Join(",", numbers));
            numbers.DoBubbleSort();
            Console.WriteLine("BubbleSort Output element is:" + string.Join(",", numbers));
        }

        public static void TestInsertionSort()
        {
            int[] numbers = { 3,1,2 };

            Console.WriteLine("Insertion SortInput element is:" + string.Join(",", numbers));
            numbers.DoInsertionSort();
            Console.WriteLine("Insertion Output element is:" + string.Join(",", numbers));
        }

        public static void TestSelectionSort()
        {
            int[] numbers = { 3, 1, 2 };

            Console.WriteLine("Insertion SortInput element is:" + string.Join(",", numbers));
            numbers.DoSelectionSort();
            Console.WriteLine("Insertion Output element is:" + string.Join(",", numbers));
        }
        #endregion

        public static void TestAnagram()
        {
            var firstString = "geeksforgeeks";
            var secondString = "forgeeksgeeks";
            var result = firstString.IsAnagram(secondString);
            Console.WriteLine($"String1:{firstString} and string2:{secondString}. IsAnagram:{result.ToString()}");
        }
        public static void TestUniqueCharacter()
        {
            var firstString = "geeksforgeeks";
            var result = firstString.IsUniqueCharacterChecker();
            Console.WriteLine($"String1:{firstString} IsUniqueCharacter:{result.ToString()}");
        }

        public static void TestUniqueCharacterUsingBitShifter()
        {
            var firstString = "geeksforgeeks";
            var result = firstString.IsUniqueCharacterCheckerUsingBitShifter();
            Console.WriteLine($"String1:{firstString} IsUniqueCharacter:{result.ToString()}");
        }
    }
}
